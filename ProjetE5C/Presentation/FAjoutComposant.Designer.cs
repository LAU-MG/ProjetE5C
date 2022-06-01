namespace ProjetE5C.Presentation
{
    partial class FAjoutComposant
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
            this.cb_Composant = new System.Windows.Forms.ComboBox();
            this.choixMedicament = new System.Windows.Forms.Label();
            this.bt_ValiderAjoutCompo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ChoixMeds = new System.Windows.Forms.ComboBox();
            this.cb_choixMedicaments = new System.Windows.Forms.Label();
            this.tb_quantitee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Composant
            // 
            this.cb_Composant.FormattingEnabled = true;
            this.cb_Composant.Location = new System.Drawing.Point(154, 165);
            this.cb_Composant.Name = "cb_Composant";
            this.cb_Composant.Size = new System.Drawing.Size(250, 21);
            this.cb_Composant.TabIndex = 0;
            this.cb_Composant.SelectedIndexChanged += new System.EventHandler(this.cb_Composant_SelectedIndexChanged);
            // 
            // choixMedicament
            // 
            this.choixMedicament.AutoSize = true;
            this.choixMedicament.Location = new System.Drawing.Point(151, 52);
            this.choixMedicament.Name = "choixMedicament";
            this.choixMedicament.Size = new System.Drawing.Size(104, 13);
            this.choixMedicament.TabIndex = 1;
            this.choixMedicament.Text = "Ajout de composant ";
            // 
            // bt_ValiderAjoutCompo
            // 
            this.bt_ValiderAjoutCompo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ValiderAjoutCompo.Location = new System.Drawing.Point(154, 273);
            this.bt_ValiderAjoutCompo.Name = "bt_ValiderAjoutCompo";
            this.bt_ValiderAjoutCompo.Size = new System.Drawing.Size(83, 21);
            this.bt_ValiderAjoutCompo.TabIndex = 2;
            this.bt_ValiderAjoutCompo.Text = "Ajout";
            this.bt_ValiderAjoutCompo.UseVisualStyleBackColor = true;
            this.bt_ValiderAjoutCompo.Click += new System.EventHandler(this.bt_ValiderAjoutCompo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Composants";
            // 
            // cb_ChoixMeds
            // 
            this.cb_ChoixMeds.FormattingEnabled = true;
            this.cb_ChoixMeds.Location = new System.Drawing.Point(154, 129);
            this.cb_ChoixMeds.Name = "cb_ChoixMeds";
            this.cb_ChoixMeds.Size = new System.Drawing.Size(249, 21);
            this.cb_ChoixMeds.TabIndex = 4;
            this.cb_ChoixMeds.SelectedIndexChanged += new System.EventHandler(this.cb_ChoixMeds_SelectedIndexChanged);
            // 
            // cb_choixMedicaments
            // 
            this.cb_choixMedicaments.AutoSize = true;
            this.cb_choixMedicaments.Location = new System.Drawing.Point(43, 132);
            this.cb_choixMedicaments.Name = "cb_choixMedicaments";
            this.cb_choixMedicaments.Size = new System.Drawing.Size(70, 13);
            this.cb_choixMedicaments.TabIndex = 5;
            this.cb_choixMedicaments.Text = "Medicaments";
            // 
            // tb_quantitee
            // 
            this.tb_quantitee.Location = new System.Drawing.Point(154, 212);
            this.tb_quantitee.Name = "tb_quantitee";
            this.tb_quantitee.Size = new System.Drawing.Size(108, 20);
            this.tb_quantitee.TabIndex = 6;
            this.tb_quantitee.TextChanged += new System.EventHandler(this.tb_quantitee_TextChanged);
            this.tb_quantitee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantité";
            // 
            // FAjoutComposant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_quantitee);
            this.Controls.Add(this.cb_choixMedicaments);
            this.Controls.Add(this.cb_ChoixMeds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ValiderAjoutCompo);
            this.Controls.Add(this.choixMedicament);
            this.Controls.Add(this.cb_Composant);
            this.Name = "FAjoutComposant";
            this.Text = "FAjoutComposant";
            this.Load += new System.EventHandler(this.FAjoutComposant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Composant;
        private System.Windows.Forms.Label choixMedicament;
        private System.Windows.Forms.Button bt_ValiderAjoutCompo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ChoixMeds;
        private System.Windows.Forms.Label cb_choixMedicaments;
        private System.Windows.Forms.TextBox tb_quantitee;
        private System.Windows.Forms.Label label2;
    }
}