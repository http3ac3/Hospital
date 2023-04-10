
namespace Hospital
{
    partial class VisitPrice
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
            this.SpecializationTB = new System.Windows.Forms.TextBox();
            this.FIODoctorTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ChooseDoctorButton = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.VisitsAmountTB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VisitsAmountTB)).BeginInit();
            this.SuspendLayout();
            // 
            // SpecializationTB
            // 
            this.SpecializationTB.Location = new System.Drawing.Point(128, 59);
            this.SpecializationTB.Name = "SpecializationTB";
            this.SpecializationTB.ReadOnly = true;
            this.SpecializationTB.Size = new System.Drawing.Size(333, 23);
            this.SpecializationTB.TabIndex = 4;
            // 
            // FIODoctorTB
            // 
            this.FIODoctorTB.Location = new System.Drawing.Point(128, 32);
            this.FIODoctorTB.Name = "FIODoctorTB";
            this.FIODoctorTB.ReadOnly = true;
            this.FIODoctorTB.Size = new System.Drawing.Size(333, 23);
            this.FIODoctorTB.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "ФИО врача";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Специализация";
            // 
            // ChooseDoctorButton
            // 
            this.ChooseDoctorButton.AutoSize = true;
            this.ChooseDoctorButton.Location = new System.Drawing.Point(125, 9);
            this.ChooseDoctorButton.Name = "ChooseDoctorButton";
            this.ChooseDoctorButton.Size = new System.Drawing.Size(108, 17);
            this.ChooseDoctorButton.TabIndex = 6;
            this.ChooseDoctorButton.TabStop = true;
            this.ChooseDoctorButton.Text = "Выбрать врача";
            this.ChooseDoctorButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChooseDoctorButton_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите количество приемов";
            // 
            // VisitsAmountTB
            // 
            this.VisitsAmountTB.Location = new System.Drawing.Point(224, 88);
            this.VisitsAmountTB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.VisitsAmountTB.Name = "VisitsAmountTB";
            this.VisitsAmountTB.ReadOnly = true;
            this.VisitsAmountTB.Size = new System.Drawing.Size(112, 23);
            this.VisitsAmountTB.TabIndex = 7;
            this.VisitsAmountTB.ValueChanged += new System.EventHandler(this.VisitsAmountTB_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(222, 140);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.ReadOnly = true;
            this.PriceTB.Size = new System.Drawing.Size(239, 23);
            this.PriceTB.TabIndex = 4;
            // 
            // VisitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 175);
            this.Controls.Add(this.VisitsAmountTB);
            this.Controls.Add(this.ChooseDoctorButton);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.SpecializationTB);
            this.Controls.Add(this.FIODoctorTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisitPrice";
            this.Text = "Стоимость посещения";
            ((System.ComponentModel.ISupportInitialize)(this.VisitsAmountTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox SpecializationTB;
        public System.Windows.Forms.TextBox FIODoctorTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel ChooseDoctorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown VisitsAmountTB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PriceTB;
    }
}