
namespace Hospital
{
    partial class VisitList
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
            this.VisitListDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VisitListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // VisitListDGV
            // 
            this.VisitListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.VisitListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitListDGV.Location = new System.Drawing.Point(12, 12);
            this.VisitListDGV.Name = "VisitListDGV";
            this.VisitListDGV.Size = new System.Drawing.Size(629, 499);
            this.VisitListDGV.TabIndex = 0;
            // 
            // VisitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 523);
            this.Controls.Add(this.VisitListDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisitList";
            this.Text = "Лист посещений";
            this.Load += new System.EventHandler(this.VisitList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisitListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VisitListDGV;
    }
}