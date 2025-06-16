using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Курсовая_работа_за_3_семестр
{
    public class ReportService
    {
        private readonly ClientService _clientService;
        private readonly EmployeeService _employeeService;

        public ReportService(ClientService clientService, EmployeeService employeeService)
        {
            _clientService = clientService;
            _employeeService = employeeService;
        }

        /// <summary>
        /// Возвращает таблицу для «Финансового отчёта» за указанный период.
        /// Столбцы: Дата, Сумма, Клиент.
        /// </summary>
        public DataTable GetFinancialReport(DateTime start, DateTime end)
        {
            var table = new DataTable();
            table.Columns.Add("Дата", typeof(string));
            table.Columns.Add("Сумма", typeof(string));
            table.Columns.Add("Клиент", typeof(string));

            decimal total = 0m;

            // Берём всех клиентов (физ. и юр.)
            var allClients = new List<Client>();
            allClients.AddRange(_clientService.Individuals.Cast<Client>());
            allClients.AddRange(_clientService.LegalEntities.Cast<Client>());

            foreach (var client in allClients)
            {
                foreach (var contract in client.Contracts ?? new List<Contract>())
                {
                    // Пока убираем Payments — берем сумму равной contract.Amount, если дата договора в диапазоне
                    var cStart = contract.StartDate.Date;
                    var cEnd = contract.EndDate.Date;
                    if (cStart >= start.Date && cStart <= end.Date)
                    {
                        var clientName = client is LegalEntity le
                            ? le.CompanyName
                            : (client as Individual)?.FullName ?? "—";

                        table.Rows.Add(
                            cStart.ToString("dd.MM.yyyy"),
                            $"{contract.Amount:N2} ₽",
                            clientName
                        );
                        total += contract.Amount;
                    }
                }
            }

            // Итоговая строка
            var row = table.NewRow();
            row["Дата"] = "Итого:";
            row["Сумма"] = $"{total:N2} ₽";
            row["Клиент"] = "";
            table.Rows.Add(row);

            return table;
        }


        /// <summary>
        /// Возвращает таблицу для «Графика дежурств» (смен) за указанный период.
        /// Столбцы: Охранник, Дата, Тип смены, Замена, Причина.
        /// </summary>
        public DataTable GetDutyScheduleReport(DateTime start, DateTime end)
        {
            var table = new DataTable();
            table.Columns.Add("Охранник", typeof(string));
            table.Columns.Add("Дата", typeof(string));
            table.Columns.Add("Тип смены", typeof(string));
            table.Columns.Add("Замена", typeof(string));
            table.Columns.Add("Причина", typeof(string));

            // Получаем всех охранников
            var guards = _employeeService.GetGuards();

            foreach (var guard in guards)
            {
                foreach (var shift in guard.DutySchedule?.Shifts ?? new List<Shift>())
                {
                    var shiftDate = shift.Date.Date;
                    if (shiftDate >= start.Date && shiftDate <= end.Date)
                    {
                        // Ищем ФИО заменяющего (если есть)
                        string replacementName = "";
                        if (!string.IsNullOrEmpty(shift.ReplacementEmployeeId))
                        {
                            var repEmp = _employeeService.Employees
                                            .FirstOrDefault(e => e.Id == shift.ReplacementEmployeeId);
                            if (repEmp != null)
                                replacementName = repEmp.FullName;
                        }

                        table.Rows.Add(
                            guard.FullName,
                            shiftDate.ToString("dd.MM.yyyy"),
                            shift.Type.ToString(),
                            replacementName,
                            shift.ReasonForReplacement ?? ""
                        );
                    }
                }
            }

            return table;
        }

        /// <summary>
        /// Возвращает таблицу для «Счёта клиенту» за указанный период.
        /// Столбцы: Клиент, Номер договора, Начало, Окончание, Сумма.
        /// </summary>
        public DataTable GetClientInvoiceReport(DateTime start, DateTime end)
        {
            var table = new DataTable();
            table.Columns.Add("Клиент", typeof(string));
            table.Columns.Add("Номер договора", typeof(string));
            table.Columns.Add("Начало", typeof(string));
            table.Columns.Add("Окончание", typeof(string));
            table.Columns.Add("Сумма", typeof(string));

            var allClients = new List<Client>();
            allClients.AddRange(_clientService.Individuals.Cast<Client>());
            allClients.AddRange(_clientService.LegalEntities.Cast<Client>());

            foreach (var client in allClients)
            {
                foreach (var contract in client.Contracts ?? new List<Contract>())
                {
                    var cStart = contract.StartDate.Date;
                    var cEnd = contract.EndDate.Date;
                    if (cStart >= start.Date && cEnd <= end.Date)
                    {
                        // Здесь заменяем ContractType.OneTime на ContractType.Охрана_мероприятия
                        decimal amount;
                        if (contract.ContractType == ContractType.Охрана_мероприятия)
                        {
                            var guardCount = contract.AssignedGuards?.Count ?? 0;
                            amount = contract.Hours * guardCount * contract.Amount;
                        }
                        else // ContractType.Охрана_объекта
                        {
                            amount = contract.Amount;
                        }

                        var clientName = client is LegalEntity le
                            ? le.CompanyName
                            : (client as Individual)?.FullName ?? "—";

                        table.Rows.Add(
                            clientName,
                            contract.Id,
                            cStart.ToString("dd.MM.yyyy"),
                            cEnd.ToString("dd.MM.yyyy"),
                            $"{amount:N2} ₽"
                        );
                    }
                }
            }

            return table;
        }


        /// <summary>
        /// Сохраняет переданную таблицу в CSV-файл по указанному пути.
        /// </summary>
        public void ExportToCsv(DataTable table, string filePath)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Заголовки
                var columnNames = table.Columns
                    .Cast<DataColumn>()
                    .Select(col => col.ColumnName);
                writer.WriteLine(string.Join(";", columnNames));

                // Данные
                foreach (DataRow row in table.Rows)
                {
                    var fields = table.Columns
                        .Cast<DataColumn>()
                        .Select(col => row[col]?.ToString().Replace(";", ","));
                    writer.WriteLine(string.Join(";", fields));
                }
            }
        }
    }
}
