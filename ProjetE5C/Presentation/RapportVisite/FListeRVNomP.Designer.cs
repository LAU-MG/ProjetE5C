namespace ProjetE5C.Presentation.RapportVisite
{
    partial class FListeRVNomP
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
            this.dvgNomP_RV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNomP_RV)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgNomP_RV
            // 
            this.dvgNomP_RV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgNomP_RV.Location = new System.Drawing.Point(167, 134);
            this.dvgNomP_RV.Name = "dvgNomP_RV";
            this.dvgNomP_RV.Size = new System.Drawing.Size(456, 150);
            this.dvgNomP_RV.TabIndex = 0;
            this.dvgNomP_RV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgNomP_RV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(282, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des rapports de visites";
            // 
            // FListeRVNomP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgNomP_RV);
            this.Name = "FListeRVNomP";
            this.Text = "FListeRVNomP";
            this.Load += new System.EventHandler(this.FListeRVNomP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgNomP_RV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgNomP_RV;
        private System.Windows.Forms.Label label1;
    }
}