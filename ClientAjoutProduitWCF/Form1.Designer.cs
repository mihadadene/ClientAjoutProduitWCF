namespace ClientAjoutProduitWCF
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
            this.lbNom = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTitre = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(49, 117);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(110, 17);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom du Produit:";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Location = new System.Drawing.Point(49, 174);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(141, 17);
            this.lbQty.TabIndex = 1;
            this.lbQty.Text = "Quantitées à ajouter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix du produit:";
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(33, 28);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(620, 29);
            this.lbTitre.TabIndex = 3;
            this.lbTitre.Text = "Inscrire les produit que vous desirer mettre en vente";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(233, 122);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(367, 22);
            this.tbNom.TabIndex = 4;
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(233, 174);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(367, 22);
            this.tbQty.TabIndex = 5;
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(233, 225);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(367, 22);
            this.tbPrix.TabIndex = 6;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(465, 280);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(135, 23);
            this.bt_ajouter.TabIndex = 7;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.lbNom);
            this.Name = "Form1";
            this.Text = "Fenetre d\'ajout Produits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Button bt_ajouter;
    }
}

