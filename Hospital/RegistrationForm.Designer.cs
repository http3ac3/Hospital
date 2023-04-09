
namespace Hospital
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasssportNumberTB = new System.Windows.Forms.MaskedTextBox();
            this.PassportSeriesTB = new System.Windows.Forms.MaskedTextBox();
            this.CheckPassportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginNameTB = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите серию своего паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите номер своего паспорта";
            // 
            // PasssportNumberTB
            // 
            this.PasssportNumberTB.Location = new System.Drawing.Point(240, 39);
            this.PasssportNumberTB.Mask = "000000";
            this.PasssportNumberTB.Name = "PasssportNumberTB";
            this.PasssportNumberTB.Size = new System.Drawing.Size(174, 23);
            this.PasssportNumberTB.TabIndex = 32;
            // 
            // PassportSeriesTB
            // 
            this.PassportSeriesTB.Location = new System.Drawing.Point(240, 10);
            this.PassportSeriesTB.Mask = "0000";
            this.PassportSeriesTB.Name = "PassportSeriesTB";
            this.PassportSeriesTB.Size = new System.Drawing.Size(174, 23);
            this.PassportSeriesTB.TabIndex = 33;
            // 
            // CheckPassportButton
            // 
            this.CheckPassportButton.Location = new System.Drawing.Point(12, 72);
            this.CheckPassportButton.Name = "CheckPassportButton";
            this.CheckPassportButton.Size = new System.Drawing.Size(402, 28);
            this.CheckPassportButton.TabIndex = 34;
            this.CheckPassportButton.Text = "Проверить данные ";
            this.CheckPassportButton.UseVisualStyleBackColor = true;
            this.CheckPassportButton.Click += new System.EventHandler(this.CheckPassportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PasswordTB);
            this.groupBox1.Controls.Add(this.RegButton);
            this.groupBox1.Controls.Add(this.LoginNameTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 137);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя для входа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(126, 53);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(266, 23);
            this.PasswordTB.TabIndex = 4;
            // 
            // LoginNameTB
            // 
            this.LoginNameTB.Location = new System.Drawing.Point(126, 25);
            this.LoginNameTB.Name = "LoginNameTB";
            this.LoginNameTB.ReadOnly = true;
            this.LoginNameTB.Size = new System.Drawing.Size(266, 23);
            this.LoginNameTB.TabIndex = 5;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(46, 94);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(326, 28);
            this.RegButton.TabIndex = 34;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckPassportButton);
            this.Controls.Add(this.PasssportNumberTB);
            this.Controls.Add(this.PassportSeriesTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PasssportNumberTB;
        private System.Windows.Forms.MaskedTextBox PassportSeriesTB;
        private System.Windows.Forms.Button CheckPassportButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox LoginNameTB;
    }
}