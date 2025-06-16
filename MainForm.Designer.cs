namespace Курсовая_работа_за_3_семестр
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.panelEmployeeControls = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbSpecialEquipment = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPFR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtINN = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.txtWeaponRegNumber = new System.Windows.Forms.TextBox();
            this.txtWeaponModel = new System.Windows.Forms.TextBox();
            this.chkHasWeapon = new System.Windows.Forms.CheckBox();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.splitContainerClients = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddresIndividual = new System.Windows.Forms.TextBox();
            this.txtFullNameIndividual = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtPassportData = new System.Windows.Forms.TextBox();
            this.btnDeleteIndividual = new System.Windows.Forms.Button();
            this.btnAddIndividual = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvIndividuals = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtAddressLegalEntity = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnDeleteLegalEntity = new System.Windows.Forms.Button();
            this.btnAddLegalEntity = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvLegalEntities = new System.Windows.Forms.DataGridView();
            this.tabPageContracts = new System.Windows.Forms.TabPage();
            this.panelContractControls = new System.Windows.Forms.Panel();
            this.buttonDeleteContract = new System.Windows.Forms.Button();
            this.cbAssignEmployeeToContract = new System.Windows.Forms.ComboBox();
            this.btnAssignEmployeeToContract = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.txtContractDescription = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.Часы = new System.Windows.Forms.Label();
            this.nudGuardCount = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtObjectAddress = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.lblContractType = new System.Windows.Forms.Label();
            this.labelClientSelect = new System.Windows.Forms.Label();
            this.cbClientSelect = new System.Windows.Forms.ComboBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.dtpScheduleStartDate = new System.Windows.Forms.DateTimePicker();
            this.label37 = new System.Windows.Forms.Label();
            this.cbContractSelectForSchedule = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReplacementReason = new System.Windows.Forms.TextBox();
            this.cbReplacementEmployee = new System.Windows.Forms.ComboBox();
            this.btnAddReplacement = new System.Windows.Forms.Button();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.cbEmployeeSelectForSchedule = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dtpReportEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpReportStart = new System.Windows.Forms.DateTimePicker();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.TabControlMain.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            this.panelEmployeeControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerClients)).BeginInit();
            this.splitContainerClients.Panel1.SuspendLayout();
            this.splitContainerClients.Panel2.SuspendLayout();
            this.splitContainerClients.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividuals)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLegalEntities)).BeginInit();
            this.tabPageContracts.SuspendLayout();
            this.panelContractControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuardCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.tabPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.tabPageEmployees);
            this.TabControlMain.Controls.Add(this.tabPageClients);
            this.TabControlMain.Controls.Add(this.tabPageContracts);
            this.TabControlMain.Controls.Add(this.tabPageSchedule);
            this.TabControlMain.Controls.Add(this.tabPageReports);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1232, 788);
            this.TabControlMain.TabIndex = 0;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.panelEmployeeControls);
            this.tabPageEmployees.Controls.Add(this.groupBox1);
            this.tabPageEmployees.Controls.Add(this.dgvEmployees);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEmployees.Size = new System.Drawing.Size(1224, 759);
            this.tabPageEmployees.TabIndex = 0;
            this.tabPageEmployees.Text = "Сотрудники";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // panelEmployeeControls
            // 
            this.panelEmployeeControls.Controls.Add(this.btnAddEmployee);
            this.panelEmployeeControls.Controls.Add(this.btnDeleteEmployee);
            this.panelEmployeeControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmployeeControls.Location = new System.Drawing.Point(3, 707);
            this.panelEmployeeControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEmployeeControls.Name = "panelEmployeeControls";
            this.panelEmployeeControls.Size = new System.Drawing.Size(1218, 50);
            this.panelEmployeeControls.TabIndex = 5;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(3, 12);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(117, 36);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(126, 14);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(101, 36);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lbSpecialEquipment);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPFR);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtINN);
            this.groupBox1.Controls.Add(this.txtLicenseNumber);
            this.groupBox1.Controls.Add(this.txtWeaponRegNumber);
            this.groupBox1.Controls.Add(this.txtWeaponModel);
            this.groupBox1.Controls.Add(this.chkHasWeapon);
            this.groupBox1.Controls.Add(this.numBonus);
            this.groupBox1.Controls.Add(this.numSalary);
            this.groupBox1.Controls.Add(this.cbPosition);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 487);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1216, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(7, 36);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(144, 34);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 22);
            this.txtAddress.TabIndex = 26;
            // 
            // lbSpecialEquipment
            // 
            this.lbSpecialEquipment.FormattingEnabled = true;
            this.lbSpecialEquipment.ItemHeight = 16;
            this.lbSpecialEquipment.Items.AddRange(new object[] {
            "Бронежилет",
            "Рация",
            "Резиновая дубинка",
            "Наручники",
            "Газовый баллончик"});
            this.lbSpecialEquipment.Location = new System.Drawing.Point(996, 18);
            this.lbSpecialEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSpecialEquipment.Name = "lbSpecialEquipment";
            this.lbSpecialEquipment.Size = new System.Drawing.Size(167, 132);
            this.lbSpecialEquipment.TabIndex = 24;
            this.lbSpecialEquipment.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(119, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "ПФР";
            // 
            // txtPFR
            // 
            this.txtPFR.Location = new System.Drawing.Point(119, 142);
            this.txtPFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPFR.Name = "txtPFR";
            this.txtPFR.Size = new System.Drawing.Size(100, 22);
            this.txtPFR.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(788, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Регистрационный номер";
            // 
            // txtINN
            // 
            this.txtINN.Location = new System.Drawing.Point(13, 142);
            this.txtINN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtINN.Name = "txtINN";
            this.txtINN.Size = new System.Drawing.Size(100, 22);
            this.txtINN.TabIndex = 20;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new System.Drawing.Point(5, 90);
            this.txtLicenseNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(100, 22);
            this.txtLicenseNumber.TabIndex = 19;
            // 
            // txtWeaponRegNumber
            // 
            this.txtWeaponRegNumber.Location = new System.Drawing.Point(791, 90);
            this.txtWeaponRegNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeaponRegNumber.Name = "txtWeaponRegNumber";
            this.txtWeaponRegNumber.Size = new System.Drawing.Size(100, 22);
            this.txtWeaponRegNumber.TabIndex = 17;
            // 
            // txtWeaponModel
            // 
            this.txtWeaponModel.Location = new System.Drawing.Point(791, 37);
            this.txtWeaponModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeaponModel.Name = "txtWeaponModel";
            this.txtWeaponModel.Size = new System.Drawing.Size(100, 22);
            this.txtWeaponModel.TabIndex = 16;
            // 
            // chkHasWeapon
            // 
            this.chkHasWeapon.AutoSize = true;
            this.chkHasWeapon.Location = new System.Drawing.Point(665, 41);
            this.chkHasWeapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHasWeapon.Name = "chkHasWeapon";
            this.chkHasWeapon.Size = new System.Drawing.Size(46, 20);
            this.chkHasWeapon.TabIndex = 15;
            this.chkHasWeapon.Text = "Да";
            this.chkHasWeapon.UseVisualStyleBackColor = true;
            // 
            // numBonus
            // 
            this.numBonus.Location = new System.Drawing.Point(536, 37);
            this.numBonus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBonus.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(120, 22);
            this.numBonus.TabIndex = 14;
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(405, 37);
            this.numSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(120, 22);
            this.numSalary.TabIndex = 13;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Охранник",
            "Начальник охраны",
            "Инспектор",
            "Оператор видеонаблюдения"});
            this.cbPosition.Location = new System.Drawing.Point(279, 34);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 24);
            this.cbPosition.TabIndex = 12;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "ИНН";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Номер удостоверения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(788, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Модель оружия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Имеет оружие";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Надбавка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Оклад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 2);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1218, 755);
            this.dgvEmployees.TabIndex = 0;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.splitContainerClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 25);
            this.tabPageClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageClients.Size = new System.Drawing.Size(1224, 759);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // splitContainerClients
            // 
            this.splitContainerClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerClients.Location = new System.Drawing.Point(3, 2);
            this.splitContainerClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerClients.Name = "splitContainerClients";
            this.splitContainerClients.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerClients.Panel1
            // 
            this.splitContainerClients.Panel1.Controls.Add(this.panel1);
            this.splitContainerClients.Panel1.Controls.Add(this.label13);
            this.splitContainerClients.Panel1.Controls.Add(this.dgvIndividuals);
            // 
            // splitContainerClients.Panel2
            // 
            this.splitContainerClients.Panel2.Controls.Add(this.panel2);
            this.splitContainerClients.Panel2.Controls.Add(this.label14);
            this.splitContainerClients.Panel2.Controls.Add(this.dgvLegalEntities);
            this.splitContainerClients.Size = new System.Drawing.Size(1218, 755);
            this.splitContainerClients.SplitterDistance = 420;
            this.splitContainerClients.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddresIndividual);
            this.panel1.Controls.Add(this.txtFullNameIndividual);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.txtPassportData);
            this.panel1.Controls.Add(this.btnDeleteIndividual);
            this.panel1.Controls.Add(this.btnAddIndividual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 42);
            this.panel1.TabIndex = 2;
            // 
            // txtAddresIndividual
            // 
            this.txtAddresIndividual.Location = new System.Drawing.Point(340, 14);
            this.txtAddresIndividual.Name = "txtAddresIndividual";
            this.txtAddresIndividual.Size = new System.Drawing.Size(100, 22);
            this.txtAddresIndividual.TabIndex = 9;
            // 
            // txtFullNameIndividual
            // 
            this.txtFullNameIndividual.Location = new System.Drawing.Point(233, 15);
            this.txtFullNameIndividual.Name = "txtFullNameIndividual";
            this.txtFullNameIndividual.Size = new System.Drawing.Size(100, 22);
            this.txtFullNameIndividual.TabIndex = 8;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(448, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 16);
            this.label31.TabIndex = 7;
            this.label31.Text = "Паспорт";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(341, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 16);
            this.label30.TabIndex = 6;
            this.label30.Text = "Адрес";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(235, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 16);
            this.label29.TabIndex = 5;
            this.label29.Text = "ФИО";
            // 
            // txtPassportData
            // 
            this.txtPassportData.Location = new System.Drawing.Point(448, 15);
            this.txtPassportData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassportData.Name = "txtPassportData";
            this.txtPassportData.Size = new System.Drawing.Size(100, 22);
            this.txtPassportData.TabIndex = 4;
            // 
            // btnDeleteIndividual
            // 
            this.btnDeleteIndividual.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteIndividual.Location = new System.Drawing.Point(125, 0);
            this.btnDeleteIndividual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteIndividual.Name = "btnDeleteIndividual";
            this.btnDeleteIndividual.Size = new System.Drawing.Size(101, 42);
            this.btnDeleteIndividual.TabIndex = 1;
            this.btnDeleteIndividual.Text = "Удалить ФЛ";
            this.btnDeleteIndividual.UseVisualStyleBackColor = true;
            this.btnDeleteIndividual.Click += new System.EventHandler(this.btnDeleteIndividual_Click);
            // 
            // btnAddIndividual
            // 
            this.btnAddIndividual.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddIndividual.Location = new System.Drawing.Point(0, 0);
            this.btnAddIndividual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddIndividual.Name = "btnAddIndividual";
            this.btnAddIndividual.Size = new System.Drawing.Size(125, 42);
            this.btnAddIndividual.TabIndex = 0;
            this.btnAddIndividual.Text = "Добавить ФЛ";
            this.btnAddIndividual.UseVisualStyleBackColor = true;
            this.btnAddIndividual.Click += new System.EventHandler(this.btnAddIndividual_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1091, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Физические лица";
            // 
            // dgvIndividuals
            // 
            this.dgvIndividuals.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvIndividuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividuals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIndividuals.Location = new System.Drawing.Point(0, 0);
            this.dgvIndividuals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIndividuals.Name = "dgvIndividuals";
            this.dgvIndividuals.ReadOnly = true;
            this.dgvIndividuals.RowHeadersWidth = 51;
            this.dgvIndividuals.RowTemplate.Height = 24;
            this.dgvIndividuals.Size = new System.Drawing.Size(1218, 420);
            this.dgvIndividuals.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.txtAddressLegalEntity);
            this.panel2.Controls.Add(this.txtCompanyName);
            this.panel2.Controls.Add(this.btnDeleteLegalEntity);
            this.panel2.Controls.Add(this.btnAddLegalEntity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 285);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 46);
            this.panel2.TabIndex = 2;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(341, 2);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 16);
            this.label33.TabIndex = 5;
            this.label33.Text = "Адрес";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(235, 4);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 16);
            this.label32.TabIndex = 4;
            this.label32.Text = "Компания";
            // 
            // txtAddressLegalEntity
            // 
            this.txtAddressLegalEntity.Location = new System.Drawing.Point(341, 18);
            this.txtAddressLegalEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressLegalEntity.Name = "txtAddressLegalEntity";
            this.txtAddressLegalEntity.Size = new System.Drawing.Size(100, 22);
            this.txtAddressLegalEntity.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(235, 18);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 22);
            this.txtCompanyName.TabIndex = 2;
            // 
            // btnDeleteLegalEntity
            // 
            this.btnDeleteLegalEntity.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteLegalEntity.Location = new System.Drawing.Point(123, 0);
            this.btnDeleteLegalEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteLegalEntity.Name = "btnDeleteLegalEntity";
            this.btnDeleteLegalEntity.Size = new System.Drawing.Size(104, 46);
            this.btnDeleteLegalEntity.TabIndex = 1;
            this.btnDeleteLegalEntity.Text = "Удалить ЮЛ";
            this.btnDeleteLegalEntity.UseVisualStyleBackColor = true;
            this.btnDeleteLegalEntity.Click += new System.EventHandler(this.btnDeleteLegalEntity_Click);
            // 
            // btnAddLegalEntity
            // 
            this.btnAddLegalEntity.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddLegalEntity.Location = new System.Drawing.Point(0, 0);
            this.btnAddLegalEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddLegalEntity.Name = "btnAddLegalEntity";
            this.btnAddLegalEntity.Size = new System.Drawing.Size(123, 46);
            this.btnAddLegalEntity.TabIndex = 0;
            this.btnAddLegalEntity.Text = "Добавить ЮЛ";
            this.btnAddLegalEntity.UseVisualStyleBackColor = true;
            this.btnAddLegalEntity.Click += new System.EventHandler(this.btnAddLegalEntity_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1083, -2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Юридические лица";
            // 
            // dgvLegalEntities
            // 
            this.dgvLegalEntities.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLegalEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLegalEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLegalEntities.Location = new System.Drawing.Point(0, 0);
            this.dgvLegalEntities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLegalEntities.Name = "dgvLegalEntities";
            this.dgvLegalEntities.ReadOnly = true;
            this.dgvLegalEntities.RowHeadersWidth = 51;
            this.dgvLegalEntities.RowTemplate.Height = 24;
            this.dgvLegalEntities.Size = new System.Drawing.Size(1218, 331);
            this.dgvLegalEntities.TabIndex = 0;
            // 
            // tabPageContracts
            // 
            this.tabPageContracts.Controls.Add(this.panelContractControls);
            this.tabPageContracts.Controls.Add(this.dgvContracts);
            this.tabPageContracts.Location = new System.Drawing.Point(4, 25);
            this.tabPageContracts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageContracts.Name = "tabPageContracts";
            this.tabPageContracts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageContracts.Size = new System.Drawing.Size(1224, 759);
            this.tabPageContracts.TabIndex = 2;
            this.tabPageContracts.Text = "Договоры";
            this.tabPageContracts.UseVisualStyleBackColor = true;
            // 
            // panelContractControls
            // 
            this.panelContractControls.Controls.Add(this.buttonDeleteContract);
            this.panelContractControls.Controls.Add(this.cbAssignEmployeeToContract);
            this.panelContractControls.Controls.Add(this.btnAssignEmployeeToContract);
            this.panelContractControls.Controls.Add(this.btnAddContract);
            this.panelContractControls.Controls.Add(this.txtContractDescription);
            this.panelContractControls.Controls.Add(this.label22);
            this.panelContractControls.Controls.Add(this.numAmount);
            this.panelContractControls.Controls.Add(this.label21);
            this.panelContractControls.Controls.Add(this.numHours);
            this.panelContractControls.Controls.Add(this.Часы);
            this.panelContractControls.Controls.Add(this.nudGuardCount);
            this.panelContractControls.Controls.Add(this.label19);
            this.panelContractControls.Controls.Add(this.dtpEventDate);
            this.panelContractControls.Controls.Add(this.label18);
            this.panelContractControls.Controls.Add(this.txtObjectAddress);
            this.panelContractControls.Controls.Add(this.label17);
            this.panelContractControls.Controls.Add(this.dtpEndDate);
            this.panelContractControls.Controls.Add(this.dtpStartDate);
            this.panelContractControls.Controls.Add(this.label16);
            this.panelContractControls.Controls.Add(this.label15);
            this.panelContractControls.Controls.Add(this.cbContractType);
            this.panelContractControls.Controls.Add(this.lblContractType);
            this.panelContractControls.Controls.Add(this.labelClientSelect);
            this.panelContractControls.Controls.Add(this.cbClientSelect);
            this.panelContractControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContractControls.Location = new System.Drawing.Point(3, 597);
            this.panelContractControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContractControls.Name = "panelContractControls";
            this.panelContractControls.Size = new System.Drawing.Size(1218, 160);
            this.panelContractControls.TabIndex = 1;
            // 
            // buttonDeleteContract
            // 
            this.buttonDeleteContract.Location = new System.Drawing.Point(770, 78);
            this.buttonDeleteContract.Name = "buttonDeleteContract";
            this.buttonDeleteContract.Size = new System.Drawing.Size(131, 23);
            this.buttonDeleteContract.TabIndex = 25;
            this.buttonDeleteContract.Text = "Удалить договор";
            this.buttonDeleteContract.UseVisualStyleBackColor = true;
            this.buttonDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click);
            // 
            // cbAssignEmployeeToContract
            // 
            this.cbAssignEmployeeToContract.FormattingEnabled = true;
            this.cbAssignEmployeeToContract.Location = new System.Drawing.Point(913, 134);
            this.cbAssignEmployeeToContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAssignEmployeeToContract.Name = "cbAssignEmployeeToContract";
            this.cbAssignEmployeeToContract.Size = new System.Drawing.Size(121, 24);
            this.cbAssignEmployeeToContract.TabIndex = 24;
            // 
            // btnAssignEmployeeToContract
            // 
            this.btnAssignEmployeeToContract.Location = new System.Drawing.Point(1040, 132);
            this.btnAssignEmployeeToContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignEmployeeToContract.Name = "btnAssignEmployeeToContract";
            this.btnAssignEmployeeToContract.Size = new System.Drawing.Size(173, 23);
            this.btnAssignEmployeeToContract.TabIndex = 23;
            this.btnAssignEmployeeToContract.Text = "Назначить охранника";
            this.btnAssignEmployeeToContract.UseVisualStyleBackColor = true;
            this.btnAssignEmployeeToContract.Click += new System.EventHandler(this.btnAssignEmployeeToContract_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(608, 78);
            this.btnAddContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(143, 23);
            this.btnAddContract.TabIndex = 22;
            this.btnAddContract.Text = "Добавить договор";
            this.btnAddContract.UseVisualStyleBackColor = true;
            // 
            // txtContractDescription
            // 
            this.txtContractDescription.Location = new System.Drawing.Point(908, 28);
            this.txtContractDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContractDescription.Name = "txtContractDescription";
            this.txtContractDescription.Size = new System.Drawing.Size(100, 22);
            this.txtContractDescription.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(905, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 16);
            this.label22.TabIndex = 20;
            this.label22.Text = "Комментарий";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(451, 80);
            this.numAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(120, 22);
            this.numAmount.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(451, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "Сумма";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(781, 26);
            this.numHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(120, 22);
            this.numHours.TabIndex = 15;
            // 
            // Часы
            // 
            this.Часы.AutoSize = true;
            this.Часы.Location = new System.Drawing.Point(779, 6);
            this.Часы.Name = "Часы";
            this.Часы.Size = new System.Drawing.Size(40, 16);
            this.Часы.TabIndex = 14;
            this.Часы.Text = "Часы";
            // 
            // nudGuardCount
            // 
            this.nudGuardCount.Location = new System.Drawing.Point(619, 30);
            this.nudGuardCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGuardCount.Name = "nudGuardCount";
            this.nudGuardCount.Size = new System.Drawing.Size(155, 22);
            this.nudGuardCount.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(616, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Требуется охранников";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(409, 30);
            this.dtpEventDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEventDate.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(405, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Дата мероприятия";
            // 
            // txtObjectAddress
            // 
            this.txtObjectAddress.Location = new System.Drawing.Point(299, 30);
            this.txtObjectAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObjectAddress.Name = "txtObjectAddress";
            this.txtObjectAddress.Size = new System.Drawing.Size(100, 22);
            this.txtObjectAddress.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(296, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Адрес";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(217, 79);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(11, 79);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(213, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "По";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "С";
            // 
            // cbContractType
            // 
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Location = new System.Drawing.Point(153, 27);
            this.cbContractType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(121, 24);
            this.cbContractType.TabIndex = 3;
            this.cbContractType.SelectedIndexChanged += new System.EventHandler(this.cbContractType_SelectedIndexChanged);
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Location = new System.Drawing.Point(149, 5);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(97, 16);
            this.lblContractType.TabIndex = 2;
            this.lblContractType.Text = "Тип договора";
            // 
            // labelClientSelect
            // 
            this.labelClientSelect.AutoSize = true;
            this.labelClientSelect.Location = new System.Drawing.Point(5, 6);
            this.labelClientSelect.Name = "labelClientSelect";
            this.labelClientSelect.Size = new System.Drawing.Size(54, 16);
            this.labelClientSelect.TabIndex = 1;
            this.labelClientSelect.Text = "Клиент";
            // 
            // cbClientSelect
            // 
            this.cbClientSelect.FormattingEnabled = true;
            this.cbClientSelect.Location = new System.Drawing.Point(5, 28);
            this.cbClientSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClientSelect.Name = "cbClientSelect";
            this.cbClientSelect.Size = new System.Drawing.Size(121, 24);
            this.cbClientSelect.TabIndex = 0;
            this.cbClientSelect.SelectedIndexChanged += new System.EventHandler(this.cbClientSelect_SelectedIndexChanged);
            // 
            // dgvContracts
            // 
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.GridColor = System.Drawing.SystemColors.Window;
            this.dgvContracts.Location = new System.Drawing.Point(3, 2);
            this.dgvContracts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.RowHeadersWidth = 51;
            this.dgvContracts.RowTemplate.Height = 24;
            this.dgvContracts.Size = new System.Drawing.Size(1218, 755);
            this.dgvContracts.TabIndex = 0;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.label38);
            this.tabPageSchedule.Controls.Add(this.dtpScheduleStartDate);
            this.tabPageSchedule.Controls.Add(this.label37);
            this.tabPageSchedule.Controls.Add(this.cbContractSelectForSchedule);
            this.tabPageSchedule.Controls.Add(this.label25);
            this.tabPageSchedule.Controls.Add(this.label8);
            this.tabPageSchedule.Controls.Add(this.txtReplacementReason);
            this.tabPageSchedule.Controls.Add(this.cbReplacementEmployee);
            this.tabPageSchedule.Controls.Add(this.btnAddReplacement);
            this.tabPageSchedule.Controls.Add(this.btnGenerateSchedule);
            this.tabPageSchedule.Controls.Add(this.label24);
            this.tabPageSchedule.Controls.Add(this.cbShiftType);
            this.tabPageSchedule.Controls.Add(this.label35);
            this.tabPageSchedule.Controls.Add(this.dtpShiftDate);
            this.tabPageSchedule.Controls.Add(this.btnAddShift);
            this.tabPageSchedule.Controls.Add(this.cbEmployeeSelectForSchedule);
            this.tabPageSchedule.Controls.Add(this.label23);
            this.tabPageSchedule.Controls.Add(this.dgvSchedule);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabPageSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Size = new System.Drawing.Size(1224, 759);
            this.tabPageSchedule.TabIndex = 3;
            this.tabPageSchedule.Text = "График дежурств";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(611, 18);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(209, 16);
            this.label38.TabIndex = 24;
            this.label38.Text = "Начало времени в расписании";
            // 
            // dtpScheduleStartDate
            // 
            this.dtpScheduleStartDate.Location = new System.Drawing.Point(613, 38);
            this.dtpScheduleStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpScheduleStartDate.Name = "dtpScheduleStartDate";
            this.dtpScheduleStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpScheduleStartDate.TabIndex = 23;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(24, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 16);
            this.label37.TabIndex = 22;
            this.label37.Text = "Выбор контракта";
            // 
            // cbContractSelectForSchedule
            // 
            this.cbContractSelectForSchedule.FormattingEnabled = true;
            this.cbContractSelectForSchedule.Location = new System.Drawing.Point(185, 18);
            this.cbContractSelectForSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbContractSelectForSchedule.Name = "cbContractSelectForSchedule";
            this.cbContractSelectForSchedule.Size = new System.Drawing.Size(317, 24);
            this.cbContractSelectForSchedule.TabIndex = 21;
            this.cbContractSelectForSchedule.SelectedIndexChanged += new System.EventHandler(this.cbContractSelectForSchedule_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(781, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 16);
            this.label25.TabIndex = 20;
            this.label25.Text = "Комментарий";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Сотрудник под замену";
            // 
            // txtReplacementReason
            // 
            this.txtReplacementReason.Location = new System.Drawing.Point(784, 112);
            this.txtReplacementReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReplacementReason.Name = "txtReplacementReason";
            this.txtReplacementReason.Size = new System.Drawing.Size(100, 22);
            this.txtReplacementReason.TabIndex = 18;
            // 
            // cbReplacementEmployee
            // 
            this.cbReplacementEmployee.FormattingEnabled = true;
            this.cbReplacementEmployee.Location = new System.Drawing.Point(613, 110);
            this.cbReplacementEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReplacementEmployee.Name = "cbReplacementEmployee";
            this.cbReplacementEmployee.Size = new System.Drawing.Size(121, 24);
            this.cbReplacementEmployee.TabIndex = 17;
            // 
            // btnAddReplacement
            // 
            this.btnAddReplacement.Location = new System.Drawing.Point(889, 615);
            this.btnAddReplacement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddReplacement.Name = "btnAddReplacement";
            this.btnAddReplacement.Size = new System.Drawing.Size(173, 32);
            this.btnAddReplacement.TabIndex = 16;
            this.btnAddReplacement.Text = "Добавить замену";
            this.btnAddReplacement.UseVisualStyleBackColor = true;
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.Location = new System.Drawing.Point(703, 615);
            this.btnGenerateSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(195, 32);
            this.btnGenerateSchedule.TabIndex = 15;
            this.btnGenerateSchedule.Text = "Составить расписание";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 160);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(157, 16);
            this.label24.TabIndex = 14;
            this.label24.Text = "Дневная/ночная смена";
            // 
            // cbShiftType
            // 
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Items.AddRange(new object[] {
            "Дневная",
            "Ночная"});
            this.cbShiftType.Location = new System.Drawing.Point(185, 158);
            this.cbShiftType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(121, 24);
            this.cbShiftType.TabIndex = 13;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(24, 112);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(84, 16);
            this.label35.TabIndex = 12;
            this.label35.Text = "Выбор даты";
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(185, 112);
            this.dtpShiftDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(200, 22);
            this.dtpShiftDate.TabIndex = 11;
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(403, 103);
            this.btnAddShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(139, 32);
            this.btnAddShift.TabIndex = 8;
            this.btnAddShift.Text = "Добавить смену";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // cbEmployeeSelectForSchedule
            // 
            this.cbEmployeeSelectForSchedule.FormattingEnabled = true;
            this.cbEmployeeSelectForSchedule.Location = new System.Drawing.Point(185, 65);
            this.cbEmployeeSelectForSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployeeSelectForSchedule.Name = "cbEmployeeSelectForSchedule";
            this.cbEmployeeSelectForSchedule.Size = new System.Drawing.Size(317, 24);
            this.cbEmployeeSelectForSchedule.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(129, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "Выбор сотрудника";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.GridColor = System.Drawing.SystemColors.Window;
            this.dgvSchedule.Location = new System.Drawing.Point(8, 187);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(677, 320);
            this.dgvSchedule.TabIndex = 1;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.dgvReport);
            this.tabPageReports.Controls.Add(this.dtpReportEnd);
            this.tabPageReports.Controls.Add(this.dtpReportStart);
            this.tabPageReports.Controls.Add(this.cbReportType);
            this.tabPageReports.Controls.Add(this.label28);
            this.tabPageReports.Controls.Add(this.label27);
            this.tabPageReports.Controls.Add(this.btnExportReport);
            this.tabPageReports.Controls.Add(this.btnGenerateReport);
            this.tabPageReports.Controls.Add(this.label26);
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageReports.Size = new System.Drawing.Size(1224, 759);
            this.tabPageReports.TabIndex = 4;
            this.tabPageReports.Text = "Отчёты";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.GridColor = System.Drawing.SystemColors.Window;
            this.dgvReport.Location = new System.Drawing.Point(9, 103);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1085, 455);
            this.dgvReport.TabIndex = 11;
            // 
            // dtpReportEnd
            // 
            this.dtpReportEnd.Location = new System.Drawing.Point(281, 34);
            this.dtpReportEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReportEnd.Name = "dtpReportEnd";
            this.dtpReportEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpReportEnd.TabIndex = 10;
            // 
            // dtpReportStart
            // 
            this.dtpReportStart.Location = new System.Drawing.Point(39, 34);
            this.dtpReportStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReportStart.Name = "dtpReportStart";
            this.dtpReportStart.Size = new System.Drawing.Size(200, 22);
            this.dtpReportStart.TabIndex = 9;
            // 
            // cbReportType
            // 
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "Финансовый отчёт",
            "График дежурств",
            "Счёт клиенту"});
            this.cbReportType.Location = new System.Drawing.Point(95, 5);
            this.cbReportType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(121, 24);
            this.cbReportType.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(248, 41);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 16);
            this.label28.TabIndex = 7;
            this.label28.Text = "До:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 16);
            this.label27.TabIndex = 6;
            this.label27.Text = "От:";
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(939, 615);
            this.btnExportReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(155, 33);
            this.btnExportReport.TabIndex = 5;
            this.btnExportReport.Text = "Экспорт в файл";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(11, 64);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(200, 34);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Сформировать отчёт";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 16);
            this.label26.TabIndex = 0;
            this.label26.Text = "Тип отчёта";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 788);
            this.Controls.Add(this.TabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Охранное агентство";
            this.TabControlMain.ResumeLayout(false);
            this.tabPageEmployees.ResumeLayout(false);
            this.panelEmployeeControls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            this.splitContainerClients.Panel1.ResumeLayout(false);
            this.splitContainerClients.Panel1.PerformLayout();
            this.splitContainerClients.Panel2.ResumeLayout(false);
            this.splitContainerClients.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerClients)).EndInit();
            this.splitContainerClients.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividuals)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLegalEntities)).EndInit();
            this.tabPageContracts.ResumeLayout(false);
            this.panelContractControls.ResumeLayout(false);
            this.panelContractControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuardCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.tabPageSchedule.ResumeLayout(false);
            this.tabPageSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.tabPageReports.ResumeLayout(false);
            this.tabPageReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageContracts;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWeaponModel;
        private System.Windows.Forms.CheckBox chkHasWeapon;
        private System.Windows.Forms.NumericUpDown numBonus;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPFR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtINN;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.TextBox txtWeaponRegNumber;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.ComboBox cbEmployeeSelectForSchedule;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbShiftType;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.DateTimePicker dtpReportEnd;
        private System.Windows.Forms.DateTimePicker dtpReportStart;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.ListBox lbSpecialEquipment;
        private System.Windows.Forms.TextBox txtReplacementReason;
        private System.Windows.Forms.ComboBox cbReplacementEmployee;
        private System.Windows.Forms.Button btnAddReplacement;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cbContractSelectForSchedule;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DateTimePicker dtpScheduleStartDate;
        private System.Windows.Forms.Panel panelEmployeeControls;
        private System.Windows.Forms.SplitContainer splitContainerClients;
        private System.Windows.Forms.DataGridView dgvIndividuals;
        private System.Windows.Forms.DataGridView dgvLegalEntities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteIndividual;
        private System.Windows.Forms.Button btnAddIndividual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteLegalEntity;
        private System.Windows.Forms.Button btnAddLegalEntity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelContractControls;
        private System.Windows.Forms.Label labelClientSelect;
        private System.Windows.Forms.ComboBox cbClientSelect;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label Часы;
        private System.Windows.Forms.NumericUpDown nudGuardCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtObjectAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbAssignEmployeeToContract;
        private System.Windows.Forms.Button btnAssignEmployeeToContract;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.TextBox txtContractDescription;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPassportData;
        private System.Windows.Forms.TextBox txtAddressLegalEntity;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddresIndividual;
        private System.Windows.Forms.TextBox txtFullNameIndividual;
        private System.Windows.Forms.Button buttonDeleteContract;
    }
}

