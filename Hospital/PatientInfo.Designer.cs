
namespace Hospital
{
    partial class PatientInfo
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
            this.BirthdayTB = new System.Windows.Forms.DateTimePicker();
            this.SexCB = new System.Windows.Forms.ComboBox();
            this.PasssportNumberTB = new System.Windows.Forms.MaskedTextBox();
            this.PassportSeriesTB = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SnilsTB = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PolicyTB = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RegDateTB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.MCTypeCB = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RegistryTB = new System.Windows.Forms.TextBox();
            this.ChangeRegistryButton = new System.Windows.Forms.LinkLabel();
            this.VisitListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BirthdayTB
            // 
            this.BirthdayTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayTB.Location = new System.Drawing.Point(477, 42);
            this.BirthdayTB.Name = "BirthdayTB";
            this.BirthdayTB.Size = new System.Drawing.Size(253, 23);
            this.BirthdayTB.TabIndex = 33;
            // 
            // SexCB
            // 
            this.SexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexCB.FormattingEnabled = true;
            this.SexCB.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.SexCB.Location = new System.Drawing.Point(84, 98);
            this.SexCB.Name = "SexCB";
            this.SexCB.Size = new System.Drawing.Size(88, 24);
            this.SexCB.TabIndex = 32;
            // 
            // PasssportNumberTB
            // 
            this.PasssportNumberTB.Location = new System.Drawing.Point(477, 98);
            this.PasssportNumberTB.Mask = "000000";
            this.PasssportNumberTB.Name = "PasssportNumberTB";
            this.PasssportNumberTB.Size = new System.Drawing.Size(174, 23);
            this.PasssportNumberTB.TabIndex = 30;
            // 
            // PassportSeriesTB
            // 
            this.PassportSeriesTB.Location = new System.Drawing.Point(477, 70);
            this.PassportSeriesTB.Mask = "0000";
            this.PassportSeriesTB.Name = "PassportSeriesTB";
            this.PassportSeriesTB.Size = new System.Drawing.Size(174, 23);
            this.PassportSeriesTB.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Дата рождения";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Номер телефона";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(477, 12);
            this.PhoneNumberTextBox.Mask = "+7(000)000-00-00";
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(253, 23);
            this.PhoneNumberTextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Фамилия";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(84, 12);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(219, 23);
            this.LastNameTextBox.TabIndex = 24;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(84, 67);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(219, 23);
            this.PatronymicTextBox.TabIndex = 25;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(84, 39);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(219, 23);
            this.FirstNameTextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Серия паспорта";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 17);
            this.label28.TabIndex = 20;
            this.label28.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Номер паспорта";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 70);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 17);
            this.label29.TabIndex = 23;
            this.label29.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "СНИЛС";
            // 
            // SnilsTB
            // 
            this.SnilsTB.Location = new System.Drawing.Point(84, 128);
            this.SnilsTB.Mask = "000-000-000 00";
            this.SnilsTB.Name = "SnilsTB";
            this.SnilsTB.Size = new System.Drawing.Size(228, 23);
            this.SnilsTB.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Полис ОМС";
            // 
            // PolicyTB
            // 
            this.PolicyTB.Location = new System.Drawing.Point(442, 131);
            this.PolicyTB.Mask = "0000000000000000";
            this.PolicyTB.Name = "PolicyTB";
            this.PolicyTB.Size = new System.Drawing.Size(209, 23);
            this.PolicyTB.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Дата регистрации";
            // 
            // RegDateTB
            // 
            this.RegDateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RegDateTB.Location = new System.Drawing.Point(155, 203);
            this.RegDateTB.Name = "RegDateTB";
            this.RegDateTB.Size = new System.Drawing.Size(190, 23);
            this.RegDateTB.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Тип мед. карты";
            // 
            // MCTypeCB
            // 
            this.MCTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MCTypeCB.FormattingEnabled = true;
            this.MCTypeCB.Items.AddRange(new object[] {
            "Физическая",
            "Электронная"});
            this.MCTypeCB.Location = new System.Drawing.Point(155, 232);
            this.MCTypeCB.Name = "MCTypeCB";
            this.MCTypeCB.Size = new System.Drawing.Size(190, 24);
            this.MCTypeCB.TabIndex = 32;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(502, 219);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(231, 37);
            this.AddButton.TabIndex = 34;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RegistryTB
            // 
            this.RegistryTB.Location = new System.Drawing.Point(155, 174);
            this.RegistryTB.Name = "RegistryTB";
            this.RegistryTB.ReadOnly = true;
            this.RegistryTB.Size = new System.Drawing.Size(291, 23);
            this.RegistryTB.TabIndex = 24;
            // 
            // ChangeRegistryButton
            // 
            this.ChangeRegistryButton.AutoSize = true;
            this.ChangeRegistryButton.Enabled = false;
            this.ChangeRegistryButton.Location = new System.Drawing.Point(6, 177);
            this.ChangeRegistryButton.Name = "ChangeRegistryButton";
            this.ChangeRegistryButton.Size = new System.Drawing.Size(143, 17);
            this.ChangeRegistryButton.TabIndex = 35;
            this.ChangeRegistryButton.TabStop = true;
            this.ChangeRegistryButton.Text = "Адрес регистратуры";
            this.ChangeRegistryButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeRegistryButton_LinkClicked);
            // 
            // VisitListButton
            // 
            this.VisitListButton.Location = new System.Drawing.Point(502, 177);
            this.VisitListButton.Name = "VisitListButton";
            this.VisitListButton.Size = new System.Drawing.Size(231, 37);
            this.VisitListButton.TabIndex = 34;
            this.VisitListButton.Text = "Лист посещений";
            this.VisitListButton.UseVisualStyleBackColor = true;
            this.VisitListButton.Visible = false;
            this.VisitListButton.Click += new System.EventHandler(this.VisitListButton_Click);
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 262);
            this.Controls.Add(this.ChangeRegistryButton);
            this.Controls.Add(this.VisitListButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RegDateTB);
            this.Controls.Add(this.BirthdayTB);
            this.Controls.Add(this.MCTypeCB);
            this.Controls.Add(this.SexCB);
            this.Controls.Add(this.PasssportNumberTB);
            this.Controls.Add(this.PolicyTB);
            this.Controls.Add(this.SnilsTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PassportSeriesTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistryTB);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label29);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientInfo";
            this.Text = "Сведения о пациенте";
            this.Load += new System.EventHandler(this.PatientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdayTB;
        private System.Windows.Forms.ComboBox SexCB;
        private System.Windows.Forms.MaskedTextBox PasssportNumberTB;
        private System.Windows.Forms.MaskedTextBox PassportSeriesTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox PatronymicTextBox;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox SnilsTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox PolicyTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker RegDateTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox MCTypeCB;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.TextBox RegistryTB;
        private System.Windows.Forms.LinkLabel ChangeRegistryButton;
        private System.Windows.Forms.Button VisitListButton;
    }
}