using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Курсовая_работа_за_3_семестр
{
    public partial class MainForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly ClientService _clientService;
        private readonly ContractService _contractService;
        private readonly ScheduleService _scheduleService;
        private readonly ReportService _reportService;

        public MainForm()
        {
            InitializeComponent();

            // 1. Сначала инициализируем все сервисы
            _employeeService = new EmployeeService("employees.json");
            _clientService = new ClientService("clients.json");
            _contractService = new ContractService(_clientService, _employeeService);
            _scheduleService = new ScheduleService(_employeeService);
            _reportService = new ReportService(_clientService, _employeeService);


            // 2. Подписываем события
            SubscribeEvents();

            // 3. Загружаем данные
            LoadAllData();

            // 4. И ТОЛЬКО ПОТОМ вызываем инициализацию вкладки "График дежурств"
            InitializeScheduleTab();

            // 5. Настраиваем грид (как у вас есть)
            dgvContracts.AutoGenerateColumns = false;
            dgvContracts.Columns.Clear();
            // Настройка столбцов dgvContracts
            dgvContracts.AutoGenerateColumns = false;
            dgvContracts.Columns.Clear();

            // Столбец ID
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = nameof(Contract.Id),
                ReadOnly = true
            });

            // Столбец Тип
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colType",
                HeaderText = "Тип",
                DataPropertyName = nameof(Contract.Type),
                ReadOnly = true
            });

            // Столбец Адрес объекта
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colObjectAddress",
                HeaderText = "Адрес объекта",
                DataPropertyName = nameof(Contract.ObjectAddress),
                ReadOnly = true
            });

            // Столбец Дата мероприятия
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEventDate",
                HeaderText = "Дата мероприятия",
                DataPropertyName = nameof(Contract.EventDate),
                ReadOnly = true,
                DefaultCellStyle = { Format = "dd.MM.yyyy HH:mm" }
            });

            // Столбец Дата начала
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStartDate",
                HeaderText = "Дата начала",
                DataPropertyName = nameof(Contract.StartDate),
                ReadOnly = true,
                DefaultCellStyle = { Format = "dd.MM.yyyy" }
            });

            // Столбец Дата окончания
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEndDate",
                HeaderText = "Дата окончания",
                DataPropertyName = nameof(Contract.EndDate),
                ReadOnly = true,
                DefaultCellStyle = { Format = "dd.MM.yyyy" }
            });

            // Столбец Сумма
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAmount",
                HeaderText = "Сумма",
                DataPropertyName = nameof(Contract.Amount),
                ReadOnly = true,
                DefaultCellStyle = { Format = "N0" }
            });

            // Столбец Требуется охранников
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRequiredGuards",
                HeaderText = "Требуется охранников",
                DataPropertyName = nameof(Contract.RequiredGuardCount),
                ReadOnly = true
            });

            // Столбец Назначено охранников (через добавленное свойство)
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAssignedGuards",
                HeaderText = "Назначено охранников",
                DataPropertyName = nameof(Contract.AssignedGuardCount),
                ReadOnly = true
            });
            // Настраиваем dgvIndividuals
            dgvIndividuals.AutoGenerateColumns = false;

            // Добавляем колонки и указываем, из какого свойства Individual брать значение
            dgvIndividuals.Columns.Clear();
            dgvIndividuals.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "ФИО",
                Name = "colFullName"
            });
            dgvIndividuals.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PassportData",
                HeaderText = "Паспорт",
                Name = "colPassport"
            });
            dgvIndividuals.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText = "Адрес",
                Name = "colAddress"
            });
            cbContractType.Items.Add(ContractType.Охрана_мероприятия);
            cbContractType.Items.Add(ContractType.Охрана_объекта);

            // Теперь привязываем источник — сам список Individual
            dgvIndividuals.DataSource = _clientService.Individuals;


            // Точно так же для dgvLegalEntities:
            dgvLegalEntities.AutoGenerateColumns = false;
            dgvLegalEntities.Columns.Clear();
            dgvLegalEntities.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CompanyName",
                HeaderText = "Название фирмы",
                Name = "colCompanyName"
            });
            dgvLegalEntities.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText = "Адрес",
                Name = "colCompanyAddress"
            });
            dgvLegalEntities.DataSource = _clientService.LegalEntities;


        }


        private void SubscribeEvents()
        {
            cbAssignEmployeeToContract.DropDown += cbAssignEmployeeToContract_DropDown;
            cbClientSelect.SelectedIndexChanged += cbClientSelect_SelectedIndexChanged;
            btnAddContract.Click += btnAddContract_Click;
            cbEmployeeSelectForSchedule.SelectedIndexChanged += cbEmployeeSelectForSchedule_SelectedIndexChanged;
            btnGenerateSchedule.Click += btnAddShift_Click;
            btnAddReplacement.Click += btnAddReplacement_Click;
            cbEmployeeSelectForSchedule.DropDown += cbEmployeeSelectForSchedule_DropDown;
        }


        private void LoadAllData()
        {
            // 1) Сотрудники и клиенты
            UIHelpers.BindGrid(dgvEmployees, _employeeService.GetGridViewData());
            UIHelpers.BindGrid(dgvIndividuals, _clientService.GetIndividualGrid());
            UIHelpers.BindGrid(dgvLegalEntities, _clientService.GetLegalEntityGrid());

            // 2) Заполняем combobox всех клиентов (физических + юр.)
            var allClients = _clientService.Individuals
                                           .Cast<Client>()
                                           .Concat(_clientService.LegalEntities)
                                           .ToList();
            UIHelpers.FillCombo(cbClientSelect, allClients,
                c => c is Individual i
                        ? i.FullName
                        : ((LegalEntity)c).CompanyName);

            // 3) Подпишемся на изменение выбора клиента (один раз)
            cbClientSelect.SelectedIndexChanged -= cbClientSelect_SelectedIndexChanged;
            cbClientSelect.SelectedIndexChanged += cbClientSelect_SelectedIndexChanged;

            // 4) Устанавливаем первый клиент по-умолчанию (если есть)
            if (cbClientSelect.Items.Count > 0)
                cbClientSelect.SelectedIndex = 0;
            else
                dgvContracts.DataSource = null;  // нет клиентов — чистим грид
        }


        private void InitializeScheduleTab()
        {
            // 1. Заполняем cbContractSelectForSchedule всеми контрактами
            var allContracts = _contractService.GetAll();
            UIHelpers.FillCombo(cbContractSelectForSchedule,
     allContracts,
     c =>
     {
         var client = c.Client;
         string clientName = client is Individual i ? i.FullName : (client as LegalEntity)?.CompanyName;
         string dateText = c.Type == ContractType.Охрана_мероприятия
                             ? c.EventDate?.ToString("dd.MM.yyyy")
                             : c.StartDate.ToString("dd.MM.yyyy");
         return $"{clientName} — {dateText}";
     });

            // 2. Подписываемся на события (один раз)
            cbContractSelectForSchedule.SelectedIndexChanged -= cbContractSelectForSchedule_SelectedIndexChanged;
            cbContractSelectForSchedule.SelectedIndexChanged += cbContractSelectForSchedule_SelectedIndexChanged;

            cbEmployeeSelectForSchedule.SelectedIndexChanged -= cbEmployeeSelectForSchedule_SelectedIndexChanged;
            cbEmployeeSelectForSchedule.SelectedIndexChanged += cbEmployeeSelectForSchedule_SelectedIndexChanged;

            // 3. Очищаем грид
            dgvSchedule.DataSource = null;

            // 4. Устанавливаем первый контракт, если он есть (чтобы уже при открытии что-то показывалось)
            if (cbContractSelectForSchedule.Items.Count > 0)
                cbContractSelectForSchedule.SelectedIndex = 0;
        }

        private void cbClientSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboItem = cbClientSelect.SelectedItem as ComboItem<Client>;
            if (comboItem == null)
            {
                dgvContracts.DataSource = null;
                return;
            }

            var client = comboItem.Value;
            var contracts = client.Contracts;

            // Привязка списка контрактов к гриду
            dgvContracts.DataSource = new BindingList<Contract>(contracts);
        }





        private void UpdateAssignEmployeeCombo()
        {
            var allGuards = _employeeService.GetGuards();
            UIHelpers.FillCombo(cbAssignEmployeeToContract, allGuards, emp => emp.FullName);
        }

        // Обработчик события для cbAssignEmployeeToContract
        private void cbAssignEmployeeToContract_DropDown(object sender, EventArgs e)
        {
            // Сохраняем текущего выбранного сотрудника (если был выбран)
            var selectedItem = cbAssignEmployeeToContract.SelectedItem as ComboItem<Employee>;
            var selectedId = selectedItem?.Value?.Id;

            // Загружаем список охранников
            var allGuards = _employeeService.GetGuards();
            Debug.WriteLine($"Guards count: {allGuards.Count}");

            // Обновляем список
            UIHelpers.FillCombo(cbAssignEmployeeToContract, allGuards, emp => emp.FullName);

            // Восстанавливаем выделение, если удаётся найти прежнего
            if (!string.IsNullOrEmpty(selectedId))
            {
                foreach (var item in cbAssignEmployeeToContract.Items)
                {
                    if (item is ComboItem<Employee> combo && combo.Value.Id == selectedId)
                    {
                        cbAssignEmployeeToContract.SelectedItem = combo;
                        break;
                    }
                }
            }
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            // Проверка: выбрана ли строка
            if (dgvContracts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите контракт для удаления.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранный контракт
            var selectedRow = dgvContracts.SelectedRows[0];
            var contract = selectedRow.DataBoundItem as Contract;
            if (contract == null)
            {
                MessageBox.Show("Не удалось получить выбранный контракт.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подтверждение
            var confirm = MessageBox.Show(
                $"Удалить контракт от {contract.StartDate:dd.MM.yyyy} по клиенту?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            // Получаем клиента
            var clientItem = cbClientSelect.SelectedItem as ComboItem<Client>;
            if (clientItem == null)
            {
                MessageBox.Show("Не удалось определить клиента.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var client = clientItem.Value;

            // Удаляем контракт из списка клиента
            client.Contracts.Remove(contract);

            // Сохраняем изменения
            _clientService.SaveAll();

            // Обновляем грид
            RefreshContractsGrid();
            MessageBox.Show("Контракт успешно удалён.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnAddContract_Click(object sender, EventArgs e)
        {
            // 1) Получаем выбранного клиента
            var comboItem = cbClientSelect.SelectedItem as ComboItem<Client>;
            if (comboItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var client = comboItem.Value;

            // 2) Проверяем тип контракта
            var selected = cbContractType.SelectedItem;
            if (!(selected is ContractType))
            {
                MessageBox.Show("Пожалуйста, выберите тип контракта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var type = (ContractType)selected;

            // 3) Генерируем следующий 6-значный ID
            int maxId = 0;
            // Сканируем все контракты у физических лиц
            foreach (var ind in _clientService.Individuals)
                foreach (var c in ind.Contracts)
                    if (int.TryParse(c.Id, out var n)) maxId = Math.Max(maxId, n);
            // И у юридических лиц
            foreach (var le in _clientService.LegalEntities)
                foreach (var c in le.Contracts)
                    if (int.TryParse(c.Id, out var n)) maxId = Math.Max(maxId, n);

            var newNumericId = (maxId + 1).ToString("D6");  // формат "000001", "000002" и т.д.

            // 4) Создаём новый контракт с красивым ID
            var contract = new Contract
            {
                Id = newNumericId,
                ClientId = client.Id,
                Client = client,
                Type = type,
                StartDate = dtpStartDate.Value.Date,
                EndDate = dtpEndDate.Value.Date,
                Amount = numAmount.Value,
                ObjectAddress = txtObjectAddress.Text.Trim(),
                EventDate = (type == ContractType.Охрана_мероприятия)
                                ? (DateTime?)dtpEventDate.Value
                                : null,
                Hours = (int)numHours.Value,
                RequiredGuardCount = (int)nudGuardCount.Value,
                Description = txtContractDescription.Text.Trim()
            };

            // 5) Добавляем контракт клиенту
            client.Contracts.Add(contract);

            // 6) Сохраняем всех клиентов
            _clientService.SaveAll();

            // 7) Обновляем грид
            RefreshContractsGrid();

            MessageBox.Show($"Контракт {newNumericId} добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void btnAssignEmployeeToContract_Click(object sender, EventArgs e)
        {
            // 1) Проверяем, что выбран договор в гриде
            if (dgvContracts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите договор", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Считываем строковый ID договора
            var idString = dgvContracts.SelectedRows[0].Cells["colId"].Value?.ToString();
            if (string.IsNullOrEmpty(idString))
            {
                MessageBox.Show("Не удалось получить корректный ID договора", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3) Получаем выбранного клиента
            var clientItem = cbClientSelect.SelectedItem as ComboItem<Client>;
            if (clientItem == null)
            {
                MessageBox.Show("Не удалось получить клиента", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4) Ищем договор по строковому ID
            var contract = clientItem.Value.Contracts
                                .FirstOrDefault(c => c.Id == idString);
            if (contract == null)
            {
                MessageBox.Show("Договор с таким ID не найден у выбранного клиента", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5) Получаем выбранного охранника
            var guardItem = cbAssignEmployeeToContract.SelectedItem as ComboItem<Employee>;
            if (guardItem == null)
            {
                MessageBox.Show("Выберите охранника", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var guard = guardItem.Value;

            // 6) Назначаем и сообщаем об успехе/ошибке
            try
            {
                _contractService.AssignGuard(contract, guard);
                MessageBox.Show("Охранник успешно назначен", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при назначении",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 7) Обновляем грид договоров для текущего клиента
            cbClientSelect_SelectedIndexChanged(null, null);
        }







        private void cbEmployeeSelectForSchedule_DropDown(object sender, EventArgs e)
        {
            // Получаем текущий выбранный договор
            var contractItem = cbContractSelectForSchedule.SelectedItem as ComboItem<Contract>;
            if (contractItem == null)
            {
                cbEmployeeSelectForSchedule.DataSource = null;
                return;
            }
            var contract = contractItem.Value;

            // Получаем список охранников, закреплённых за этим договором
            var guards = _contractService.GetAssignedGuards(contract);

            // Перезаполняем ComboBox
            UIHelpers.FillCombo(cbEmployeeSelectForSchedule, guards, emp => emp.FullName);
        }


        private void btnAddShift_Click(object sender, EventArgs e)
        {
            var empItem = cbEmployeeSelectForSchedule.SelectedItem as ComboItem<Employee>;
            if (empItem == null)
            {
                MessageBox.Show("Выберите сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var employee = empItem.Value;

            var shiftDate = dtpShiftDate.Value.Date;
            var shiftType = cbShiftType.SelectedItem as string;
            if (string.IsNullOrEmpty(shiftType))
            {
                MessageBox.Show("Выберите тип смены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newShift = new Shift { Date = shiftDate, Type = shiftType };
            try
            {
                _scheduleService.AssignShift(employee, newShift);
                RefreshScheduleGridForGuard(employee);
                MessageBox.Show("Смена добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      

        private void btnAddReplacement_Click(object sender, EventArgs e)
        {
            var empItem = cbEmployeeSelectForSchedule.SelectedItem as ComboItem<Employee>;
            if (empItem == null)
            {
                MessageBox.Show("Выберите охранника для изменения расписания.");
                return;
            }

            var replItem = cbReplacementEmployee.SelectedItem as ComboItem<Employee>;
            if (replItem == null)
            {
                MessageBox.Show("Выберите сотрудника для замены.");
                return;
            }

            var reason = txtReplacementReason.Text != null
                ? txtReplacementReason.Text.Trim()
                : string.Empty;

            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Введите причину замены.");
                return;
            }

            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите смену в расписании.");
                return;
            }

            var selectedRow = dgvSchedule.SelectedRows[0];
            var shift = selectedRow.Tag as Shift;
            if (shift == null)
            {
                MessageBox.Show("Смена не найдена.");
                return;
            }

            // Назначаем замену
            shift.ReplacementEmployeeId = replItem.Value.Id;
            shift.ReasonForReplacement = reason;

            _employeeService.SaveAll();
            RefreshScheduleGridForGuard(empItem.Value);

            MessageBox.Show("Замена успешно добавлена.");
        }



        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового сотрудника
            var employee = new Employee

            {
                Id = Guid.NewGuid().ToString(),
                FullName = txtFullName.Text,
                Address = txtAddress.Text,
                Position = cbPosition.SelectedItem.ToString(),
                Salary = numSalary.Value,
                Bonus = numBonus.Value,
                HasWeapon = chkHasWeapon.Checked,
                Weapon = chkHasWeapon.Checked ? new Weapon(txtWeaponModel.Text, txtWeaponRegNumber.Text) : null,
                LicenseNumber = txtLicenseNumber.Text,
                INN = txtINN.Text,
                PFR = txtPFR.Text,
                SpecialEquipment = lbSpecialEquipment.SelectedItems.Cast<string>().ToList()
        };


            // Добавление сотрудника в сервис
            _employeeService.Employees.Add(employee);
            _employeeService.Update(employee); // Сохранение данных

            // Обновление грида сотрудников
            UIHelpers.BindGrid(dgvEmployees, _employeeService.GetGridViewData());
        }
        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранную должность
            string selectedPosition = cbPosition.SelectedItem.ToString();

            // Определяем оклад в зависимости от должности
            decimal salary = PositionSalaryMap.Salaries.ContainsKey(selectedPosition) ? PositionSalaryMap.Salaries[selectedPosition] : 0;

            // Устанавливаем оклад в NumericUpDown
            numSalary.Value = salary;

            // Управляем видимостью ListBox для спецсредств
            if (selectedPosition == "Охранник")
            {
                lbSpecialEquipment.Visible = true; // Показываем ListBox для охранников
            }
            else
            {
                lbSpecialEquipment.Visible = false; // Скрываем ListBox для других должностей
            }
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // 1) Убедимся, что выбрана ровно одна строка
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Пожалуйста, сначала выберите сотрудника для удаления.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Достаём из этой строки ФИО из столбца "ФИО"
            var row = dgvEmployees.SelectedRows[0];
            var fullNameObj = row.Cells["ФИО"].Value;
            var fullName = fullNameObj?.ToString();
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Не удалось прочитать имя сотрудника из выбранной строки.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3) Находим директора (Employee) по FullName
            var emp = _employeeService.Employees
                         .FirstOrDefault(x => x.FullName == fullName);
            if (emp == null)
            {
                MessageBox.Show(
                    $"Сотрудник с именем «{fullName}» не найден в памяти программы.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4) Спрашиваем подтверждение удаления
            var answer = MessageBox.Show(
                $"Вы действительно хотите удалить сотрудника «{fullName}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
                return;

            // 5) Удаляем и сохраняем
            _employeeService.Employees.Remove(emp);
            _employeeService.Update(emp);

            // 6) Перебинживаем грид заново
            UIHelpers.BindGrid(dgvEmployees, _employeeService.GetGridViewData());

            MessageBox.Show(
                $"Сотрудник «{fullName}» успешно удалён.",
                "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnAddIndividual_Click(object sender, EventArgs e)
        {
            // Валидация данных
            if (string.IsNullOrWhiteSpace(txtFullNameIndividual.Text) || string.IsNullOrWhiteSpace(txtAddresIndividual.Text) || string.IsNullOrWhiteSpace(txtPassportData.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового физического лица
            var individual = new Individual(
                Guid.NewGuid().ToString(), // id
                txtAddresIndividual.Text,           // address
                txtFullNameIndividual.Text,         // fullName
                txtPassportData.Text      // passportData
            );

            // Добавление физического лица в сервис
            _clientService.Individuals.Add(individual);
            _clientService.SaveAll(); // Сохраняем изменения в JSON-файл

            // Обновляем грид физических лиц
            // Отвязываем старый источник
            dgvIndividuals.DataSource = null;

            // Привязываем новый список — оборачиваем в BindingList, чтобы грид видел изменения
            dgvIndividuals.DataSource = new BindingList<Individual>(_clientService.Individuals);
        }

        private void btnAddLegalEntity_Click(object sender, EventArgs e)
        {
            // Валидация данных
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtAddressLegalEntity.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового юридического лица
            var legalEntity = new LegalEntity(
                Guid.NewGuid().ToString(), // id
                txtAddressLegalEntity.Text, // address
                txtCompanyName.Text        // companyName
            );

            // Добавление юридического лица в сервис
            _clientService.LegalEntities.Add(legalEntity);
            _clientService.SaveAll(); // Сохраняем изменения в JSON-файл

            // Обновляем грид юридических лиц
            dgvLegalEntities.DataSource = null;
            dgvLegalEntities.DataSource = new BindingList<LegalEntity>(_clientService.LegalEntities);
        }
        private void btnDeleteIndividual_Click(object sender, EventArgs e)
        {
            if (dgvIndividuals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите физическое лицо для удаления.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvIndividuals.SelectedRows[0];
            var individual = row.DataBoundItem as Individual;
            if (individual == null)
            {
                MessageBox.Show("Не удалось получить выбранного клиента.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Вы уверены, что хотите удалить физическое лицо «{individual.FullName}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            _clientService.Individuals.Remove(individual);
            _clientService.SaveAll();

            // Обновляем грид — сбрасываем DataSource, затем присваиваем заново
            dgvIndividuals.DataSource = null;
            dgvIndividuals.DataSource = _clientService.Individuals;

            MessageBox.Show("Физическое лицо удалено.",
                            "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Отвязываем старый источник
            dgvIndividuals.DataSource = null;

            // Привязываем новый список — оборачиваем в BindingList, чтобы грид видел изменения
            dgvIndividuals.DataSource = new BindingList<Individual>(_clientService.Individuals);
        }


        private void btnDeleteLegalEntity_Click(object sender, EventArgs e)
        {
            // Проверяем, что пользователь выбрал строку
            if (dgvLegalEntities.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите юридическое лицо для удаления.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvLegalEntities.SelectedRows[0];
            var legal = row.DataBoundItem as LegalEntity;
            if (legal == null)
            {
                MessageBox.Show("Не удалось получить выбранного клиента.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подтверждение
            var confirm = MessageBox.Show(
                $"Вы уверены, что хотите удалить юридическое лицо «{legal.CompanyName}»?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            // Удаляем из списка
            _clientService.LegalEntities.Remove(legal);

            // Сохраняем изменения
            _clientService.SaveAll();

            dgvLegalEntities.DataSource = null;
            dgvLegalEntities.DataSource = new BindingList<LegalEntity>(_clientService.LegalEntities);
            MessageBox.Show("Юридическое лицо удалено.",
                            "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Обновляем
            dgvLegalEntities.DataSource = null;
            dgvLegalEntities.DataSource = new BindingList<LegalEntity>(_clientService.LegalEntities);
        }

        private void cbContractSelectForSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1) Получаем выбранный контракт
            var contractItem = cbContractSelectForSchedule.SelectedItem as ComboItem<Contract>;
            if (contractItem == null)
            {
                cbEmployeeSelectForSchedule.DataSource = null;
                dgvSchedule.DataSource = null;
                return;
            }
            var contract = contractItem.Value;

            // 2) Получаем список охранников по договору
            var guards = _contractService.GetAssignedGuards(contract);

            // 3) Заполняем ComboBox сотрудников
            UIHelpers.FillCombo(cbEmployeeSelectForSchedule, guards, emp => emp.FullName);

            // 4) Очищаем грид смен
            dgvSchedule.DataSource = null;

            // 5) Если есть охранники — выбираем первого, чтобы сразу показать его график
            if (cbEmployeeSelectForSchedule.Items.Count > 0)
                cbEmployeeSelectForSchedule.SelectedIndex = 0;
        }
        private void cbContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если ничего не выбрано — ничего не делаем
            if (cbContractType.SelectedItem == null)
                return;

            // Приводим выбранный элемент к вашему enum
            var selectedType = (ContractType)cbContractType.SelectedItem;

            if (selectedType == ContractType.Охрана_мероприятия)
            {
                // Для разового мероприятия показываем:
                //   - dtpEventDate (дата/время мероприятия)
                //   - numHours (количество часов)
                //   - nudGuardCount (количество охранников)
                // Скрываем:
                //   - txtObjectAddress (адрес объекта)
                //   - поля, отвечающие за помесячную оплату (если есть)

                // Убедитесь, что эти контролы существуют на вашей форме под такими именами.
                dtpEventDate.Visible = true;
                numHours.Visible = true;
                nudGuardCount.Visible = true;

                txtObjectAddress.Visible = false;
                // Если у вас есть отдельное поле для помесячной суммы, тоже скрываем его, например:
                // numAmount.Visible = false;
            }
            else if (selectedType == ContractType.Охрана_объекта)
            {
                // Для охраны объекта показываем:
                //   - txtObjectAddress (адрес объекта)
                //   - numAmount (сумма контракта)
                // Скрываем:
                //   - dtpEventDate, numHours, nudGuardCount

                dtpEventDate.Visible = false;
                numHours.Visible = false;
                nudGuardCount.Visible = false;

                txtObjectAddress.Visible = true;
                // numAmount.Visible = true;
            }
        }
        private void cbEmployeeSelectForSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            var empItem = cbEmployeeSelectForSchedule.SelectedItem as ComboItem<Employee>;
            if (empItem == null)
            {
                cbReplacementEmployee.Items.Clear();
                return;
            }

            var currentGuard = empItem.Value;

            // Получаем всех охранников
            var allGuards = _employeeService.GetGuards();

            // Убираем самого выбранного
            var possibleReplacements = allGuards
                .Where(g => g.Id != currentGuard.Id)
                .ToList();

            cbReplacementEmployee.Items.Clear();
            foreach (var repl in possibleReplacements)
            {
                cbReplacementEmployee.Items.Add(new ComboItem<Employee>
                {
                    Value = repl,
                    Text = repl.FullName
                });
            }

            if (cbReplacementEmployee.Items.Count > 0)
                cbReplacementEmployee.SelectedIndex = 0;

            // Обновляем таблицу смен
            RefreshScheduleGridForGuard(currentGuard);
        }

        private void RefreshScheduleGridForGuard(Employee guard)
        {
            dgvSchedule.Rows.Clear();
            dgvSchedule.Columns.Clear();

            // 1) Настройка колонок
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Дата", ReadOnly = true });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { Name = "colType", HeaderText = "Тип смены", ReadOnly = true });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { Name = "colReplacement", HeaderText = "Замена (ФИО)", ReadOnly = true });
            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn { Name = "colReason", HeaderText = "Причина замены", ReadOnly = true });

            // 2) Заполнение строк
            if (guard?.DutySchedule?.Shifts != null)
            {
                foreach (var shift in guard.DutySchedule.Shifts.OrderBy(s => s.Date))
                {
                    // Находим ФИО заменяющего, если задано
                    string replacementName = "";
                    if (!string.IsNullOrEmpty(shift.ReplacementEmployeeId))
                    {
                        var repl = _employeeService.Employees
                                     .FirstOrDefault(e => e.Id == shift.ReplacementEmployeeId);
                        if (repl != null)
                            replacementName = repl.FullName;
                    }

                    int idx = dgvSchedule.Rows.Add(
                        shift.Date.ToString("dd.MM.yyyy"),
                        shift.Type,
                        replacementName,
                        shift.ReasonForReplacement ?? ""
                    );
                    dgvSchedule.Rows[idx].Tag = shift;  // сохраняем Shift в Tag
                }
            }

            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.MultiSelect = false;
        }


        private void RefreshContractsGrid()
        {
            // 1) Определяем выбранного клиента
            var comboItem = cbClientSelect.SelectedItem as ComboItem<Client>;
            if (comboItem == null)
            {
                dgvContracts.DataSource = null;
                return;
            }
            var client = comboItem.Value;

            // 2) Берём список контрактов самого клиента
            var contracts = client.Contracts;

            // 3) Сброс и повторная привязка
            dgvContracts.DataSource = null;
            dgvContracts.DataSource = new BindingList<Contract>(contracts);
        }


        private void btnExportReport_Click(object sender, EventArgs e)
        {
            // 1) Проверяем, что в dgvReport есть привязанный DataTable с данными
            if (dgvReport.DataSource is DataTable table && table.Rows.Count > 0)
            {
                // 2) Открываем стандартное окно «Сохранить как»
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV-файл|*.csv";
                    sfd.Title = "Сохранить отчёт";

                    // Если пользователь нажал «Сохранить»:
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // sfd.FileName — полный путь, куда он захотел сохранить, например:
                        // "C:\Users\Богдан\Documents\отчёт.csv"

                        // 3) Вызываем ReportService, чтобы превратить DataTable в CSV и записать его по указанному пути
                        _reportService.ExportToCsv(table, sfd.FileName);

                        MessageBox.Show("Отчёт сохранён.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет данных для экспорта.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // 1) Берём даты
            var start = dtpReportStart.Value.Date;
            var end = dtpReportEnd.Value.Date;
            if (start > end)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания.");
                return;
            }

            // 2) Сбрасываем привязку DataSource перед очисткой
            dgvReport.DataSource = null;
            dgvReport.Columns.Clear(); // теперь можно очищать колонки
            dgvReport.Rows.Clear();    // и строки, хотя достаточно сбросить только DataSource

            // 3) Выбираем нужный тип отчёта
            var reportName = cbReportType.SelectedItem.ToString();
            DataTable table = null;

            if (reportName == "Финансовый отчёт")
            {
                table = _reportService.GetFinancialReport(start, end);
            }
            else if (reportName == "График дежурств")
            {
                table = _reportService.GetDutyScheduleReport(start, end);
            }
            else if (reportName == "Счёт клиенту")
            {
                table = _reportService.GetClientInvoiceReport(start, end);
            }

            // 4) Подвязываем новый DataTable
            if (table != null)
            {
                dgvReport.DataSource = table;
            }
        }



    }
}
