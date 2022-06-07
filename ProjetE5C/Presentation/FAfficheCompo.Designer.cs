namespace ProjetE5C.Presentation
{
    partial class FAfficheCompo
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
            this.dgMedoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.quiiter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMedoc
            // 
            this.dgMedoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMedoc.Location = new System.Drawing.Point(135, 138);
            this.dgMedoc.Name = "dgMedoc";
            this.dgMedoc.Size = new System.Drawing.Size(465, 172);
            this.dgMedoc.TabIndex = 0;
            this.dgMedoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMedoc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(302, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Affichage compo";
            // 
            // quiiter
            // 
            this.quiiter.Location = new System.Drawing.Point(135, 345);
            this.quiiter.Name = "quiiter";
            this.quiiter.Size = new System.Drawing.Size(84, 29);
            this.quiiter.TabIndex = 2;
            this.quiiter.Text = "quitter";
            this.quiiter.UseVisualStyleBackColor = true;
            this.quiiter.Click += new System.EventHandler(this.quiiter_Click);
            // 
            // FAfficheCompo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quiiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMedoc);
            this.Name = "FAfficheCompo";
            this.Text = "FAfficheCompo";
            this.Load += new System.EventHandler(this.FAfficheCompo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMedoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quiiter;
    }
}