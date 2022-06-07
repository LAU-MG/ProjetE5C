namespace ProjetE5C.Presentation.RapportVisite
{
    partial class FListeRVDate
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
            this.dgv_RVDate = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RVDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RVDate
            // 
            this.dgv_RVDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RVDate.Location = new System.Drawing.Point(88, 145);
            this.dgv_RVDate.Name = "dgv_RVDate";
            this.dgv_RVDate.Size = new System.Drawing.Size(629, 197);
            this.dgv_RVDate.TabIndex = 0;
            this.dgv_RVDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RVDate_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(239, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des rapport de visite par date";
            // 
            // FListeRVDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_RVDate);
            this.Name = "FListeRVDate";
            this.Text = "FListeRVDate";
            this.Load += new System.EventHandler(this.FListeRVDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RVDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RVDate;
        private System.Windows.Forms.Label label1;
    }
}