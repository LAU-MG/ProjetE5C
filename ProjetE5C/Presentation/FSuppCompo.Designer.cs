namespace ProjetE5C.Presentation
{
    partial class FSuppCompo
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.cb_compo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_valider.Location = new System.Drawing.Point(145, 210);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(71, 25);
            this.btn_valider.TabIndex = 0;
            this.btn_valider.Text = "valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // cb_compo
            // 
            this.cb_compo.FormattingEnabled = true;
            this.cb_compo.Location = new System.Drawing.Point(166, 134);
            this.cb_compo.Name = "cb_compo";
            this.cb_compo.Size = new System.Drawing.Size(282, 21);
            this.cb_compo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suppression d\'un composant d\'un médicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choix du composant :";
            // 
            // FSuppCompo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_compo);
            this.Controls.Add(this.btn_valider);
            this.Name = "FSuppCompo";
            this.Text = "FSuppCompo";
            this.Load += new System.EventHandler(this.FSuppCompo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.ComboBox cb_compo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}