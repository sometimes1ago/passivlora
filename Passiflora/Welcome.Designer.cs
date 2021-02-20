namespace Passiflora
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainHeader = new System.Windows.Forms.Label();
            this.HeaderDesc = new System.Windows.Forms.Label();
            this.CheckProdsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Passiflora.Properties.Resources.StartWindowPlant;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 567);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Passiflora.Properties.Resources.SecondWindowPlant;
            this.pictureBox1.Location = new System.Drawing.Point(696, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainHeader
            // 
            this.MainHeader.BackColor = System.Drawing.Color.Transparent;
            this.MainHeader.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.MainHeader.Location = new System.Drawing.Point(282, 69);
            this.MainHeader.Name = "MainHeader";
            this.MainHeader.Size = new System.Drawing.Size(452, 225);
            this.MainHeader.TabIndex = 2;
            this.MainHeader.Text = "Добро пожаловать в цветочный салон Пассифлора";
            this.MainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderDesc
            // 
            this.HeaderDesc.BackColor = System.Drawing.Color.Transparent;
            this.HeaderDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HeaderDesc.Location = new System.Drawing.Point(310, 268);
            this.HeaderDesc.Name = "HeaderDesc";
            this.HeaderDesc.Size = new System.Drawing.Size(388, 131);
            this.HeaderDesc.TabIndex = 3;
            this.HeaderDesc.Text = "Один из самых лучших цветочных салонов города Омска. Только у нас вы найдете комн" +
    "атые растения и цветы самых разнообразных видов! От самых обычных до эксклюзивны" +
    "х и редко встречающихся.";
            this.HeaderDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckProdsButton
            // 
            this.CheckProdsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.CheckProdsButton.FlatAppearance.BorderSize = 0;
            this.CheckProdsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckProdsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckProdsButton.ForeColor = System.Drawing.Color.White;
            this.CheckProdsButton.Location = new System.Drawing.Point(401, 413);
            this.CheckProdsButton.Name = "CheckProdsButton";
            this.CheckProdsButton.Size = new System.Drawing.Size(200, 45);
            this.CheckProdsButton.TabIndex = 4;
            this.CheckProdsButton.Text = "Смотреть ассортимент";
            this.CheckProdsButton.UseVisualStyleBackColor = false;
            this.CheckProdsButton.Click += new System.EventHandler(this.CheckProdsButton_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainHeader);
            this.Controls.Add(this.CheckProdsButton);
            this.Controls.Add(this.HeaderDesc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цветочный салон Пассифлора";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MainHeader;
        private System.Windows.Forms.Label HeaderDesc;
        private System.Windows.Forms.Button CheckProdsButton;
    }
}

