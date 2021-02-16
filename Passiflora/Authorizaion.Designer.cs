namespace Passiflora
{
    partial class Authorizaion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorizaion));
            this.SectionHeader = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.StartAuth = new System.Windows.Forms.Button();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.BackLink = new System.Windows.Forms.LinkLabel();
            this.BackArrowImage = new System.Windows.Forms.PictureBox();
            this.RightSideImage = new System.Windows.Forms.PictureBox();
            this.LeftSideImage = new System.Windows.Forms.PictureBox();
            this.DataRecoverLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BackArrowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSideImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSideImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionHeader
            // 
            this.SectionHeader.Font = new System.Drawing.Font("Times New Roman", 42F);
            this.SectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SectionHeader.Location = new System.Drawing.Point(296, 26);
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.Size = new System.Drawing.Size(375, 160);
            this.SectionHeader.TabIndex = 2;
            this.SectionHeader.Text = "Авторизация пользователей";
            this.SectionHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.Login.Location = new System.Drawing.Point(446, 199);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(74, 25);
            this.Login.TabIndex = 3;
            this.Login.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.Password.Location = new System.Drawing.Point(440, 298);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 25);
            this.Password.TabIndex = 4;
            this.Password.Text = "Пароль";
            // 
            // LoginInput
            // 
            this.LoginInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.LoginInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInput.Location = new System.Drawing.Point(396, 236);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(174, 23);
            this.LoginInput.TabIndex = 5;
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput.Location = new System.Drawing.Point(396, 335);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(174, 23);
            this.PasswordInput.TabIndex = 6;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.ShowPassword.Location = new System.Drawing.Point(409, 373);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(149, 23);
            this.ShowPassword.TabIndex = 7;
            this.ShowPassword.Text = "Показать пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // StartAuth
            // 
            this.StartAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.StartAuth.FlatAppearance.BorderSize = 0;
            this.StartAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartAuth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartAuth.ForeColor = System.Drawing.Color.White;
            this.StartAuth.Location = new System.Drawing.Point(396, 415);
            this.StartAuth.Name = "StartAuth";
            this.StartAuth.Size = new System.Drawing.Size(174, 37);
            this.StartAuth.TabIndex = 8;
            this.StartAuth.Text = "Войти";
            this.StartAuth.UseVisualStyleBackColor = false;
            this.StartAuth.Click += new System.EventHandler(this.ShowPots_Click);
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RegisterLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegisterLink.Location = new System.Drawing.Point(425, 484);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(117, 17);
            this.RegisterLink.TabIndex = 11;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Еще нет аккаута?";
            this.RegisterLink.UseMnemonic = false;
            this.RegisterLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // BackLink
            // 
            this.BackLink.AutoSize = true;
            this.BackLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BackLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackLink.Location = new System.Drawing.Point(474, 507);
            this.BackLink.Name = "BackLink";
            this.BackLink.Size = new System.Drawing.Size(46, 17);
            this.BackLink.TabIndex = 12;
            this.BackLink.TabStop = true;
            this.BackLink.Text = "Назад";
            this.BackLink.UseMnemonic = false;
            this.BackLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink_LinkClicked);
            // 
            // BackArrowImage
            // 
            this.BackArrowImage.Image = global::Passiflora.Properties.Resources.BackArrow;
            this.BackArrowImage.Location = new System.Drawing.Point(439, 512);
            this.BackArrowImage.Name = "BackArrowImage";
            this.BackArrowImage.Size = new System.Drawing.Size(34, 10);
            this.BackArrowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackArrowImage.TabIndex = 13;
            this.BackArrowImage.TabStop = false;
            // 
            // RightSideImage
            // 
            this.RightSideImage.Image = global::Passiflora.Properties.Resources.AuthRightSide;
            this.RightSideImage.Location = new System.Drawing.Point(646, -2);
            this.RightSideImage.Name = "RightSideImage";
            this.RightSideImage.Size = new System.Drawing.Size(338, 502);
            this.RightSideImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightSideImage.TabIndex = 1;
            this.RightSideImage.TabStop = false;
            // 
            // LeftSideImage
            // 
            this.LeftSideImage.Image = global::Passiflora.Properties.Resources.AuthLeftSide;
            this.LeftSideImage.Location = new System.Drawing.Point(-7, -2);
            this.LeftSideImage.Name = "LeftSideImage";
            this.LeftSideImage.Size = new System.Drawing.Size(332, 479);
            this.LeftSideImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftSideImage.TabIndex = 0;
            this.LeftSideImage.TabStop = false;
            // 
            // DataRecoverLink
            // 
            this.DataRecoverLink.AutoSize = true;
            this.DataRecoverLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataRecoverLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.DataRecoverLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataRecoverLink.Location = new System.Drawing.Point(425, 461);
            this.DataRecoverLink.Name = "DataRecoverLink";
            this.DataRecoverLink.Size = new System.Drawing.Size(116, 17);
            this.DataRecoverLink.TabIndex = 14;
            this.DataRecoverLink.TabStop = true;
            this.DataRecoverLink.Text = "Забыли данные?";
            this.DataRecoverLink.UseMnemonic = false;
            this.DataRecoverLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataRecoverLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DataRecoverLink_LinkClicked);
            // 
            // Authorizaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.DataRecoverLink);
            this.Controls.Add(this.BackArrowImage);
            this.Controls.Add(this.BackLink);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.StartAuth);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.SectionHeader);
            this.Controls.Add(this.RightSideImage);
            this.Controls.Add(this.LeftSideImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorizaion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассифлора - авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorizaion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.BackArrowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSideImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSideImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftSideImage;
        private System.Windows.Forms.PictureBox RightSideImage;
        private System.Windows.Forms.Label SectionHeader;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Button StartAuth;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.LinkLabel BackLink;
        private System.Windows.Forms.PictureBox BackArrowImage;
        private System.Windows.Forms.LinkLabel DataRecoverLink;
    }
}