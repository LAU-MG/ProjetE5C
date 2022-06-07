namespace ProjetE5C.Presentation.medicamentOffert
{
    partial class FchoixMedicamentModif
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
            this.cb_medicament = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_medicament
            // 
            this.cb_medicament.FormattingEnabled = true;
            this.cb_medicament.Location = new System.Drawing.Point(177, 183);
            this.cb_medicament.Name = "cb_medicament";
            this.cb_medicament.Size = new System.Drawing.Size(274, 21);
            this.cb_medicament.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choix du médicament";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(177, 241);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(73, 22);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // FchoixMedicamentModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_medicament);
            this.Name = "FchoixMedicamentModif";
            this.Text = "FchoixMedicamentModif";
            this.Load += new System.EventHandler(this.FchoixMedicamentModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_medicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_valider;
    }
}