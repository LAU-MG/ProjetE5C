namespace ProjetE5C.Presentation.medicamentOffert
{
    partial class FChoixVisiteurModif
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
            this.cb_visiteur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_visiteur
            // 
            this.cb_visiteur.FormattingEnabled = true;
            this.cb_visiteur.Location = new System.Drawing.Point(183, 172);
            this.cb_visiteur.Name = "cb_visiteur";
            this.cb_visiteur.Size = new System.Drawing.Size(228, 21);
            this.cb_visiteur.TabIndex = 0;
            this.cb_visiteur.SelectedIndexChanged += new System.EventHandler(this.cb_visiteur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choix du visiteur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(183, 269);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(74, 27);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // FChoixVisiteurModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_visiteur);
            this.Name = "FChoixVisiteurModif";
            this.Text = "FChoixVisiteurModif";
            this.Load += new System.EventHandler(this.FChoixVisiteurModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_visiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_valider;
    }
}