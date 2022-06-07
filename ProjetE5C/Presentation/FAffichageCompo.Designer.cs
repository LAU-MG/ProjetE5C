namespace ProjetE5C.Presentation
{
    partial class FAffichageCompo
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
            this.bt_Valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_compo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un composant";
            // 
            // bt_Valider
            // 
            this.bt_Valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Valider.Location = new System.Drawing.Point(339, 220);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(100, 26);
            this.bt_Valider.TabIndex = 2;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = true;
            this.bt_Valider.Click += new System.EventHandler(this.bt_ModifCompo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Composant : ";
            // 
            // cb_compo
            // 
            this.cb_compo.FormattingEnabled = true;
            this.cb_compo.Location = new System.Drawing.Point(152, 139);
            this.cb_compo.Name = "cb_compo";
            this.cb_compo.Size = new System.Drawing.Size(287, 21);
            this.cb_compo.TabIndex = 4;
            this.cb_compo.SelectedIndexChanged += new System.EventHandler(this.cb_compo_SelectedIndexChanged);
            // 
            // FAffichageCompo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 295);
            this.Controls.Add(this.cb_compo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Valider);
            this.Controls.Add(this.label1);
            this.Name = "FAffichageCompo";
            this.Text = "FAffichageCompo";
            this.Load += new System.EventHandler(this.FAffichageCompo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_compo;
    }
}