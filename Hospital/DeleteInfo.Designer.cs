﻿
namespace Hospital
{
    partial class DeleteInfo
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
            this.DeleteDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteDGV
            // 
            this.DeleteDGV.AllowUserToAddRows = false;
            this.DeleteDGV.AllowUserToDeleteRows = false;
            this.DeleteDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeleteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDGV.Location = new System.Drawing.Point(12, 12);
            this.DeleteDGV.Name = "DeleteDGV";
            this.DeleteDGV.Size = new System.Drawing.Size(941, 501);
            this.DeleteDGV.TabIndex = 2;
            this.DeleteDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteDGV_CellDoubleClick);
            // 
            // DeleteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 525);
            this.Controls.Add(this.DeleteDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteInfo";
            this.Text = "Удаление информации";
            this.Load += new System.EventHandler(this.DeleteInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeleteDGV;
    }
}