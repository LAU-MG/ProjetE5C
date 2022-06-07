namespace ProjetE5C.Presentation
{
    partial class FCompoModif
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CompoModif = new System.Windows.Forms.TextBox();
            this.bt_modifCompo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(233, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Composant à modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Composant :";
            // 
            // tb_CompoModif
            // 
            this.tb_CompoModif.Location = new System.Drawing.Point(190, 180);
            this.tb_CompoModif.Name = "tb_CompoModif";
            this.tb_CompoModif.Size = new System.Drawing.Size(270, 20);
            this.tb_CompoModif.TabIndex = 2;
            this.tb_CompoModif.TextChanged += new System.EventHandler(this.tb_CompoModif_TextChanged);
            // 
            // bt_modifCompo
            // 
            this.bt_modifCompo.Location = new System.Drawing.Point(190, 242);
            this.bt_modifCompo.Name = "bt_modifCompo";
            this.bt_modifCompo.Size = new System.Drawing.Size(79, 20);
            this.bt_modifCompo.TabIndex = 3;
            this.bt_modifCompo.Text = "Modifier";
            this.bt_modifCompo.UseVisualStyleBackColor = true;
            this.bt_modifCompo.Click += new System.EventHandler(this.bt_modifCompo_Click);
            // 
            // FCompoModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_modifCompo);
            this.Controls.Add(this.tb_CompoModif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCompoModif";
            this.Text = "FCompoModif";
            this.Load += new System.EventHandler(this.FCompoModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CompoModif;
        private System.Windows.Forms.Button bt_modifCompo;
    }
}