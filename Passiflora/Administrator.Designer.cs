namespace Passiflora
{
    partial class Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.ScreenHeader = new System.Windows.Forms.Label();
            this.PagesCollection = new System.Windows.Forms.TabControl();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderDeletableInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TabPageDesc = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DirectSearch = new System.Windows.Forms.GroupBox();
            this.SearchValueInput = new System.Windows.Forms.TextBox();
            this.EnterValueLabel = new System.Windows.Forms.Label();
            this.SearchOpt = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderOptions = new System.Windows.Forms.ComboBox();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.SortOptions = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.OrdersData = new System.Windows.Forms.DataGridView();
            this.EditEmployeeData = new System.Windows.Forms.TabPage();
            this.UpdateEmpData = new System.Windows.Forms.Button();
            this.DeleteEmp = new System.Windows.Forms.GroupBox();
            this.DeleteEmpButton = new System.Windows.Forms.Button();
            this.DeletableNameInput = new System.Windows.Forms.TextBox();
            this.DeletableSurnameInput = new System.Windows.Forms.TextBox();
            this.DeletableName = new System.Windows.Forms.Label();
            this.DeletableSurname = new System.Windows.Forms.Label();
            this.AddingEmployee = new System.Windows.Forms.GroupBox();
            this.EmpRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEmpButton = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneInput = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SearchEmpButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchEmpValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchEmp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeesData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Shipments = new System.Windows.Forms.TabPage();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.Products = new System.Windows.Forms.TabPage();
            this.Clients = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.ShipmentData = new System.Windows.Forms.DataGridView();
            this.AddShipmentInfo = new System.Windows.Forms.GroupBox();
            this.SelectSupLabel = new System.Windows.Forms.Label();
            this.SuppliersOptions = new System.Windows.Forms.ComboBox();
            this.EnterDateLabel = new System.Windows.Forms.Label();
            this.DateFormatLabel = new System.Windows.Forms.Label();
            this.AddShipmentButton = new System.Windows.Forms.Button();
            this.SelectProduct = new System.Windows.Forms.ComboBox();
            this.SelectProdLabel = new System.Windows.Forms.Label();
            this.EnterCountLabel = new System.Windows.Forms.Label();
            this.CountInput = new System.Windows.Forms.TextBox();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DateInput = new System.Windows.Forms.TextBox();
            this.PagesCollection.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DirectSearch.SuspendLayout();
            this.SortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersData)).BeginInit();
            this.EditEmployeeData.SuspendLayout();
            this.DeleteEmp.SuspendLayout();
            this.AddingEmployee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesData)).BeginInit();
            this.Shipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentData)).BeginInit();
            this.AddShipmentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogoutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogoutLink.Location = new System.Drawing.Point(1118, 42);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(49, 17);
            this.LogoutLink.TabIndex = 24;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.UseMnemonic = false;
            this.LogoutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.GreetingLabel.Location = new System.Drawing.Point(17, 90);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(140, 20);
            this.GreetingLabel.TabIndex = 23;
            this.GreetingLabel.Text = "Здравствуйте, ";
            // 
            // ScreenHeader
            // 
            this.ScreenHeader.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScreenHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.ScreenHeader.Location = new System.Drawing.Point(12, 26);
            this.ScreenHeader.Name = "ScreenHeader";
            this.ScreenHeader.Size = new System.Drawing.Size(696, 50);
            this.ScreenHeader.TabIndex = 22;
            this.ScreenHeader.Text = "Панель управления - Администратор";
            // 
            // PagesCollection
            // 
            this.PagesCollection.Controls.Add(this.OrdersPage);
            this.PagesCollection.Controls.Add(this.EditEmployeeData);
            this.PagesCollection.Controls.Add(this.Shipments);
            this.PagesCollection.Controls.Add(this.Suppliers);
            this.PagesCollection.Controls.Add(this.Products);
            this.PagesCollection.Controls.Add(this.Clients);
            this.PagesCollection.Location = new System.Drawing.Point(21, 128);
            this.PagesCollection.Name = "PagesCollection";
            this.PagesCollection.SelectedIndex = 0;
            this.PagesCollection.Size = new System.Drawing.Size(1150, 521);
            this.PagesCollection.TabIndex = 25;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.DeleteButton);
            this.OrdersPage.Controls.Add(this.groupBox1);
            this.OrdersPage.Controls.Add(this.TabPageDesc);
            this.OrdersPage.Controls.Add(this.SearchButton);
            this.OrdersPage.Controls.Add(this.DirectSearch);
            this.OrdersPage.Controls.Add(this.SortButton);
            this.OrdersPage.Controls.Add(this.SortGroupBox);
            this.OrdersPage.Controls.Add(this.OrdersData);
            this.OrdersPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(1142, 495);
            this.OrdersPage.TabIndex = 0;
            this.OrdersPage.Text = "Заказы";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(593, 428);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(176, 33);
            this.DeleteButton.TabIndex = 31;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderDeletableInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(593, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 96);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление заказа";
            // 
            // OrderDeletableInput
            // 
            this.OrderDeletableInput.Location = new System.Drawing.Point(92, 27);
            this.OrderDeletableInput.Name = "OrderDeletableInput";
            this.OrderDeletableInput.Size = new System.Drawing.Size(100, 22);
            this.OrderDeletableInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер заказа";
            // 
            // TabPageDesc
            // 
            this.TabPageDesc.AutoSize = true;
            this.TabPageDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabPageDesc.Location = new System.Drawing.Point(8, 11);
            this.TabPageDesc.Name = "TabPageDesc";
            this.TabPageDesc.Size = new System.Drawing.Size(181, 19);
            this.TabPageDesc.TabIndex = 30;
            this.TabPageDesc.Text = "Заказы всех пользователей";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(300, 428);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(176, 33);
            this.SearchButton.TabIndex = 29;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DirectSearch
            // 
            this.DirectSearch.Controls.Add(this.SearchValueInput);
            this.DirectSearch.Controls.Add(this.EnterValueLabel);
            this.DirectSearch.Controls.Add(this.SearchOpt);
            this.DirectSearch.Controls.Add(this.SearchByLabel);
            this.DirectSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectSearch.Location = new System.Drawing.Point(300, 326);
            this.DirectSearch.Name = "DirectSearch";
            this.DirectSearch.Size = new System.Drawing.Size(276, 96);
            this.DirectSearch.TabIndex = 26;
            this.DirectSearch.TabStop = false;
            this.DirectSearch.Text = "Прямой поиск";
            // 
            // SearchValueInput
            // 
            this.SearchValueInput.Location = new System.Drawing.Point(141, 58);
            this.SearchValueInput.Name = "SearchValueInput";
            this.SearchValueInput.Size = new System.Drawing.Size(121, 22);
            this.SearchValueInput.TabIndex = 3;
            // 
            // EnterValueLabel
            // 
            this.EnterValueLabel.AutoSize = true;
            this.EnterValueLabel.Location = new System.Drawing.Point(6, 61);
            this.EnterValueLabel.Name = "EnterValueLabel";
            this.EnterValueLabel.Size = new System.Drawing.Size(104, 13);
            this.EnterValueLabel.TabIndex = 2;
            this.EnterValueLabel.Text = "Введите значение";
            // 
            // SearchOpt
            // 
            this.SearchOpt.FormattingEnabled = true;
            this.SearchOpt.Items.AddRange(new object[] {
            "Номеру",
            "Дате",
            "Статусу",
            "Фамилии_клиента",
            "Адресу_доставки",
            "Сумме_заказа",
            "Коду_выдачи",
            "Телефону"});
            this.SearchOpt.Location = new System.Drawing.Point(141, 25);
            this.SearchOpt.Name = "SearchOpt";
            this.SearchOpt.Size = new System.Drawing.Size(121, 21);
            this.SearchOpt.TabIndex = 1;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(6, 30);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(63, 13);
            this.SearchByLabel.TabIndex = 0;
            this.SearchByLabel.Text = "Искать по:";
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SortButton.FlatAppearance.BorderSize = 0;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.ForeColor = System.Drawing.Color.White;
            this.SortButton.Location = new System.Drawing.Point(12, 428);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(176, 33);
            this.SortButton.TabIndex = 27;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.OrderOptions);
            this.SortGroupBox.Controls.Add(this.OrderByLabel);
            this.SortGroupBox.Controls.Add(this.SortOptions);
            this.SortGroupBox.Controls.Add(this.SortByLabel);
            this.SortGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortGroupBox.Location = new System.Drawing.Point(12, 326);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Size = new System.Drawing.Size(268, 96);
            this.SortGroupBox.TabIndex = 25;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Сортировка";
            // 
            // OrderOptions
            // 
            this.OrderOptions.FormattingEnabled = true;
            this.OrderOptions.Items.AddRange(new object[] {
            "Возрастанию",
            "Убыванию"});
            this.OrderOptions.Location = new System.Drawing.Point(116, 55);
            this.OrderOptions.Name = "OrderOptions";
            this.OrderOptions.Size = new System.Drawing.Size(121, 21);
            this.OrderOptions.TabIndex = 3;
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Location = new System.Drawing.Point(6, 61);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(74, 13);
            this.OrderByLabel.TabIndex = 2;
            this.OrderByLabel.Text = "Порядок по:";
            // 
            // SortOptions
            // 
            this.SortOptions.FormattingEnabled = true;
            this.SortOptions.Items.AddRange(new object[] {
            "Номеру",
            "Дате",
            "Статусу"});
            this.SortOptions.Location = new System.Drawing.Point(116, 25);
            this.SortOptions.Name = "SortOptions";
            this.SortOptions.Size = new System.Drawing.Size(121, 21);
            this.SortOptions.TabIndex = 1;
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Location = new System.Drawing.Point(6, 30);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(97, 13);
            this.SortByLabel.TabIndex = 0;
            this.SortByLabel.Text = "Сортировать по:";
            // 
            // OrdersData
            // 
            this.OrdersData.AllowUserToAddRows = false;
            this.OrdersData.AllowUserToDeleteRows = false;
            this.OrdersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersData.Location = new System.Drawing.Point(6, 39);
            this.OrdersData.Name = "OrdersData";
            this.OrdersData.ReadOnly = true;
            this.OrdersData.Size = new System.Drawing.Size(1112, 274);
            this.OrdersData.TabIndex = 24;
            // 
            // EditEmployeeData
            // 
            this.EditEmployeeData.Controls.Add(this.UpdateEmpData);
            this.EditEmployeeData.Controls.Add(this.DeleteEmp);
            this.EditEmployeeData.Controls.Add(this.AddingEmployee);
            this.EditEmployeeData.Controls.Add(this.SearchEmpButton);
            this.EditEmployeeData.Controls.Add(this.groupBox2);
            this.EditEmployeeData.Controls.Add(this.EmployeesData);
            this.EditEmployeeData.Controls.Add(this.label1);
            this.EditEmployeeData.Location = new System.Drawing.Point(4, 22);
            this.EditEmployeeData.Name = "EditEmployeeData";
            this.EditEmployeeData.Padding = new System.Windows.Forms.Padding(3);
            this.EditEmployeeData.Size = new System.Drawing.Size(1142, 495);
            this.EditEmployeeData.TabIndex = 1;
            this.EditEmployeeData.Text = "Сотрудники";
            this.EditEmployeeData.UseVisualStyleBackColor = true;
            // 
            // UpdateEmpData
            // 
            this.UpdateEmpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.UpdateEmpData.FlatAppearance.BorderSize = 0;
            this.UpdateEmpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmpData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateEmpData.ForeColor = System.Drawing.Color.White;
            this.UpdateEmpData.Location = new System.Drawing.Point(818, 173);
            this.UpdateEmpData.Name = "UpdateEmpData";
            this.UpdateEmpData.Size = new System.Drawing.Size(157, 36);
            this.UpdateEmpData.TabIndex = 38;
            this.UpdateEmpData.Text = "Обновить данные";
            this.UpdateEmpData.UseVisualStyleBackColor = false;
            this.UpdateEmpData.Click += new System.EventHandler(this.UpdateEmpData_Click);
            // 
            // DeleteEmp
            // 
            this.DeleteEmp.Controls.Add(this.DeleteEmpButton);
            this.DeleteEmp.Controls.Add(this.DeletableNameInput);
            this.DeleteEmp.Controls.Add(this.DeletableSurnameInput);
            this.DeleteEmp.Controls.Add(this.DeletableName);
            this.DeleteEmp.Controls.Add(this.DeletableSurname);
            this.DeleteEmp.Location = new System.Drawing.Point(818, 64);
            this.DeleteEmp.Name = "DeleteEmp";
            this.DeleteEmp.Size = new System.Drawing.Size(304, 90);
            this.DeleteEmp.TabIndex = 36;
            this.DeleteEmp.TabStop = false;
            this.DeleteEmp.Text = "Удаление сотрудника";
            // 
            // DeleteEmpButton
            // 
            this.DeleteEmpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.DeleteEmpButton.FlatAppearance.BorderSize = 0;
            this.DeleteEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmpButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEmpButton.Location = new System.Drawing.Point(192, 23);
            this.DeleteEmpButton.Name = "DeleteEmpButton";
            this.DeleteEmpButton.Size = new System.Drawing.Size(104, 36);
            this.DeleteEmpButton.TabIndex = 37;
            this.DeleteEmpButton.Text = "Удалить";
            this.DeleteEmpButton.UseVisualStyleBackColor = false;
            this.DeleteEmpButton.Click += new System.EventHandler(this.DeleteEmpButton_Click);
            // 
            // DeletableNameInput
            // 
            this.DeletableNameInput.Location = new System.Drawing.Point(76, 53);
            this.DeletableNameInput.Name = "DeletableNameInput";
            this.DeletableNameInput.Size = new System.Drawing.Size(100, 22);
            this.DeletableNameInput.TabIndex = 3;
            // 
            // DeletableSurnameInput
            // 
            this.DeletableSurnameInput.Location = new System.Drawing.Point(76, 23);
            this.DeletableSurnameInput.Name = "DeletableSurnameInput";
            this.DeletableSurnameInput.Size = new System.Drawing.Size(100, 22);
            this.DeletableSurnameInput.TabIndex = 2;
            // 
            // DeletableName
            // 
            this.DeletableName.AutoSize = true;
            this.DeletableName.Location = new System.Drawing.Point(6, 56);
            this.DeletableName.Name = "DeletableName";
            this.DeletableName.Size = new System.Drawing.Size(29, 13);
            this.DeletableName.TabIndex = 1;
            this.DeletableName.Text = "Имя";
            // 
            // DeletableSurname
            // 
            this.DeletableSurname.AutoSize = true;
            this.DeletableSurname.Location = new System.Drawing.Point(6, 26);
            this.DeletableSurname.Name = "DeletableSurname";
            this.DeletableSurname.Size = new System.Drawing.Size(54, 13);
            this.DeletableSurname.TabIndex = 0;
            this.DeletableSurname.Text = "Фамилия";
            // 
            // AddingEmployee
            // 
            this.AddingEmployee.Controls.Add(this.EmpRole);
            this.AddingEmployee.Controls.Add(this.label5);
            this.AddingEmployee.Controls.Add(this.AddEmpButton);
            this.AddingEmployee.Controls.Add(this.PasswordInput);
            this.AddingEmployee.Controls.Add(this.label10);
            this.AddingEmployee.Controls.Add(this.LoginInput);
            this.AddingEmployee.Controls.Add(this.label9);
            this.AddingEmployee.Controls.Add(this.PhoneInput);
            this.AddingEmployee.Controls.Add(this.PhoneLabel);
            this.AddingEmployee.Controls.Add(this.LastNameInput);
            this.AddingEmployee.Controls.Add(this.LastnameLabel);
            this.AddingEmployee.Controls.Add(this.NameInput);
            this.AddingEmployee.Controls.Add(this.NameLabel);
            this.AddingEmployee.Controls.Add(this.SurnameInput);
            this.AddingEmployee.Controls.Add(this.SurnameLabel);
            this.AddingEmployee.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingEmployee.Location = new System.Drawing.Point(317, 340);
            this.AddingEmployee.Name = "AddingEmployee";
            this.AddingEmployee.Size = new System.Drawing.Size(486, 135);
            this.AddingEmployee.TabIndex = 35;
            this.AddingEmployee.TabStop = false;
            this.AddingEmployee.Text = "Добавление сотрудника";
            // 
            // EmpRole
            // 
            this.EmpRole.FormattingEnabled = true;
            this.EmpRole.Items.AddRange(new object[] {
            "Кассир",
            "Администратор"});
            this.EmpRole.Location = new System.Drawing.Point(365, 42);
            this.EmpRole.Name = "EmpRole";
            this.EmpRole.Size = new System.Drawing.Size(104, 21);
            this.EmpRole.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Роль";
            // 
            // AddEmpButton
            // 
            this.AddEmpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.AddEmpButton.FlatAppearance.BorderSize = 0;
            this.AddEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmpButton.ForeColor = System.Drawing.Color.White;
            this.AddEmpButton.Location = new System.Drawing.Point(365, 76);
            this.AddEmpButton.Name = "AddEmpButton";
            this.AddEmpButton.Size = new System.Drawing.Size(104, 36);
            this.AddEmpButton.TabIndex = 36;
            this.AddEmpButton.Text = "Добавить";
            this.AddEmpButton.UseVisualStyleBackColor = false;
            this.AddEmpButton.Click += new System.EventHandler(this.AddEmpButton_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(249, 85);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 22);
            this.PasswordInput.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Пароль";
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(248, 41);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(100, 22);
            this.LoginInput.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Логин";
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(129, 86);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(100, 22);
            this.PhoneInput.TabIndex = 11;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(126, 70);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 13);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "Телефон";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(129, 41);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(100, 22);
            this.LastNameInput.TabIndex = 9;
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Location = new System.Drawing.Point(126, 25);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(57, 13);
            this.LastnameLabel.TabIndex = 8;
            this.LastnameLabel.Text = "Отчество";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(9, 86);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 22);
            this.NameInput.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(9, 41);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(100, 22);
            this.SurnameInput.TabIndex = 5;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(6, 25);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(54, 13);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // SearchEmpButton
            // 
            this.SearchEmpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SearchEmpButton.FlatAppearance.BorderSize = 0;
            this.SearchEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEmpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchEmpButton.ForeColor = System.Drawing.Color.White;
            this.SearchEmpButton.Location = new System.Drawing.Point(26, 442);
            this.SearchEmpButton.Name = "SearchEmpButton";
            this.SearchEmpButton.Size = new System.Drawing.Size(176, 33);
            this.SearchEmpButton.TabIndex = 34;
            this.SearchEmpButton.Text = "Найти";
            this.SearchEmpButton.UseVisualStyleBackColor = false;
            this.SearchEmpButton.Click += new System.EventHandler(this.SearchEmpButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchEmpValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SearchEmp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(26, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 96);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прямой поиск";
            // 
            // SearchEmpValue
            // 
            this.SearchEmpValue.Location = new System.Drawing.Point(141, 58);
            this.SearchEmpValue.Name = "SearchEmpValue";
            this.SearchEmpValue.Size = new System.Drawing.Size(121, 22);
            this.SearchEmpValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите значение";
            // 
            // SearchEmp
            // 
            this.SearchEmp.FormattingEnabled = true;
            this.SearchEmp.Items.AddRange(new object[] {
            "Фамилии"});
            this.SearchEmp.Location = new System.Drawing.Point(141, 25);
            this.SearchEmp.Name = "SearchEmp";
            this.SearchEmp.Size = new System.Drawing.Size(121, 21);
            this.SearchEmp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Искать по:";
            // 
            // EmployeesData
            // 
            this.EmployeesData.AllowUserToAddRows = false;
            this.EmployeesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesData.Location = new System.Drawing.Point(26, 64);
            this.EmployeesData.Name = "EmployeesData";
            this.EmployeesData.Size = new System.Drawing.Size(777, 261);
            this.EmployeesData.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Данные всех сотрудников";
            // 
            // Shipments
            // 
            this.Shipments.Controls.Add(this.UpdateDataButton);
            this.Shipments.Controls.Add(this.AddShipmentButton);
            this.Shipments.Controls.Add(this.AddShipmentInfo);
            this.Shipments.Controls.Add(this.ShipmentData);
            this.Shipments.Controls.Add(this.label6);
            this.Shipments.Location = new System.Drawing.Point(4, 22);
            this.Shipments.Name = "Shipments";
            this.Shipments.Size = new System.Drawing.Size(1142, 495);
            this.Shipments.TabIndex = 2;
            this.Shipments.Text = "Поставки";
            this.Shipments.UseVisualStyleBackColor = true;
            // 
            // Suppliers
            // 
            this.Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(1142, 495);
            this.Suppliers.TabIndex = 3;
            this.Suppliers.Text = "Поставщики";
            this.Suppliers.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(4, 22);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(1142, 495);
            this.Products.TabIndex = 4;
            this.Products.Text = "Товары";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(1142, 495);
            this.Clients.TabIndex = 5;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Данные о поставках";
            // 
            // ShipmentData
            // 
            this.ShipmentData.AllowUserToAddRows = false;
            this.ShipmentData.AllowUserToDeleteRows = false;
            this.ShipmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentData.Location = new System.Drawing.Point(22, 58);
            this.ShipmentData.Name = "ShipmentData";
            this.ShipmentData.ReadOnly = true;
            this.ShipmentData.Size = new System.Drawing.Size(1090, 262);
            this.ShipmentData.TabIndex = 33;
            // 
            // AddShipmentInfo
            // 
            this.AddShipmentInfo.Controls.Add(this.DateInput);
            this.AddShipmentInfo.Controls.Add(this.CountInput);
            this.AddShipmentInfo.Controls.Add(this.EnterCountLabel);
            this.AddShipmentInfo.Controls.Add(this.SelectProduct);
            this.AddShipmentInfo.Controls.Add(this.SelectProdLabel);
            this.AddShipmentInfo.Controls.Add(this.DateFormatLabel);
            this.AddShipmentInfo.Controls.Add(this.EnterDateLabel);
            this.AddShipmentInfo.Controls.Add(this.SuppliersOptions);
            this.AddShipmentInfo.Controls.Add(this.SelectSupLabel);
            this.AddShipmentInfo.Location = new System.Drawing.Point(22, 340);
            this.AddShipmentInfo.Name = "AddShipmentInfo";
            this.AddShipmentInfo.Size = new System.Drawing.Size(567, 98);
            this.AddShipmentInfo.TabIndex = 34;
            this.AddShipmentInfo.TabStop = false;
            this.AddShipmentInfo.Text = "Добавить информацию о поставке";
            // 
            // SelectSupLabel
            // 
            this.SelectSupLabel.AutoSize = true;
            this.SelectSupLabel.Location = new System.Drawing.Point(6, 28);
            this.SelectSupLabel.Name = "SelectSupLabel";
            this.SelectSupLabel.Size = new System.Drawing.Size(127, 13);
            this.SelectSupLabel.TabIndex = 0;
            this.SelectSupLabel.Text = "Выберите поставщика";
            // 
            // SuppliersOptions
            // 
            this.SuppliersOptions.FormattingEnabled = true;
            this.SuppliersOptions.Location = new System.Drawing.Point(160, 28);
            this.SuppliersOptions.Name = "SuppliersOptions";
            this.SuppliersOptions.Size = new System.Drawing.Size(121, 21);
            this.SuppliersOptions.TabIndex = 1;
            // 
            // EnterDateLabel
            // 
            this.EnterDateLabel.AutoSize = true;
            this.EnterDateLabel.Location = new System.Drawing.Point(6, 52);
            this.EnterDateLabel.Name = "EnterDateLabel";
            this.EnterDateLabel.Size = new System.Drawing.Size(75, 13);
            this.EnterDateLabel.TabIndex = 2;
            this.EnterDateLabel.Text = "Введите дату";
            // 
            // DateFormatLabel
            // 
            this.DateFormatLabel.AutoSize = true;
            this.DateFormatLabel.Location = new System.Drawing.Point(6, 70);
            this.DateFormatLabel.Name = "DateFormatLabel";
            this.DateFormatLabel.Size = new System.Drawing.Size(140, 13);
            this.DateFormatLabel.TabIndex = 3;
            this.DateFormatLabel.Text = "Формат даты : 30-12-2020";
            // 
            // AddShipmentButton
            // 
            this.AddShipmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.AddShipmentButton.FlatAppearance.BorderSize = 0;
            this.AddShipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShipmentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddShipmentButton.ForeColor = System.Drawing.Color.White;
            this.AddShipmentButton.Location = new System.Drawing.Point(22, 444);
            this.AddShipmentButton.Name = "AddShipmentButton";
            this.AddShipmentButton.Size = new System.Drawing.Size(104, 36);
            this.AddShipmentButton.TabIndex = 37;
            this.AddShipmentButton.Text = "Добавить";
            this.AddShipmentButton.UseVisualStyleBackColor = false;
            this.AddShipmentButton.Click += new System.EventHandler(this.AddShipmentButton_Click);
            // 
            // SelectProduct
            // 
            this.SelectProduct.FormattingEnabled = true;
            this.SelectProduct.Location = new System.Drawing.Point(422, 28);
            this.SelectProduct.Name = "SelectProduct";
            this.SelectProduct.Size = new System.Drawing.Size(121, 21);
            this.SelectProduct.TabIndex = 6;
            // 
            // SelectProdLabel
            // 
            this.SelectProdLabel.AutoSize = true;
            this.SelectProdLabel.Location = new System.Drawing.Point(301, 28);
            this.SelectProdLabel.Name = "SelectProdLabel";
            this.SelectProdLabel.Size = new System.Drawing.Size(94, 13);
            this.SelectProdLabel.TabIndex = 5;
            this.SelectProdLabel.Text = "Выберите товар";
            // 
            // EnterCountLabel
            // 
            this.EnterCountLabel.AutoSize = true;
            this.EnterCountLabel.Location = new System.Drawing.Point(301, 61);
            this.EnterCountLabel.Name = "EnterCountLabel";
            this.EnterCountLabel.Size = new System.Drawing.Size(115, 13);
            this.EnterCountLabel.TabIndex = 7;
            this.EnterCountLabel.Text = "Введите количество";
            // 
            // CountInput
            // 
            this.CountInput.Location = new System.Drawing.Point(422, 58);
            this.CountInput.Name = "CountInput";
            this.CountInput.Size = new System.Drawing.Size(100, 22);
            this.CountInput.TabIndex = 8;
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.UpdateDataButton.FlatAppearance.BorderSize = 0;
            this.UpdateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDataButton.ForeColor = System.Drawing.Color.White;
            this.UpdateDataButton.Location = new System.Drawing.Point(607, 349);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(157, 36);
            this.UpdateDataButton.TabIndex = 39;
            this.UpdateDataButton.Text = "Обновить данные";
            this.UpdateDataButton.UseVisualStyleBackColor = false;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // DateInput
            // 
            this.DateInput.Location = new System.Drawing.Point(160, 61);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(100, 22);
            this.DateInput.TabIndex = 9;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.PagesCollection);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.ScreenHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrator";
            this.Text = "Пассифлора - Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.PagesCollection.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.OrdersPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DirectSearch.ResumeLayout(false);
            this.DirectSearch.PerformLayout();
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersData)).EndInit();
            this.EditEmployeeData.ResumeLayout(false);
            this.EditEmployeeData.PerformLayout();
            this.DeleteEmp.ResumeLayout(false);
            this.DeleteEmp.PerformLayout();
            this.AddingEmployee.ResumeLayout(false);
            this.AddingEmployee.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesData)).EndInit();
            this.Shipments.ResumeLayout(false);
            this.Shipments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentData)).EndInit();
            this.AddShipmentInfo.ResumeLayout(false);
            this.AddShipmentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Label ScreenHeader;
        private System.Windows.Forms.TabControl PagesCollection;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage EditEmployeeData;
        private System.Windows.Forms.TabPage Shipments;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox DirectSearch;
        private System.Windows.Forms.TextBox SearchValueInput;
        private System.Windows.Forms.Label EnterValueLabel;
        private System.Windows.Forms.ComboBox SearchOpt;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.ComboBox OrderOptions;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.ComboBox SortOptions;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.DataGridView OrdersData;
        private System.Windows.Forms.Label TabPageDesc;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderDeletableInput;
        private System.Windows.Forms.Button SearchEmpButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchEmpValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SearchEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView EmployeesData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.GroupBox AddingEmployee;
        private System.Windows.Forms.Button AddEmpButton;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneInput;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.GroupBox DeleteEmp;
        private System.Windows.Forms.TextBox DeletableNameInput;
        private System.Windows.Forms.TextBox DeletableSurnameInput;
        private System.Windows.Forms.Label DeletableName;
        private System.Windows.Forms.Label DeletableSurname;
        private System.Windows.Forms.Button DeleteEmpButton;
        private System.Windows.Forms.ComboBox EmpRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateEmpData;
        private System.Windows.Forms.Button AddShipmentButton;
        private System.Windows.Forms.GroupBox AddShipmentInfo;
        private System.Windows.Forms.TextBox CountInput;
        private System.Windows.Forms.Label EnterCountLabel;
        private System.Windows.Forms.ComboBox SelectProduct;
        private System.Windows.Forms.Label SelectProdLabel;
        private System.Windows.Forms.Label DateFormatLabel;
        private System.Windows.Forms.Label EnterDateLabel;
        private System.Windows.Forms.ComboBox SuppliersOptions;
        private System.Windows.Forms.Label SelectSupLabel;
        private System.Windows.Forms.DataGridView ShipmentData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.TextBox DateInput;
    }
}