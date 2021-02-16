namespace Passiflora
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.SectionHeader = new System.Windows.Forms.Label();
            this.SelectedProdLabel = new System.Windows.Forms.Label();
            this.SelectedProdCountLabel = new System.Windows.Forms.Label();
            this.BySelf = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ByCourier = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionHeader
            // 
            this.SectionHeader.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.SectionHeader.Location = new System.Drawing.Point(39, 26);
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.Size = new System.Drawing.Size(348, 52);
            this.SectionHeader.TabIndex = 4;
            this.SectionHeader.Text = "Оформление заказа";
            // 
            // SelectedProdLabel
            // 
            this.SelectedProdLabel.AutoSize = true;
            this.SelectedProdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedProdLabel.Location = new System.Drawing.Point(16, 94);
            this.SelectedProdLabel.Name = "SelectedProdLabel";
            this.SelectedProdLabel.Size = new System.Drawing.Size(150, 21);
            this.SelectedProdLabel.TabIndex = 5;
            this.SelectedProdLabel.Text = "Выбранный товар:  ";
            // 
            // SelectedProdCountLabel
            // 
            this.SelectedProdCountLabel.AutoSize = true;
            this.SelectedProdCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedProdCountLabel.Location = new System.Drawing.Point(16, 131);
            this.SelectedProdCountLabel.Name = "SelectedProdCountLabel";
            this.SelectedProdCountLabel.Size = new System.Drawing.Size(100, 21);
            this.SelectedProdCountLabel.TabIndex = 6;
            this.SelectedProdCountLabel.Text = "Количество: ";
            // 
            // BySelf
            // 
            this.BySelf.AutoSize = true;
            this.BySelf.Location = new System.Drawing.Point(20, 35);
            this.BySelf.Name = "BySelf";
            this.BySelf.Size = new System.Drawing.Size(109, 25);
            this.BySelf.TabIndex = 7;
            this.BySelf.TabStop = true;
            this.BySelf.Text = "Самовывоз";
            this.BySelf.UseVisualStyleBackColor = true;
            this.BySelf.CheckedChanged += new System.EventHandler(this.BySelf_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ByCourier);
            this.groupBox1.Controls.Add(this.BySelf);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ доставки";
            // 
            // ByCourier
            // 
            this.ByCourier.AutoSize = true;
            this.ByCourier.Location = new System.Drawing.Point(149, 35);
            this.ByCourier.Name = "ByCourier";
            this.ByCourier.Size = new System.Drawing.Size(99, 25);
            this.ByCourier.TabIndex = 8;
            this.ByCourier.TabStop = true;
            this.ByCourier.Text = "Курьером";
            this.ByCourier.UseVisualStyleBackColor = true;
            this.ByCourier.CheckedChanged += new System.EventHandler(this.ByCourier_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите адрес доставки: ";
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(16, 290);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(185, 20);
            this.AddressInput.TabIndex = 10;
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(91)))), ((int)(((byte)(66)))));
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.ForeColor = System.Drawing.Color.White;
            this.OrderButton.Location = new System.Drawing.Point(16, 351);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(176, 33);
            this.OrderButton.TabIndex = 21;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(13, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "При самовывозе в заказе будет установлен адрес магазина";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(424, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.AddressInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectedProdCountLabel);
            this.Controls.Add(this.SelectedProdLabel);
            this.Controls.Add(this.SectionHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассифлора - оформление заказа";
            this.Load += new System.EventHandler(this.Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SectionHeader;
        private System.Windows.Forms.Label SelectedProdLabel;
        private System.Windows.Forms.Label SelectedProdCountLabel;
        private System.Windows.Forms.RadioButton BySelf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ByCourier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label label2;
    }
}