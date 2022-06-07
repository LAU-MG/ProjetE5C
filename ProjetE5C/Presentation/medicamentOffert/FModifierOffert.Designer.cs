namespace ProjetE5C.Presentation.medicamentOffert
{
    partial class FModifierOffert
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.tb_quantite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "modifier le rapport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantité offerte";
            // 
            // btn_valider
            // 
            this.btn_valider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_valider.Location = new System.Drawing.Point(238, 262);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 3;
            this.btn_valider.Text = "valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // tb_quantite
            // 
            this.tb_quantite.Location = new System.Drawing.Point(218, 173);
            this.tb_quantite.Name = "tb_quantite";
            this.tb_quantite.Size = new System.Drawing.Size(216, 20);
            this.tb_quantite.TabIndex = 4;
            // 
            // FModifierOffert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_quantite);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FModifierOffert";
            this.Text = "FModifierOffert";
            this.Load += new System.EventHandler(this.FModifierOffert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox tb_quantite;
    }
}