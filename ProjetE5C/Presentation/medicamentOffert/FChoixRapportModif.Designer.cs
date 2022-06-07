namespace ProjetE5C.Presentation.medicamentOffert
{
    partial class FChoixRapportModif
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
            this.cb_rapport = new System.Windows.Forms.ComboBox();
            this.btn_supp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_rapport
            // 
            this.cb_rapport.FormattingEnabled = true;
            this.cb_rapport.Location = new System.Drawing.Point(218, 195);
            this.cb_rapport.Name = "cb_rapport";
            this.cb_rapport.Size = new System.Drawing.Size(301, 21);
            this.cb_rapport.TabIndex = 0;
            this.cb_rapport.SelectedIndexChanged += new System.EventHandler(this.cb_rapport_SelectedIndexChanged);
            // 
            // btn_supp
            // 
            this.btn_supp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_supp.Location = new System.Drawing.Point(218, 282);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(92, 30);
            this.btn_supp.TabIndex = 1;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "choix du rapport";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(430, 282);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(89, 30);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "modifier";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // FChoixRapportModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.cb_rapport);
            this.Name = "FChoixRapportModif";
            this.Text = "FChoixRapportModif";
            this.Load += new System.EventHandler(this.FChoixRapportModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_rapport;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_valider;
    }
}