namespace Passiflora
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.ScreenHeader = new System.Windows.Forms.Label();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersData = new System.Windows.Forms.DataGridView();
            this.SortButton = new System.Windows.Forms.Button();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderOptions = new System.Windows.Forms.ComboBox();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.SortOptions = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.DirectSearch = new System.Windows.Forms.GroupBox();
            this.SearchValueInput = new System.Windows.Forms.TextBox();
            this.EnterValueLabel = new System.Windows.Forms.Label();
            this.SearchOpt = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderNumberInput = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderStatusOptions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeStatusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersData)).BeginInit();
            this.SortGroupBox.SuspendLayout();
            this.DirectSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenHeader
            // 
            this.ScreenHeader.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScreenHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.ScreenHeader.Location = new System.Drawing.Point(13, 25);
            this.ScreenHeader.Name = "ScreenHeader";
            this.ScreenHeader.Size = new System.Drawing.Size(541, 50);
            this.ScreenHeader.TabIndex = 1;
            this.ScreenHeader.Text = "Панель управления - Кассир";
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.GreetingLabel.Location = new System.Drawing.Point(18, 89);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(140, 20);
            this.GreetingLabel.TabIndex = 14;
            this.GreetingLabel.Text = "Здравствуйте, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Список всех заказов";
            // 
            // OrdersData
            // 
            this.OrdersData.AllowUserToAddRows = false;
            this.OrdersData.AllowUserToDeleteRows = false;
            this.OrdersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersData.Location = new System.Drawing.Point(21, 189);
            this.OrdersData.Name = "OrdersData";
            this.OrdersData.ReadOnly = true;
            this.OrdersData.Size = new System.Drawing.Size(821, 274);
            this.OrdersData.TabIndex = 16;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SortButton.FlatAppearance.BorderSize = 0;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.ForeColor = System.Drawing.Color.White;
            this.SortButton.Location = new System.Drawing.Point(21, 583);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(176, 33);
            this.SortButton.TabIndex = 20;
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
            this.SortGroupBox.Location = new System.Drawing.Point(21, 481);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Size = new System.Drawing.Size(268, 96);
            this.SortGroupBox.TabIndex = 19;
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
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogoutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogoutLink.Location = new System.Drawing.Point(806, 58);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(49, 17);
            this.LogoutLink.TabIndex = 21;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.UseMnemonic = false;
            this.LogoutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // DirectSearch
            // 
            this.DirectSearch.Controls.Add(this.SearchValueInput);
            this.DirectSearch.Controls.Add(this.EnterValueLabel);
            this.DirectSearch.Controls.Add(this.SearchOpt);
            this.DirectSearch.Controls.Add(this.SearchByLabel);
            this.DirectSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectSearch.Location = new System.Drawing.Point(305, 481);
            this.DirectSearch.Name = "DirectSearch";
            this.DirectSearch.Size = new System.Drawing.Size(276, 96);
            this.DirectSearch.TabIndex = 20;
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
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(305, 583);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(176, 33);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderNumberInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OrderStatusOptions);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(596, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 96);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить статус заказа";
            // 
            // OrderNumberInput
            // 
            this.OrderNumberInput.Location = new System.Drawing.Point(112, 25);
            this.OrderNumberInput.Mask = "00000";
            this.OrderNumberInput.Name = "OrderNumberInput";
            this.OrderNumberInput.PromptChar = ' ';
            this.OrderNumberInput.Size = new System.Drawing.Size(121, 22);
            this.OrderNumberInput.TabIndex = 3;
            this.OrderNumberInput.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер заказа";
            // 
            // OrderStatusOptions
            // 
            this.OrderStatusOptions.FormattingEnabled = true;
            this.OrderStatusOptions.Items.AddRange(new object[] {
            "В обработке",
            "Выдан"});
            this.OrderStatusOptions.Location = new System.Drawing.Point(112, 59);
            this.OrderStatusOptions.Name = "OrderStatusOptions";
            this.OrderStatusOptions.Size = new System.Drawing.Size(121, 21);
            this.OrderStatusOptions.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберите статус";
            // 
            // ChangeStatusButton
            // 
            this.ChangeStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.ChangeStatusButton.FlatAppearance.BorderSize = 0;
            this.ChangeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeStatusButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStatusButton.ForeColor = System.Drawing.Color.White;
            this.ChangeStatusButton.Location = new System.Drawing.Point(596, 583);
            this.ChangeStatusButton.Name = "ChangeStatusButton";
            this.ChangeStatusButton.Size = new System.Drawing.Size(176, 33);
            this.ChangeStatusButton.TabIndex = 23;
            this.ChangeStatusButton.Text = "Изменить";
            this.ChangeStatusButton.UseVisualStyleBackColor = false;
            this.ChangeStatusButton.Click += new System.EventHandler(this.ChangeStatusButton_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.ChangeStatusButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DirectSearch);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortGroupBox);
            this.Controls.Add(this.OrdersData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.ScreenHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассифлора - кассир";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cashier_FormClosing);
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersData)).EndInit();
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            this.DirectSearch.ResumeLayout(false);
            this.DirectSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScreenHeader;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrdersData;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.ComboBox OrderOptions;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.ComboBox SortOptions;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.GroupBox DirectSearch;
        private System.Windows.Forms.TextBox SearchValueInput;
        private System.Windows.Forms.Label EnterValueLabel;
        private System.Windows.Forms.ComboBox SearchOpt;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox OrderNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OrderStatusOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeStatusButton;
    }
}