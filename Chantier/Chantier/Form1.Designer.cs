namespace Chantier
{
    partial class Form1
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
            this.lstChantiers = new System.Windows.Forms.ListBox();
            this.btnSelectSite = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.lblAddressSite = new System.Windows.Forms.Label();
            this.lblCitySite = new System.Windows.Forms.Label();
            this.lblSizeSite = new System.Windows.Forms.Label();
            this.txtAddressSite = new System.Windows.Forms.TextBox();
            this.txtCitySite = new System.Windows.Forms.TextBox();
            this.txtSizeSite = new System.Windows.Forms.TextBox();
            this.grpAddSite = new System.Windows.Forms.GroupBox();
            this.grpAddSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstChantiers
            // 
            this.lstChantiers.FormattingEnabled = true;
            this.lstChantiers.Location = new System.Drawing.Point(413, 30);
            this.lstChantiers.Name = "lstChantiers";
            this.lstChantiers.Size = new System.Drawing.Size(277, 251);
            this.lstChantiers.TabIndex = 0;
            // 
            // btnSelectSite
            // 
            this.btnSelectSite.Location = new System.Drawing.Point(413, 287);
            this.btnSelectSite.Name = "btnSelectSite";
            this.btnSelectSite.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSite.TabIndex = 1;
            this.btnSelectSite.Text = "Sélectionner";
            this.btnSelectSite.UseVisualStyleBackColor = true;
            this.btnSelectSite.Click += new System.EventHandler(this.btnSelectSite_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.Location = new System.Drawing.Point(20, 154);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(75, 23);
            this.btnAddSite.TabIndex = 2;
            this.btnAddSite.Text = "Ajouter";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // lblAddressSite
            // 
            this.lblAddressSite.AutoSize = true;
            this.lblAddressSite.Location = new System.Drawing.Point(33, 25);
            this.lblAddressSite.Name = "lblAddressSite";
            this.lblAddressSite.Size = new System.Drawing.Size(101, 13);
            this.lblAddressSite.TabIndex = 3;
            this.lblAddressSite.Text = "Adresse du chantier";
            // 
            // lblCitySite
            // 
            this.lblCitySite.AutoSize = true;
            this.lblCitySite.Location = new System.Drawing.Point(52, 55);
            this.lblCitySite.Name = "lblCitySite";
            this.lblCitySite.Size = new System.Drawing.Size(82, 13);
            this.lblCitySite.TabIndex = 4;
            this.lblCitySite.Text = "Ville du chantier";
            // 
            // lblSizeSite
            // 
            this.lblSizeSite.AutoSize = true;
            this.lblSizeSite.Location = new System.Drawing.Point(17, 81);
            this.lblSizeSite.Name = "lblSizeSite";
            this.lblSizeSite.Size = new System.Drawing.Size(117, 13);
            this.lblSizeSite.TabIndex = 5;
            this.lblSizeSite.Text = "Taille du chantier (km2)";
            // 
            // txtAddressSite
            // 
            this.txtAddressSite.Location = new System.Drawing.Point(158, 22);
            this.txtAddressSite.Name = "txtAddressSite";
            this.txtAddressSite.Size = new System.Drawing.Size(100, 20);
            this.txtAddressSite.TabIndex = 6;
            // 
            // txtCitySite
            // 
            this.txtCitySite.Location = new System.Drawing.Point(158, 48);
            this.txtCitySite.Name = "txtCitySite";
            this.txtCitySite.Size = new System.Drawing.Size(100, 20);
            this.txtCitySite.TabIndex = 7;
            // 
            // txtSizeSite
            // 
            this.txtSizeSite.Location = new System.Drawing.Point(158, 74);
            this.txtSizeSite.Name = "txtSizeSite";
            this.txtSizeSite.Size = new System.Drawing.Size(100, 20);
            this.txtSizeSite.TabIndex = 8;
            // 
            // grpAddSite
            // 
            this.grpAddSite.Controls.Add(this.txtSizeSite);
            this.grpAddSite.Controls.Add(this.btnAddSite);
            this.grpAddSite.Controls.Add(this.lblAddressSite);
            this.grpAddSite.Controls.Add(this.txtCitySite);
            this.grpAddSite.Controls.Add(this.lblCitySite);
            this.grpAddSite.Controls.Add(this.txtAddressSite);
            this.grpAddSite.Controls.Add(this.lblSizeSite);
            this.grpAddSite.Location = new System.Drawing.Point(23, 30);
            this.grpAddSite.Name = "grpAddSite";
            this.grpAddSite.Size = new System.Drawing.Size(299, 204);
            this.grpAddSite.TabIndex = 9;
            this.grpAddSite.TabStop = false;
            this.grpAddSite.Text = "Ajout d\'un chantier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAddSite);
            this.Controls.Add(this.btnSelectSite);
            this.Controls.Add(this.lstChantiers);
            this.Name = "Form1";
            this.Text = "Chantier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddSite.ResumeLayout(false);
            this.grpAddSite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstChantiers;
        private System.Windows.Forms.Button btnSelectSite;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Label lblAddressSite;
        private System.Windows.Forms.Label lblCitySite;
        private System.Windows.Forms.Label lblSizeSite;
        private System.Windows.Forms.TextBox txtAddressSite;
        private System.Windows.Forms.TextBox txtCitySite;
        private System.Windows.Forms.TextBox txtSizeSite;
        private System.Windows.Forms.GroupBox grpAddSite;
    }
}

