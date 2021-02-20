namespace Passiflora
{
    partial class DataRecover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataRecover));
            this.SectionHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SecretKeyInput = new System.Windows.Forms.TextBox();
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.TipLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SectionHeader
            // 
            this.SectionHeader.Font = new System.Drawing.Font("Times New Roman", 32F);
            this.SectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SectionHeader.Location = new System.Drawing.Point(26, 9);
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.Size = new System.Drawing.Size(463, 98);
            this.SectionHeader.TabIndex = 3;
            this.SectionHeader.Text = "Восстановление данных";
            this.SectionHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ваш секретный ключ для показа данных";
            // 
            // SecretKeyInput
            // 
            this.SecretKeyInput.Location = new System.Drawing.Point(167, 125);
            this.SecretKeyInput.Name = "SecretKeyInput";
            this.SecretKeyInput.Size = new System.Drawing.Size(180, 22);
            this.SecretKeyInput.TabIndex = 5;
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.ShowDataButton.FlatAppearance.BorderSize = 0;
            this.ShowDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDataButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowDataButton.ForeColor = System.Drawing.Color.White;
            this.ShowDataButton.Location = new System.Drawing.Point(170, 163);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(174, 37);
            this.ShowDataButton.TabIndex = 9;
            this.ShowDataButton.Text = "Показать";
            this.ShowDataButton.UseVisualStyleBackColor = false;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // TipLink
            // 
            this.TipLink.AutoSize = true;
            this.TipLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.TipLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TipLink.Location = new System.Drawing.Point(164, 217);
            this.TipLink.Name = "TipLink";
            this.TipLink.Size = new System.Drawing.Size(186, 17);
            this.TipLink.TabIndex = 12;
            this.TipLink.TabStop = true;
            this.TipLink.Text = "Что такое секретный ключ?";
            this.TipLink.UseMnemonic = false;
            this.TipLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TipLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TipLink_LinkClicked);
            // 
            // DataRecover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(520, 266);
            this.Controls.Add(this.TipLink);
            this.Controls.Add(this.ShowDataButton);
            this.Controls.Add(this.SecretKeyInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SectionHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataRecover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассифлора - восстановление данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SectionHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecretKeyInput;
        private System.Windows.Forms.Button ShowDataButton;
        private System.Windows.Forms.LinkLabel TipLink;
    }
}