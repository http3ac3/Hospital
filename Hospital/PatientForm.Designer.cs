
namespace Hospital
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorsDGV = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.VisitListButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RegistryDGV = new System.Windows.Forms.DataGridView();
            this.VisitPriceButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица докторов";
            // 
            // DoctorsDGV
            // 
            this.DoctorsDGV.AllowUserToAddRows = false;
            this.DoctorsDGV.AllowUserToDeleteRows = false;
            this.DoctorsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DoctorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsDGV.Location = new System.Drawing.Point(4, 6);
            this.DoctorsDGV.Name = "DoctorsDGV";
            this.DoctorsDGV.Size = new System.Drawing.Size(1361, 461);
            this.DoctorsDGV.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisitListButton,
            this.VisitPriceButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1381, 26);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // VisitListButton
            // 
            this.VisitListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VisitListButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VisitListButton.Image = ((System.Drawing.Image)(resources.GetObject("VisitListButton.Image")));
            this.VisitListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VisitListButton.Name = "VisitListButton";
            this.VisitListButton.Size = new System.Drawing.Size(149, 23);
            this.VisitListButton.Text = "Мой лист посещений";
            this.VisitListButton.Click += new System.EventHandler(this.VisitListButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1381, 498);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DoctorsDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1373, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Врачи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RegistryDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1373, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Адреса регистратур";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RegistryDGV
            // 
            this.RegistryDGV.AllowUserToAddRows = false;
            this.RegistryDGV.AllowUserToDeleteRows = false;
            this.RegistryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegistryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistryDGV.Location = new System.Drawing.Point(5, 4);
            this.RegistryDGV.Name = "RegistryDGV";
            this.RegistryDGV.Size = new System.Drawing.Size(1362, 461);
            this.RegistryDGV.TabIndex = 4;
            // 
            // VisitPriceButton
            // 
            this.VisitPriceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VisitPriceButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VisitPriceButton.Image = ((System.Drawing.Image)(resources.GetObject("VisitPriceButton.Image")));
            this.VisitPriceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VisitPriceButton.Name = "VisitPriceButton";
            this.VisitPriceButton.Size = new System.Drawing.Size(156, 23);
            this.VisitPriceButton.Text = "Стоимость посещения";
            this.VisitPriceButton.Click += new System.EventHandler(this.VisitPriceButton_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientForm";
            this.Text = "Регистратура: Пациент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientForm_FormClosing);
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DoctorsDGV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton VisitListButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView RegistryDGV;
        private System.Windows.Forms.ToolStripButton VisitPriceButton;
    }
}