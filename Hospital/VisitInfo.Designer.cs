
namespace Hospital
{
    partial class VisitInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FIOPatientTB = new System.Windows.Forms.TextBox();
            this.PatientPassportSeriesTB = new System.Windows.Forms.TextBox();
            this.PatientPassportNumberTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiseaseTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.VisitDateTB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FIODoctorTB = new System.Windows.Forms.TextBox();
            this.DoctorPassportSeriesTB = new System.Windows.Forms.TextBox();
            this.DoctorPassportNumberTB = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SetPatientButton = new System.Windows.Forms.ToolStripButton();
            this.SetDoctorButton = new System.Windows.Forms.ToolStripButton();
            this.AddVisitButton = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            this.SpecializationTB = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Серия паспорта пациента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ФИО пациента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер паспорта пациента";
            // 
            // FIOPatientTB
            // 
            this.FIOPatientTB.Location = new System.Drawing.Point(127, 30);
            this.FIOPatientTB.Name = "FIOPatientTB";
            this.FIOPatientTB.ReadOnly = true;
            this.FIOPatientTB.Size = new System.Drawing.Size(333, 23);
            this.FIOPatientTB.TabIndex = 1;
            // 
            // PatientPassportSeriesTB
            // 
            this.PatientPassportSeriesTB.Location = new System.Drawing.Point(200, 59);
            this.PatientPassportSeriesTB.Name = "PatientPassportSeriesTB";
            this.PatientPassportSeriesTB.ReadOnly = true;
            this.PatientPassportSeriesTB.Size = new System.Drawing.Size(260, 23);
            this.PatientPassportSeriesTB.TabIndex = 1;
            // 
            // PatientPassportNumberTB
            // 
            this.PatientPassportNumberTB.Location = new System.Drawing.Point(200, 87);
            this.PatientPassportNumberTB.Name = "PatientPassportNumberTB";
            this.PatientPassportNumberTB.ReadOnly = true;
            this.PatientPassportNumberTB.Size = new System.Drawing.Size(260, 23);
            this.PatientPassportNumberTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Болезнь";
            // 
            // DiseaseTB
            // 
            this.DiseaseTB.Location = new System.Drawing.Point(163, 126);
            this.DiseaseTB.Name = "DiseaseTB";
            this.DiseaseTB.ReadOnly = true;
            this.DiseaseTB.Size = new System.Drawing.Size(297, 23);
            this.DiseaseTB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Состояние пациента";
            // 
            // StatusCB
            // 
            this.StatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCB.Enabled = false;
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Items.AddRange(new object[] {
            "Болен",
            "Здоров"});
            this.StatusCB.Location = new System.Drawing.Point(163, 158);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(297, 24);
            this.StatusCB.TabIndex = 2;
            // 
            // VisitDateTB
            // 
            this.VisitDateTB.Enabled = false;
            this.VisitDateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VisitDateTB.Location = new System.Drawing.Point(163, 188);
            this.VisitDateTB.Name = "VisitDateTB";
            this.VisitDateTB.Size = new System.Drawing.Size(297, 23);
            this.VisitDateTB.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Дата посещения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Серия паспорта врача";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Номер паспорта врача";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "ФИО врача";
            // 
            // FIODoctorTB
            // 
            this.FIODoctorTB.Location = new System.Drawing.Point(127, 250);
            this.FIODoctorTB.Name = "FIODoctorTB";
            this.FIODoctorTB.ReadOnly = true;
            this.FIODoctorTB.Size = new System.Drawing.Size(333, 23);
            this.FIODoctorTB.TabIndex = 1;
            // 
            // DoctorPassportSeriesTB
            // 
            this.DoctorPassportSeriesTB.Location = new System.Drawing.Point(178, 308);
            this.DoctorPassportSeriesTB.Name = "DoctorPassportSeriesTB";
            this.DoctorPassportSeriesTB.ReadOnly = true;
            this.DoctorPassportSeriesTB.Size = new System.Drawing.Size(231, 23);
            this.DoctorPassportSeriesTB.TabIndex = 1;
            // 
            // DoctorPassportNumberTB
            // 
            this.DoctorPassportNumberTB.Location = new System.Drawing.Point(178, 336);
            this.DoctorPassportNumberTB.Name = "DoctorPassportNumberTB";
            this.DoctorPassportNumberTB.ReadOnly = true;
            this.DoctorPassportNumberTB.Size = new System.Drawing.Size(231, 23);
            this.DoctorPassportNumberTB.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPatientButton,
            this.SetDoctorButton,
            this.AddVisitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(476, 26);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SetPatientButton
            // 
            this.SetPatientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SetPatientButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SetPatientButton.Image = ((System.Drawing.Image)(resources.GetObject("SetPatientButton.Image")));
            this.SetPatientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetPatientButton.Name = "SetPatientButton";
            this.SetPatientButton.Size = new System.Drawing.Size(143, 23);
            this.SetPatientButton.Text = "Назначить пациента";
            this.SetPatientButton.Click += new System.EventHandler(this.SetPatientButton_Click);
            // 
            // SetDoctorButton
            // 
            this.SetDoctorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SetDoctorButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SetDoctorButton.Image = ((System.Drawing.Image)(resources.GetObject("SetDoctorButton.Image")));
            this.SetDoctorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetDoctorButton.Name = "SetDoctorButton";
            this.SetDoctorButton.Size = new System.Drawing.Size(121, 23);
            this.SetDoctorButton.Text = "Назначить врача";
            this.SetDoctorButton.Click += new System.EventHandler(this.SetDoctorButton_Click);
            // 
            // AddVisitButton
            // 
            this.AddVisitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddVisitButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddVisitButton.Image = ((System.Drawing.Image)(resources.GetObject("AddVisitButton.Image")));
            this.AddVisitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddVisitButton.Name = "AddVisitButton";
            this.AddVisitButton.Size = new System.Drawing.Size(149, 23);
            this.AddVisitButton.Text = "Добавить посещение";
            this.AddVisitButton.Click += new System.EventHandler(this.AddVisitButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Специализация";
            // 
            // SpecializationTB
            // 
            this.SpecializationTB.Location = new System.Drawing.Point(127, 277);
            this.SpecializationTB.Name = "SpecializationTB";
            this.SpecializationTB.ReadOnly = true;
            this.SpecializationTB.Size = new System.Drawing.Size(282, 23);
            this.SpecializationTB.TabIndex = 1;
            // 
            // VisitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 367);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.VisitDateTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.DiseaseTB);
            this.Controls.Add(this.SpecializationTB);
            this.Controls.Add(this.DoctorPassportNumberTB);
            this.Controls.Add(this.PatientPassportNumberTB);
            this.Controls.Add(this.DoctorPassportSeriesTB);
            this.Controls.Add(this.PatientPassportSeriesTB);
            this.Controls.Add(this.FIODoctorTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FIOPatientTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisitInfo";
            this.Text = "Сведения о посещении";
            this.Load += new System.EventHandler(this.VisitInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiseaseTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.DateTimePicker VisitDateTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SetPatientButton;
        private System.Windows.Forms.ToolStripButton SetDoctorButton;
        private System.Windows.Forms.ToolStripButton AddVisitButton;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox FIOPatientTB;
        public System.Windows.Forms.TextBox PatientPassportSeriesTB;
        public System.Windows.Forms.TextBox PatientPassportNumberTB;
        public System.Windows.Forms.TextBox FIODoctorTB;
        public System.Windows.Forms.TextBox DoctorPassportSeriesTB;
        public System.Windows.Forms.TextBox DoctorPassportNumberTB;
        public System.Windows.Forms.TextBox SpecializationTB;
    }
}