namespace ProjetE5C.Presentation.RapportVisite
{
    partial class FChoixNomP
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_rvNomP = new System.Windows.Forms.ComboBox();
            this.bt_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(177, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche de rapports de visite par nom de Praticien";
            // 
            // cb_rvNomP
            // 
            this.cb_rvNomP.FormattingEnabled = true;
            this.cb_rvNomP.Location = new System.Drawing.Point(168, 140);
            this.cb_rvNomP.Name = "cb_rvNomP";
            this.cb_rvNomP.Size = new System.Drawing.Size(410, 21);
            this.cb_rvNomP.TabIndex = 1;
            this.cb_rvNomP.SelectedIndexChanged += new System.EventHandler(this.cb_rvNomP_SelectedIndexChanged);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(168, 242);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(80, 29);
            this.bt_valider.TabIndex = 2;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // FChoixNomP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.cb_rvNomP);
            this.Controls.Add(this.label1);
            this.Name = "FChoixNomP";
            this.Text = "FChoixNomP";
            this.Load += new System.EventHandler(this.FChoixNomP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_rvNomP;
        private System.Windows.Forms.Button bt_valider;
    }
}