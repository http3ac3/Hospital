
namespace Hospital
{
    partial class RegistryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistryInfo));
            this.HomeNumberTB = new System.Windows.Forms.TextBox();
            this.StreetTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LocalityTB = new System.Windows.Forms.TextBox();
            this.RegionTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountryTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeNumberTB
            // 
            this.HomeNumberTB.Location = new System.Drawing.Point(126, 154);
            this.HomeNumberTB.Name = "HomeNumberTB";
            this.HomeNumberTB.ReadOnly = true;
            this.HomeNumberTB.Size = new System.Drawing.Size(193, 23);
            this.HomeNumberTB.TabIndex = 8;
            // 
            // StreetTB
            // 
            this.StreetTB.Location = new System.Drawing.Point(93, 125);
            this.StreetTB.Name = "StreetTB";
            this.StreetTB.ReadOnly = true;
            this.StreetTB.Size = new System.Drawing.Size(226, 23);
            this.StreetTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Номер дома";
            // 
            // LocalityTB
            // 
            this.LocalityTB.Location = new System.Drawing.Point(93, 96);
            this.LocalityTB.Name = "LocalityTB";
            this.LocalityTB.ReadOnly = true;
            this.LocalityTB.Size = new System.Drawing.Size(226, 23);
            this.LocalityTB.TabIndex = 11;
            // 
            // RegionTB
            // 
            this.RegionTB.Location = new System.Drawing.Point(93, 64);
            this.RegionTB.Name = "RegionTB";
            this.RegionTB.ReadOnly = true;
            this.RegionTB.Size = new System.Drawing.Size(226, 23);
            this.RegionTB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Улица";
            // 
            // CountryTB
            // 
            this.CountryTB.Location = new System.Drawing.Point(93, 34);
            this.CountryTB.Name = "CountryTB";
            this.CountryTB.ReadOnly = true;
            this.CountryTB.Size = new System.Drawing.Size(226, 23);
            this.CountryTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нас. пункт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Регион";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Страна";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(332, 26);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(161, 23);
            this.AddButton.Text = "Добавить регистратуру";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RegistryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 188);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.HomeNumberTB);
            this.Controls.Add(this.StreetTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LocalityTB);
            this.Controls.Add(this.RegionTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountryTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistryInfo";
            this.Text = "Сведения о регистратуре";
            this.Load += new System.EventHandler(this.RegistryInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HomeNumberTB;
        private System.Windows.Forms.TextBox StreetTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LocalityTB;
        private System.Windows.Forms.TextBox RegionTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountryTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddButton;
    }
}