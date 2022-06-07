namespace ProjetE5C.Presentation.RapportVisite
{
    partial class FajouterRapport
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
            this.cbPraticien = new System.Windows.Forms.ComboBox();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBilan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDateRapport = new System.Windows.Forms.DateTimePicker();
            this.tbMotif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPraticien
            // 
            this.cbPraticien.FormattingEnabled = true;
            this.cbPraticien.Location = new System.Drawing.Point(182, 107);
            this.cbPraticien.Name = "cbPraticien";
            this.cbPraticien.Size = new System.Drawing.Size(189, 21);
            this.cbPraticien.TabIndex = 0;
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(183, 157);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(187, 21);
            this.cbVisiteur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ajout d\'un rapport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Praticien :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Visiteur :";
            // 
            // tbBilan
            // 
            this.tbBilan.Location = new System.Drawing.Point(183, 212);
            this.tbBilan.Name = "tbBilan";
            this.tbBilan.Size = new System.Drawing.Size(187, 20);
            this.tbBilan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bilan :";
            // 
            // dtDateRapport
            // 
            this.dtDateRapport.Location = new System.Drawing.Point(182, 298);
            this.dtDateRapport.Name = "dtDateRapport";
            this.dtDateRapport.Size = new System.Drawing.Size(189, 20);
            this.dtDateRapport.TabIndex = 7;
            // 
            // tbMotif
            // 
            this.tbMotif.Location = new System.Drawing.Point(182, 257);
            this.tbMotif.Name = "tbMotif";
            this.tbMotif.Size = new System.Drawing.Size(189, 20);
            this.tbMotif.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motif :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date :";
            // 
            // bt_valider
            // 
            this.bt_valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_valider.Location = new System.Drawing.Point(182, 365);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(74, 24);
            this.bt_valider.TabIndex = 11;
            this.bt_valider.Text = "valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // FajouterRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMotif);
            this.Controls.Add(this.dtDateRapport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBilan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVisiteur);
            this.Controls.Add(this.cbPraticien);
            this.Name = "FajouterRapport";
            this.Text = "FajouterRapport";
            this.Load += new System.EventHandler(this.FajouterRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPraticien;
        private System.Windows.Forms.ComboBox cbVisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBilan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDateRapport;
        private System.Windows.Forms.TextBox tbMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_valider;
    }
}