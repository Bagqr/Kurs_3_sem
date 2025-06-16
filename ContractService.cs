using System;
using System.Collections.Generic;
using System.Linq;

namespace Курсовая_работа_за_3_семестр
{
    public class ContractService
    {
        private readonly ClientService _clientService;
        private readonly EmployeeService _employeeService; 


        public ContractService(ClientService clientService, EmployeeService employeeService)
        {
            _clientService = clientService;
            _employeeService = employeeService; 

        }

        // Сохраняет новый контракт у клиента
        public void AddContract(Client client, Contract contract)
        {
            // Добавляем договор
            client.Contracts.Add(contract);

            // Привязываем охранника к договору, если есть охранники
            var guard = _employeeService.GetGuards().FirstOrDefault();
            if (guard != null)
            {
                AssignGuard(contract, guard);
            }
        }



        // Возвращает данные для грида договоров
        public IEnumerable<object> GetGrid(Client client)
            => client.Contracts.Select(c => new
            {
                Тип = c.Type == ContractType.Охрана_объекта ? "Охрана объекта" : "Охрана мероприятия",
                Адрес = c.Type == ContractType.Охрана_объекта
                                           ? c.ObjectAddress
                                           : (c.EventDate?.ToString("g") ?? "—"),
                ДатаНачала = c.StartDate.ToShortDateString(),
                ДатаОкончания = c.EndDate.ToShortDateString(),
                Сумма = $"{c.Amount:N0} ₽",
                ТребуетсяОхранников = c.RequiredGuardCount,
                НазначеноОхранников = c.AssignedGuardIds?.Count ?? 0
            });

        // Назначает охранника на контракт, проверяя лимит
        public void AssignGuard(Contract contract, Employee guard)
        {
            // Проверяем, что договор и охранник не null
            if (contract == null || guard == null)
            {
                throw new ArgumentNullException("Договор или охранник не могут быть null");
            }
            
            // Проверяем, что охранник имеет должность "Охранник"
            if (guard.Position != "Охранник")
            {
                throw new ArgumentException("Охранник должен иметь должность \"Охранник\"");
            }

            // Привязываем охранника к договору
            contract.AssignedGuards.Add(guard);
            _clientService.SaveAll();
        }

        public List<Contract> GetContracts(Client client)
        {
            return client.Contracts.ToList(); // Возвращаем список контрактов
        }
        public List<Employee> GetAssignedGuards(Contract contract)
        {
            return contract.AssignedGuards;
        }
        public List<Contract> GetAll()
        {
            // Собираем контракты всех клиентов
            return _clientService.Individuals
                      .SelectMany(i => i.Contracts)
                      .Concat(_clientService.LegalEntities.SelectMany(e => e.Contracts))
                      .ToList();
        }


    }
}
