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
            this.txtWorkers = new System.Windows.Forms.TextBox();
            this.lblWorkers = new System.Windows.Forms.Label();
            this.txtChantiers = new System.Windows.Forms.TextBox();
            this.lblConstructionSites = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbVehicles = new System.Windows.Forms.TextBox();
            this.txtNbTruks = new System.Windows.Forms.TextBox();
            this.txtNbCranes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAvailablePlaces = new System.Windows.Forms.TextBox();
            this.cmdNewConstructionSite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWorkers
            // 
            this.txtWorkers.Location = new System.Drawing.Point(92, 61);
            this.txtWorkers.Multiline = true;
            this.txtWorkers.Name = "txtWorkers";
            this.txtWorkers.Size = new System.Drawing.Size(162, 212);
            this.txtWorkers.TabIndex = 0;
            // 
            // lblWorkers
            // 
            this.lblWorkers.AutoSize = true;
            this.lblWorkers.Location = new System.Drawing.Point(89, 16);
            this.lblWorkers.Name = "lblWorkers";
            this.lblWorkers.Size = new System.Drawing.Size(64, 13);
            this.lblWorkers.TabIndex = 2;
            this.lblWorkers.Text = "Travailleurs ";
            this.lblWorkers.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtChantiers
            // 
            this.txtChantiers.Location = new System.Drawing.Point(338, 61);
            this.txtChantiers.Multiline = true;
            this.txtChantiers.Name = "txtChantiers";
            this.txtChantiers.Size = new System.Drawing.Size(162, 212);
            this.txtChantiers.TabIndex = 4;
            // 
            // lblConstructionSites
            // 
            this.lblConstructionSites.AutoSize = true;
            this.lblConstructionSites.Location = new System.Drawing.Point(335, 16);
            this.lblConstructionSites.Name = "lblConstructionSites";
            this.lblConstructionSites.Size = new System.Drawing.Size(51, 13);
            this.lblConstructionSites.TabIndex = 5;
            this.lblConstructionSites.Text = "Chantiers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voitures :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Camions :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grues :";
            // 
            // txtNbVehicles
            // 
            this.txtNbVehicles.Location = new System.Drawing.Point(600, 87);
            this.txtNbVehicles.Name = "txtNbVehicles";
            this.txtNbVehicles.Size = new System.Drawing.Size(49, 20);
            this.txtNbVehicles.TabIndex = 9;
            // 
            // txtNbTruks
            // 
            this.txtNbTruks.Location = new System.Drawing.Point(600, 120);
            this.txtNbTruks.Name = "txtNbTruks";
            this.txtNbTruks.Size = new System.Drawing.Size(49, 20);
            this.txtNbTruks.TabIndex = 10;
            // 
            // txtNbCranes
            // 
            this.txtNbCranes.Location = new System.Drawing.Point(600, 152);
            this.txtNbCranes.Name = "txtNbCranes";
            this.txtNbCranes.Size = new System.Drawing.Size(49, 20);
            this.txtNbCranes.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Places disponibles dans le parking";
            // 
            // txtAvailablePlaces
            // 
            this.txtAvailablePlaces.Location = new System.Drawing.Point(600, 215);
            this.txtAvailablePlaces.Name = "txtAvailablePlaces";
            this.txtAvailablePlaces.Size = new System.Drawing.Size(49, 20);
            this.txtAvailablePlaces.TabIndex = 13;
            // 
            // cmdNewConstructionSite
            // 
            this.cmdNewConstructionSite.Location = new System.Drawing.Point(338, 288);
            this.cmdNewConstructionSite.Name = "cmdNewConstructionSite";
            this.cmdNewConstructionSite.Size = new System.Drawing.Size(162, 23);
            this.cmdNewConstructionSite.TabIndex = 14;
            this.cmdNewConstructionSite.Text = "Noveau Chantier";
            this.cmdNewConstructionSite.UseVisualStyleBackColor = true;
            this.cmdNewConstructionSite.Click += new System.EventHandler(this.cmdNewConstructionSite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 393);
            this.Controls.Add(this.cmdNewConstructionSite);
            this.Controls.Add(this.txtAvailablePlaces);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNbCranes);
            this.Controls.Add(this.txtNbTruks);
            this.Controls.Add(this.txtNbVehicles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConstructionSites);
            this.Controls.Add(this.txtChantiers);
            this.Controls.Add(this.lblWorkers);
            this.Controls.Add(this.txtWorkers);
            this.Name = "Form1";
            this.Text = "Entreprise de chantiers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWorkers;
        private System.Windows.Forms.Label lblWorkers;
        private System.Windows.Forms.TextBox txtChantiers;
        private System.Windows.Forms.Label lblConstructionSites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNbVehicles;
        private System.Windows.Forms.TextBox txtNbTruks;
        private System.Windows.Forms.TextBox txtNbCranes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAvailablePlaces;
        private System.Windows.Forms.Button cmdNewConstructionSite;
    }
}

