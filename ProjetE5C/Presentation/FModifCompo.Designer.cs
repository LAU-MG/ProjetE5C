namespace ProjetE5C.Presentation
{
    partial class FModifCompo
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
            this.label4 = new System.Windows.Forms.Label();
            this.cb_MedModif = new System.Windows.Forms.ComboBox();
            this.btModifCompo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification d\'un médicament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Médicaments";
            // 
            // cb_MedModif
            // 
            this.cb_MedModif.FormattingEnabled = true;
            this.cb_MedModif.Location = new System.Drawing.Point(209, 116);
            this.cb_MedModif.Name = "cb_MedModif";
            this.cb_MedModif.Size = new System.Drawing.Size(276, 21);
            this.cb_MedModif.TabIndex = 6;
            this.cb_MedModif.SelectedIndexChanged += new System.EventHandler(this.cb_MedModif_SelectedIndexChanged);
            // 
            // btModifCompo
            // 
            this.btModifCompo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btModifCompo.Location = new System.Drawing.Point(209, 185);
            this.btModifCompo.Name = "btModifCompo";
            this.btModifCompo.Size = new System.Drawing.Size(65, 23);
            this.btModifCompo.TabIndex = 7;
            this.btModifCompo.Text = "Valider";
            this.btModifCompo.UseVisualStyleBackColor = true;
            this.btModifCompo.Click += new System.EventHandler(this.btModifCompo_Click);
            // 
            // FModifCompo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btModifCompo);
            this.Controls.Add(this.cb_MedModif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FModifCompo";
            this.Text = "FModifCompo";
            this.Load += new System.EventHandler(this.FModifCompo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_MedModif;
        private System.Windows.Forms.Button btModifCompo;
    }
}