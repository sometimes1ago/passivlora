namespace Passiflora
{
    partial class Cabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cabinet));
            this.SectionHeader = new System.Windows.Forms.Label();
            this.BackLink = new System.Windows.Forms.LinkLabel();
            this.BackArrowImage = new System.Windows.Forms.PictureBox();
            this.SectionDesc = new System.Windows.Forms.Label();
            this.OrderData = new System.Windows.Forms.DataGridView();
            this.UserOrdersAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackArrowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionHeader
            // 
            this.SectionHeader.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SectionHeader.Location = new System.Drawing.Point(99, 16);
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.Size = new System.Drawing.Size(329, 52);
            this.SectionHeader.TabIndex = 38;
            this.SectionHeader.Text = "Личный кабинет";
            // 
            // BackLink
            // 
            this.BackLink.AutoSize = true;
            this.BackLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BackLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackLink.Location = new System.Drawing.Point(50, 29);
            this.BackLink.Name = "BackLink";
            this.BackLink.Size = new System.Drawing.Size(46, 17);
            this.BackLink.TabIndex = 40;
            this.BackLink.TabStop = true;
            this.BackLink.Text = "Назад";
            this.BackLink.UseMnemonic = false;
            this.BackLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink_LinkClicked);
            // 
            // BackArrowImage
            // 
            this.BackArrowImage.Image = global::Passiflora.Properties.Resources.BackArrow;
            this.BackArrowImage.Location = new System.Drawing.Point(15, 34);
            this.BackArrowImage.Name = "BackArrowImage";
            this.BackArrowImage.Size = new System.Drawing.Size(34, 10);
            this.BackArrowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackArrowImage.TabIndex = 41;
            this.BackArrowImage.TabStop = false;
            // 
            // SectionDesc
            // 
            this.SectionDesc.AutoSize = true;
            this.SectionDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SectionDesc.Location = new System.Drawing.Point(105, 68);
            this.SectionDesc.Name = "SectionDesc";
            this.SectionDesc.Size = new System.Drawing.Size(208, 13);
            this.SectionDesc.TabIndex = 42;
            this.SectionDesc.Text = "Здесь отображаются все ваши заказы";
            // 
            // OrderData
            // 
            this.OrderData.AllowUserToAddRows = false;
            this.OrderData.AllowUserToDeleteRows = false;
            this.OrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderData.Location = new System.Drawing.Point(15, 106);
            this.OrderData.Name = "OrderData";
            this.OrderData.ReadOnly = true;
            this.OrderData.Size = new System.Drawing.Size(657, 240);
            this.OrderData.TabIndex = 43;
            // 
            // UserOrdersAmount
            // 
            this.UserOrdersAmount.AutoSize = true;
            this.UserOrdersAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserOrdersAmount.Location = new System.Drawing.Point(11, 364);
            this.UserOrdersAmount.Name = "UserOrdersAmount";
            this.UserOrdersAmount.Size = new System.Drawing.Size(226, 21);
            this.UserOrdersAmount.TabIndex = 44;
            this.UserOrdersAmount.Text = "Сумма всех ваших заказов:";
            // 
            // Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 408);
            this.Controls.Add(this.UserOrdersAmount);
            this.Controls.Add(this.OrderData);
            this.Controls.Add(this.SectionDesc);
            this.Controls.Add(this.BackArrowImage);
            this.Controls.Add(this.BackLink);
            this.Controls.Add(this.SectionHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассифлора - личный кабинет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cabinet_FormClosing);
            this.Load += new System.EventHandler(this.Cabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackArrowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SectionHeader;
        private System.Windows.Forms.PictureBox BackArrowImage;
        private System.Windows.Forms.LinkLabel BackLink;
        private System.Windows.Forms.Label SectionDesc;
        private System.Windows.Forms.DataGridView OrderData;
        private System.Windows.Forms.Label UserOrdersAmount;
    }
}