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
            this.tb_CompoModif = new System.Windows.Forms.TextBox();
            this.bt_ModifCompo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tb_CompoModif
            // 
            this.tb_CompoModif.Location = new System.Drawing.Point(162, 139);
            this.tb_CompoModif.Name = "tb_CompoModif";
            this.tb_CompoModif.Size = new System.Drawing.Size(350, 20);
            this.tb_CompoModif.TabIndex = 1;
            this.tb_CompoModif.TextChanged += new System.EventHandler(this.tb_CompoModif_TextChanged);
            // 
            // bt_ModifCompo
            // 
            this.bt_ModifCompo.Location = new System.Drawing.Point(162, 250);
            this.bt_ModifCompo.Name = "bt_ModifCompo";
            this.bt_ModifCompo.Size = new System.Drawing.Size(100, 26);
            this.bt_ModifCompo.TabIndex = 2;
            this.bt_ModifCompo.Text = "Modifier";
            this.bt_ModifCompo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // FAffichageCompo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_ModifCompo);
            this.Controls.Add(this.tb_CompoModif);
            this.Controls.Add(this.label1);
            this.Name = "FAffichageCompo";
            this.Text = "FAffichageCompo";
            this.Load += new System.EventHandler(this.FAffichageCompo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CompoModif;
        private System.Windows.Forms.Button bt_ModifCompo;
        private System.Windows.Forms.Label label2;
    }
}