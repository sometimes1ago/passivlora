namespace Passiflora
{
    partial class PlantCare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantCare));
            this.OrderButton = new System.Windows.Forms.Button();
            this.OrderGroup = new System.Windows.Forms.GroupBox();
            this.AuthRequiredLabel = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdNames = new System.Windows.Forms.ComboBox();
            this.SelectProdLabel = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.RangeTo = new System.Windows.Forms.MaskedTextBox();
            this.RangeFrom = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.OrderOptions = new System.Windows.Forms.ComboBox();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.SortOptions = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.BqData = new System.Windows.Forms.DataGridView();
            this.BackArrowImage = new System.Windows.Forms.PictureBox();
            this.BackLink = new System.Windows.Forms.LinkLabel();
            this.SectionHeader = new System.Windows.Forms.Label();
            this.OrderGroup.SuspendLayout();
            this.SortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BqData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackArrowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.ForeColor = System.Drawing.Color.White;
            this.OrderButton.Location = new System.Drawing.Point(314, 500);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(176, 33);
            this.OrderButton.TabIndex = 52;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = false;
            // 
            // OrderGroup
            // 
            this.OrderGroup.Controls.Add(this.AuthRequiredLabel);
            this.OrderGroup.Controls.Add(this.Count);
            this.OrderGroup.Controls.Add(this.label1);
            this.OrderGroup.Controls.Add(this.ProdNames);
            this.OrderGroup.Controls.Add(this.SelectProdLabel);
            this.OrderGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderGroup.Location = new System.Drawing.Point(313, 360);
            this.OrderGroup.Name = "OrderGroup";
            this.OrderGroup.Size = new System.Drawing.Size(261, 132);
            this.OrderGroup.TabIndex = 51;
            this.OrderGroup.TabStop = false;
            this.OrderGroup.Text = "Заказать";
            // 
            // AuthRequiredLabel
            // 
            this.AuthRequiredLabel.Location = new System.Drawing.Point(7, 88);
            this.AuthRequiredLabel.Name = "AuthRequiredLabel";
            this.AuthRequiredLabel.Size = new System.Drawing.Size(205, 28);
            this.AuthRequiredLabel.TabIndex = 21;
            this.AuthRequiredLabel.Text = "Для оформления заказа необходимо авторизоваться";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(134, 56);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(68, 22);
            this.Count.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество";
            // 
            // ProdNames
            // 
            this.ProdNames.FormattingEnabled = true;
            this.ProdNames.Location = new System.Drawing.Point(134, 23);
            this.ProdNames.Name = "ProdNames";
            this.ProdNames.Size = new System.Drawing.Size(121, 21);
            this.ProdNames.TabIndex = 1;
            // 
            // SelectProdLabel
            // 
            this.SelectProdLabel.AutoSize = true;
            this.SelectProdLabel.Location = new System.Drawing.Point(7, 27);
            this.SelectProdLabel.Name = "SelectProdLabel";
            this.SelectProdLabel.Size = new System.Drawing.Size(92, 13);
            this.SelectProdLabel.TabIndex = 0;
            this.SelectProdLabel.Text = "Выберите букет";
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SortButton.FlatAppearance.BorderSize = 0;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.ForeColor = System.Drawing.Color.White;
            this.SortButton.Location = new System.Drawing.Point(21, 500);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(176, 33);
            this.SortButton.TabIndex = 50;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.RangeTo);
            this.SortGroupBox.Controls.Add(this.RangeFrom);
            this.SortGroupBox.Controls.Add(this.label2);
            this.SortGroupBox.Controls.Add(this.RangeLabel);
            this.SortGroupBox.Controls.Add(this.OrderOptions);
            this.SortGroupBox.Controls.Add(this.OrderByLabel);
            this.SortGroupBox.Controls.Add(this.SortOptions);
            this.SortGroupBox.Controls.Add(this.SortByLabel);
            this.SortGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortGroupBox.Location = new System.Drawing.Point(21, 360);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Size = new System.Drawing.Size(268, 132);
            this.SortGroupBox.TabIndex = 49;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Сортировка";
            // 
            // RangeTo
            // 
            this.RangeTo.Location = new System.Drawing.Point(200, 85);
            this.RangeTo.Mask = "00000";
            this.RangeTo.Name = "RangeTo";
            this.RangeTo.PromptChar = ' ';
            this.RangeTo.Size = new System.Drawing.Size(37, 22);
            this.RangeTo.TabIndex = 9;
            this.RangeTo.ValidatingType = typeof(int);
            // 
            // RangeFrom
            // 
            this.RangeFrom.Location = new System.Drawing.Point(116, 85);
            this.RangeFrom.Mask = "00000";
            this.RangeFrom.Name = "RangeFrom";
            this.RangeFrom.PromptChar = ' ';
            this.RangeFrom.Size = new System.Drawing.Size(41, 22);
            this.RangeFrom.TabIndex = 8;
            this.RangeFrom.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "до";
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Location = new System.Drawing.Point(6, 90);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(101, 13);
            this.RangeLabel.TabIndex = 4;
            this.RangeLabel.Text = "Диапазон цен: от";
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
            "Имени",
            "Длине",
            "Ширине",
            "Высоте",
            "Стоимости"});
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
            // BqData
            // 
            this.BqData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BqData.Location = new System.Drawing.Point(21, 95);
            this.BqData.Name = "BqData";
            this.BqData.Size = new System.Drawing.Size(642, 246);
            this.BqData.TabIndex = 48;
            // 
            // BackArrowImage
            // 
            this.BackArrowImage.Image = global::Passiflora.Properties.Resources.BackArrow;
            this.BackArrowImage.Location = new System.Drawing.Point(21, 49);
            this.BackArrowImage.Name = "BackArrowImage";
            this.BackArrowImage.Size = new System.Drawing.Size(34, 10);
            this.BackArrowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackArrowImage.TabIndex = 47;
            this.BackArrowImage.TabStop = false;
            // 
            // BackLink
            // 
            this.BackLink.AutoSize = true;
            this.BackLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BackLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackLink.Location = new System.Drawing.Point(56, 44);
            this.BackLink.Name = "BackLink";
            this.BackLink.Size = new System.Drawing.Size(46, 17);
            this.BackLink.TabIndex = 46;
            this.BackLink.TabStop = true;
            this.BackLink.Text = "Назад";
            this.BackLink.UseMnemonic = false;
            this.BackLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink_LinkClicked);
            // 
            // SectionHeader
            // 
            this.SectionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.SectionHeader.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SectionHeader.Location = new System.Drawing.Point(109, 27);
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.Size = new System.Drawing.Size(465, 52);
            this.SectionHeader.TabIndex = 45;
            this.SectionHeader.Text = "Наши средства по уходу";
            // 
            // PlantCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.OrderGroup);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortGroupBox);
            this.Controls.Add(this.BqData);
            this.Controls.Add(this.BackArrowImage);
            this.Controls.Add(this.BackLink);
            this.Controls.Add(this.SectionHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlantCare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассифлора - Уход за растениями";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlantCare_FormClosing);
            this.Load += new System.EventHandler(this.PlantCare_Load);
            this.OrderGroup.ResumeLayout(false);
            this.OrderGroup.PerformLayout();
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BqData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackArrowImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.GroupBox OrderGroup;
        private System.Windows.Forms.Label AuthRequiredLabel;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProdNames;
        private System.Windows.Forms.Label SelectProdLabel;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.MaskedTextBox RangeTo;
        private System.Windows.Forms.MaskedTextBox RangeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.ComboBox OrderOptions;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.ComboBox SortOptions;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.DataGridView BqData;
        private System.Windows.Forms.PictureBox BackArrowImage;
        private System.Windows.Forms.LinkLabel BackLink;
        private System.Windows.Forms.Label SectionHeader;
    }
}