
namespace Hospital
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DoctorsDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PatientsDGV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.VisitsDGV = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RegistryDGV = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.MedicalCardsDGV = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewVisitButton = new System.Windows.Forms.ToolStripButton();
            this.AddDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddDoctorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPatientButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRegistryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDropDownLButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.DeleteDoctorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePatientButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRegistryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.посещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetPriceButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisitsDGV)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryDGV)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalCardsDGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DoctorsDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Доктора";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DoctorsDGV
            // 
            this.DoctorsDGV.AllowUserToAddRows = false;
            this.DoctorsDGV.AllowUserToDeleteRows = false;
            this.DoctorsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DoctorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDGV.Location = new System.Drawing.Point(6, 8);
            this.DoctorsDGV.Name = "DoctorsDGV";
            this.DoctorsDGV.Size = new System.Drawing.Size(702, 461);
            this.DoctorsDGV.TabIndex = 0;
            this.DoctorsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorsDGV_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PatientsDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Паценты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PatientsDGV
            // 
            this.PatientsDGV.AllowUserToAddRows = false;
            this.PatientsDGV.AllowUserToDeleteRows = false;
            this.PatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDGV.Location = new System.Drawing.Point(8, 7);
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.Size = new System.Drawing.Size(702, 461);
            this.PatientsDGV.TabIndex = 1;
            this.PatientsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDGV_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.VisitsDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(923, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Посещения";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // VisitsDGV
            // 
            this.VisitsDGV.AllowUserToAddRows = false;
            this.VisitsDGV.AllowUserToDeleteRows = false;
            this.VisitsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisitsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitsDGV.Location = new System.Drawing.Point(8, 10);
            this.VisitsDGV.Name = "VisitsDGV";
            this.VisitsDGV.Size = new System.Drawing.Size(907, 454);
            this.VisitsDGV.TabIndex = 2;
            this.VisitsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitsDGV_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RegistryDGV);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(923, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Регистратуры";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RegistryDGV
            // 
            this.RegistryDGV.AllowUserToAddRows = false;
            this.RegistryDGV.AllowUserToDeleteRows = false;
            this.RegistryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegistryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistryDGV.Location = new System.Drawing.Point(8, 10);
            this.RegistryDGV.Name = "RegistryDGV";
            this.RegistryDGV.Size = new System.Drawing.Size(907, 461);
            this.RegistryDGV.TabIndex = 1;
            this.RegistryDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistryDGV_CellDoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.MedicalCardsDGV);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(923, 474);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Мед. карты";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // MedicalCardsDGV
            // 
            this.MedicalCardsDGV.AllowUserToAddRows = false;
            this.MedicalCardsDGV.AllowUserToDeleteRows = false;
            this.MedicalCardsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicalCardsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalCardsDGV.Location = new System.Drawing.Point(8, 7);
            this.MedicalCardsDGV.Name = "MedicalCardsDGV";
            this.MedicalCardsDGV.Size = new System.Drawing.Size(907, 460);
            this.MedicalCardsDGV.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewVisitButton,
            this.AddDropDownButton,
            this.DeleteDropDownLButton,
            this.GetPriceButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(931, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewVisitButton
            // 
            this.NewVisitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewVisitButton.Image = ((System.Drawing.Image)(resources.GetObject("NewVisitButton.Image")));
            this.NewVisitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewVisitButton.Name = "NewVisitButton";
            this.NewVisitButton.Size = new System.Drawing.Size(128, 23);
            this.NewVisitButton.Text = "Новое посещение";
            this.NewVisitButton.Click += new System.EventHandler(this.NewVisitButton_Click);
            // 
            // AddDropDownButton
            // 
            this.AddDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDoctorButton,
            this.AddPatientButton,
            this.AddRegistryButton});
            this.AddDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("AddDropDownButton.Image")));
            this.AddDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDropDownButton.Name = "AddDropDownButton";
            this.AddDropDownButton.Size = new System.Drawing.Size(83, 23);
            this.AddDropDownButton.Text = "Добавить";
            // 
            // AddDoctorButton
            // 
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Size = new System.Drawing.Size(161, 24);
            this.AddDoctorButton.Text = "Доктор";
            this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(161, 24);
            this.AddPatientButton.Text = "Пациент";
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // AddRegistryButton
            // 
            this.AddRegistryButton.Name = "AddRegistryButton";
            this.AddRegistryButton.Size = new System.Drawing.Size(161, 24);
            this.AddRegistryButton.Text = "Регистратура";
            this.AddRegistryButton.Click += new System.EventHandler(this.AddRegistryButton_Click);
            // 
            // DeleteDropDownLButton
            // 
            this.DeleteDropDownLButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteDropDownLButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteDoctorButton,
            this.DeletePatientButton,
            this.DeleteRegistryButton,
            this.посещениеToolStripMenuItem});
            this.DeleteDropDownLButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteDropDownLButton.Image")));
            this.DeleteDropDownLButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteDropDownLButton.Name = "DeleteDropDownLButton";
            this.DeleteDropDownLButton.Size = new System.Drawing.Size(73, 23);
            this.DeleteDropDownLButton.Text = "Удалить";
            // 
            // DeleteDoctorButton
            // 
            this.DeleteDoctorButton.Name = "DeleteDoctorButton";
            this.DeleteDoctorButton.Size = new System.Drawing.Size(161, 24);
            this.DeleteDoctorButton.Text = "Доктора";
            this.DeleteDoctorButton.Click += new System.EventHandler(this.DeleteDoctorButton_Click);
            // 
            // DeletePatientButton
            // 
            this.DeletePatientButton.Name = "DeletePatientButton";
            this.DeletePatientButton.Size = new System.Drawing.Size(161, 24);
            this.DeletePatientButton.Text = "Пациента";
            this.DeletePatientButton.Click += new System.EventHandler(this.DeletePatientButton_Click);
            // 
            // DeleteRegistryButton
            // 
            this.DeleteRegistryButton.Name = "DeleteRegistryButton";
            this.DeleteRegistryButton.Size = new System.Drawing.Size(161, 24);
            this.DeleteRegistryButton.Text = "Регистратуру";
            this.DeleteRegistryButton.Click += new System.EventHandler(this.DeleteRegistryButton_Click);
            // 
            // посещениеToolStripMenuItem
            // 
            this.посещениеToolStripMenuItem.Name = "посещениеToolStripMenuItem";
            this.посещениеToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.посещениеToolStripMenuItem.Text = "Посещение";
            this.посещениеToolStripMenuItem.Click += new System.EventHandler(this.посещениеToolStripMenuItem_Click);
            // 
            // GetPriceButton
            // 
            this.GetPriceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GetPriceButton.Image = ((System.Drawing.Image)(resources.GetObject("GetPriceButton.Image")));
            this.GetPriceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetPriceButton.Name = "GetPriceButton";
            this.GetPriceButton.Size = new System.Drawing.Size(156, 23);
            this.GetPriceButton.Text = "Стоимость посещения";
            this.GetPriceButton.Click += new System.EventHandler(this.GetPriceButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Регистратура: Админ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisitsDGV)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistryDGV)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicalCardsDGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DoctorsDGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewVisitButton;
        private System.Windows.Forms.ToolStripDropDownButton AddDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AddDoctorButton;
        private System.Windows.Forms.ToolStripMenuItem AddPatientButton;
        private System.Windows.Forms.ToolStripMenuItem AddRegistryButton;
        private System.Windows.Forms.ToolStripDropDownButton DeleteDropDownLButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteDoctorButton;
        private System.Windows.Forms.ToolStripMenuItem DeletePatientButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteRegistryButton;
        private System.Windows.Forms.DataGridView PatientsDGV;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView VisitsDGV;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView RegistryDGV;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView MedicalCardsDGV;
        private System.Windows.Forms.ToolStripMenuItem посещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton GetPriceButton;
    }
}