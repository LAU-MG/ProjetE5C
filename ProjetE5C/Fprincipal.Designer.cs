namespace ProjetE5C
{
    partial class Fprincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseAJourMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCompoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportVisiteNomPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportVisiteDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_etat = new System.Windows.Forms.Label();
            this.supprimerUnComposantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationEtSuppressionDunMédicamentOffertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.rapportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseAJourMotDePasseToolStripMenuItem,
            this.connexionToolStripMenuItem,
            this.deconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // miseAJourMotDePasseToolStripMenuItem
            // 
            this.miseAJourMotDePasseToolStripMenuItem.Name = "miseAJourMotDePasseToolStripMenuItem";
            this.miseAJourMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.miseAJourMotDePasseToolStripMenuItem.Text = "miseAJourMotDePasse";
            this.miseAJourMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.miseAJourMotDePasseToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listerToolStripMenuItem,
            this.ajoutToolStripMenuItem,
            this.modifierCompoToolStripMenuItem,
            this.supprimerUnComposantToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // listerToolStripMenuItem
            // 
            this.listerToolStripMenuItem.Name = "listerToolStripMenuItem";
            this.listerToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.listerToolStripMenuItem.Text = "ListerMedicamentFam";
            this.listerToolStripMenuItem.Click += new System.EventHandler(this.listerToolStripMenuItem_Click);
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // modifierCompoToolStripMenuItem
            // 
            this.modifierCompoToolStripMenuItem.Name = "modifierCompoToolStripMenuItem";
            this.modifierCompoToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.modifierCompoToolStripMenuItem.Text = "ModifierCompo";
            this.modifierCompoToolStripMenuItem.Click += new System.EventHandler(this.modifierCompoToolStripMenuItem_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutRapportToolStripMenuItem,
            this.rapportVisiteNomPToolStripMenuItem,
            this.rapportVisiteDateToolStripMenuItem,
            this.modificationEtSuppressionDunMédicamentOffertToolStripMenuItem});
            this.rapportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.rapportsToolStripMenuItem.Text = "Rapports";
            this.rapportsToolStripMenuItem.Click += new System.EventHandler(this.rapportsToolStripMenuItem_Click);
            // 
            // ajoutRapportToolStripMenuItem
            // 
            this.ajoutRapportToolStripMenuItem.Name = "ajoutRapportToolStripMenuItem";
            this.ajoutRapportToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ajoutRapportToolStripMenuItem.Text = "AjoutRapport";
            this.ajoutRapportToolStripMenuItem.Click += new System.EventHandler(this.ajoutRapportToolStripMenuItem_Click_1);
            // 
            // rapportVisiteNomPToolStripMenuItem
            // 
            this.rapportVisiteNomPToolStripMenuItem.Name = "rapportVisiteNomPToolStripMenuItem";
            this.rapportVisiteNomPToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.rapportVisiteNomPToolStripMenuItem.Text = "RapportVisiteNomP";
            this.rapportVisiteNomPToolStripMenuItem.Click += new System.EventHandler(this.rapportVisiteNomPToolStripMenuItem_Click);
            // 
            // rapportVisiteDateToolStripMenuItem
            // 
            this.rapportVisiteDateToolStripMenuItem.Name = "rapportVisiteDateToolStripMenuItem";
            this.rapportVisiteDateToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.rapportVisiteDateToolStripMenuItem.Text = "RapportVisiteDate";
            this.rapportVisiteDateToolStripMenuItem.Click += new System.EventHandler(this.rapportVisiteDateToolStripMenuItem_Click);
            // 
            // lb_etat
            // 
            this.lb_etat.AutoSize = true;
            this.lb_etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_etat.ForeColor = System.Drawing.Color.Red;
            this.lb_etat.Location = new System.Drawing.Point(645, 394);
            this.lb_etat.Name = "lb_etat";
            this.lb_etat.Size = new System.Drawing.Size(126, 20);
            this.lb_etat.TabIndex = 1;
            this.lb_etat.Text = "Non connecter";
            // 
            // supprimerUnComposantToolStripMenuItem
            // 
            this.supprimerUnComposantToolStripMenuItem.Name = "supprimerUnComposantToolStripMenuItem";
            this.supprimerUnComposantToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.supprimerUnComposantToolStripMenuItem.Text = "Supprimer un composant";
            this.supprimerUnComposantToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnComposantToolStripMenuItem_Click);
            // 
            // modificationEtSuppressionDunMédicamentOffertToolStripMenuItem
            // 
            this.modificationEtSuppressionDunMédicamentOffertToolStripMenuItem.Name = "modificationEtSuppressionDunMédicamentOffertToolStripMenuItem";
            this.modificationEtSuppressionDunMédicamentOffertToolStripMenuItem.Size = new System.Drawing.Size(439, 26);
            this.modificationEtSuppressionDunMédicamentOffertToolStripMenuItem.Text = "Modification et suppression d\'un médicament offert";
            this.modificationEtSuppressionDunMédicamentOffertToolStripMenuItem.Click += new System.EventHandler(this.modificationEtSuppressionDunMédicamentOffertToolStripMenuItem_Click);
            // 
            // Fprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_etat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fprincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseAJourMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label lb_etat;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCompoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportVisiteNomPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportVisiteDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnComposantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationEtSuppressionDunMédicamentOffertToolStripMenuItem;
    }
}

