namespace ProjetE5C.Presentation.RapportVisite
{
    partial class FChoixRVDate
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
            this.cb_RVDate = new System.Windows.Forms.ComboBox();
            this.cb_ValiderRVDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(220, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche des rapports de visites par date ";
            // 
            // cb_RVDate
            // 
            this.cb_RVDate.FormattingEnabled = true;
            this.cb_RVDate.Location = new System.Drawing.Point(183, 154);
            this.cb_RVDate.Name = "cb_RVDate";
            this.cb_RVDate.Size = new System.Drawing.Size(404, 21);
            this.cb_RVDate.TabIndex = 1;
            this.cb_RVDate.SelectedIndexChanged += new System.EventHandler(this.cb_RVDate_SelectedIndexChanged);
            // 
            // cb_ValiderRVDate
            // 
            this.cb_ValiderRVDate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cb_ValiderRVDate.Location = new System.Drawing.Point(196, 261);
            this.cb_ValiderRVDate.Name = "cb_ValiderRVDate";
            this.cb_ValiderRVDate.Size = new System.Drawing.Size(78, 21);
            this.cb_ValiderRVDate.TabIndex = 2;
            this.cb_ValiderRVDate.Text = "Valider";
            this.cb_ValiderRVDate.UseVisualStyleBackColor = true;
            this.cb_ValiderRVDate.Click += new System.EventHandler(this.cb_ValiderRVDate_Click);
            // 
            // FChoixRVDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_ValiderRVDate);
            this.Controls.Add(this.cb_RVDate);
            this.Controls.Add(this.label1);
            this.Name = "FChoixRVDate";
            this.Text = "FChoixRVDate";
            this.Load += new System.EventHandler(this.FChoixRVDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_RVDate;
        private System.Windows.Forms.Button cb_ValiderRVDate;
    }
}