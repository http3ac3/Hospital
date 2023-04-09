
namespace Hospital
{
    partial class SetRegistry
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
            this.RegistryDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistryDGV
            // 
            this.RegistryDGV.AllowUserToAddRows = false;
            this.RegistryDGV.AllowUserToDeleteRows = false;
            this.RegistryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegistryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistryDGV.Location = new System.Drawing.Point(12, 12);
            this.RegistryDGV.Name = "RegistryDGV";
            this.RegistryDGV.Size = new System.Drawing.Size(907, 368);
            this.RegistryDGV.TabIndex = 2;
            this.RegistryDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistryDGV_CellDoubleClick);
            // 
            // SetRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 392);
            this.Controls.Add(this.RegistryDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SetRegistry";
            this.Text = "Выбор регистратуры";
            this.Load += new System.EventHandler(this.SetRegistry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RegistryDGV;
    }
}