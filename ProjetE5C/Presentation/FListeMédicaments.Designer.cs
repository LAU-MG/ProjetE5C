namespace ProjetE5C.Presentation
{
    partial class FListeMédicaments
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
            this.dgvMedFam = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedFam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedFam
            // 
            this.dgvMedFam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedFam.Location = new System.Drawing.Point(128, 103);
            this.dgvMedFam.Name = "dgvMedFam";
            this.dgvMedFam.Size = new System.Drawing.Size(555, 194);
            this.dgvMedFam.TabIndex = 0;
            this.dgvMedFam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedFam_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(336, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "liste de médicaments";
            // 
            // btFermer
            // 
            this.btFermer.Location = new System.Drawing.Point(687, 392);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(75, 23);
            this.btFermer.TabIndex = 2;
            this.btFermer.Text = "Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // FListeMédicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedFam);
            this.Name = "FListeMédicaments";
            this.Text = "FListeMédicaments";
            this.Load += new System.EventHandler(this.FListeMédicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedFam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedFam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFermer;
    }
}