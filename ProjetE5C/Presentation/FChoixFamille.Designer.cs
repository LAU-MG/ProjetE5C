namespace ProjetE5C.Presentation
{
    partial class FChoixFamille
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
            this.cb_Famille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Famille
            // 
            this.cb_Famille.FormattingEnabled = true;
            this.cb_Famille.Location = new System.Drawing.Point(236, 159);
            this.cb_Famille.Name = "cb_Famille";
            this.cb_Famille.Size = new System.Drawing.Size(320, 21);
            this.cb_Famille.TabIndex = 0;
            this.cb_Famille.SelectedIndexChanged += new System.EventHandler(this.cb_Famille_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choix famille des médicaments";
            // 
            // bt_Valider
            // 
            this.bt_Valider.Location = new System.Drawing.Point(79, 377);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(80, 21);
            this.bt_Valider.TabIndex = 2;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = true;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // FChoixFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Famille);
            this.Name = "FChoixFamille";
            this.Text = "FChoixFamille";
            this.Load += new System.EventHandler(this.FChoixFamille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Famille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Valider;
    }
}