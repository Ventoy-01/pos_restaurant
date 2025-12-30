namespace Pos_Restaurant.Views.Commandes
{
    partial class AfficherCommandeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvCommandes = new System.Windows.Forms.DataGridView();
            txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtIdMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtNomMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtPrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAjouter = new System.Windows.Forms.Button();
            btnModifier = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            txtRechercher = new System.Windows.Forms.TextBox();
            lblRechercher = new System.Windows.Forms.Label();
            lblNombreResultats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            SuspendLayout();
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.ColumnHeadersHeight = 34;
            dgvCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            txtId,
            txtIdMenu,
            txtNomMenu,
            txtType,
            txtIdClient,
            txtNomClient,
            txtPrix,
            txtQuantite,
            txtPrixTotal,
            txtDescription});
            dgvCommandes.Location = new System.Drawing.Point(12, 120);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.RowHeadersWidth = 62;
            dgvCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCommandes.Size = new System.Drawing.Size(1050, 350);
            dgvCommandes.TabIndex = 0;
            dgvCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // txtId
            // 
            txtId.DataPropertyName = "Id";
            txtId.HeaderText = "ID";
            txtId.MinimumWidth = 8;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            // 
            // txtIdMenu
            // 
            txtIdMenu.DataPropertyName = "IdMenu";
            txtIdMenu.HeaderText = "ID Menu";
            txtIdMenu.MinimumWidth = 8;
            txtIdMenu.Name = "txtIdMenu";
            txtIdMenu.ReadOnly = true;
            // 
            // txtNomMenu
            // 
            txtNomMenu.DataPropertyName = "NomMenu";
            txtNomMenu.HeaderText = "Nom Menu";
            txtNomMenu.MinimumWidth = 8;
            txtNomMenu.Name = "txtNomMenu";
            txtNomMenu.ReadOnly = true;
            // 
            // txtType
            // 
            txtType.DataPropertyName = "Type";
            txtType.HeaderText = "Type";
            txtType.MinimumWidth = 8;
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            // 
            // txtIdClient
            // 
            txtIdClient.DataPropertyName = "IdClient";
            txtIdClient.HeaderText = "ID Client";
            txtIdClient.MinimumWidth = 8;
            txtIdClient.Name = "txtIdClient";
            txtIdClient.ReadOnly = true;
            // 
            // txtNomClient
            // 
            txtNomClient.DataPropertyName = "NomClient";
            txtNomClient.HeaderText = "Nom Client";
            txtNomClient.MinimumWidth = 8;
            txtNomClient.Name = "txtNomClient";
            txtNomClient.ReadOnly = true;
            // 
            // txtPrix
            // 
            txtPrix.DataPropertyName = "PrixUnitaire";
            txtPrix.HeaderText = "Prix (HTG)";
            txtPrix.MinimumWidth = 8;
            txtPrix.Name = "txtPrix";
            txtPrix.ReadOnly = true;
            // 
            // txtQuantite
            // 
            txtQuantite.DataPropertyName = "Quantite";
            txtQuantite.HeaderText = "Quantité";
            txtQuantite.MinimumWidth = 8;
            txtQuantite.Name = "txtQuantite";
            txtQuantite.ReadOnly = true;
            
            // txtQuantite.Maximum = 10000;
            // 
            // txtPrixTotal
            // 
            txtPrixTotal.DataPropertyName = "PrixTotal";
            txtPrixTotal.HeaderText = "Prix Total (HTG)";
            txtPrixTotal.MinimumWidth = 8;
            txtPrixTotal.Name = "txtPrixTotal";
            txtPrixTotal.ReadOnly = true;
            // 
            // txtDescription
            // 
            txtDescription.DataPropertyName = "Description";
            txtDescription.HeaderText = "Description";
            txtDescription.MinimumWidth = 8;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.FillWeight = 150;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = System.Drawing.Color.RoyalBlue;
            btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAjouter.ForeColor = System.Drawing.Color.White;
            btnAjouter.Location = new System.Drawing.Point(798, 70);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(150, 41);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "➕ Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = System.Drawing.Color.Gold;
            btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnModifier.ForeColor = System.Drawing.Color.Black;
            btnModifier.Location = new System.Drawing.Point(642, 70);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new System.Drawing.Size(150, 41);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "✏️ Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = System.Drawing.Color.Crimson;
            btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnSupprimer.ForeColor = System.Drawing.Color.White;
            btnSupprimer.Location = new System.Drawing.Point(486, 70);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(150, 41);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "🗑️ Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // txtRechercher
            // 
            txtRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtRechercher.Location = new System.Drawing.Point(12, 75);
            txtRechercher.Name = "txtRechercher";
            txtRechercher.PlaceholderText = "🔍 Nom menu, client, type...";
            txtRechercher.Size = new System.Drawing.Size(400, 34);
            txtRechercher.TabIndex = 1;
            txtRechercher.TextChanged += txtRechercher_TextChanged;
            // 
            // lblRechercher
            // 
            lblRechercher.AutoSize = true;
            lblRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblRechercher.Location = new System.Drawing.Point(12, 40);
            lblRechercher.Name = "lblRechercher";
            lblRechercher.Size = new System.Drawing.Size(116, 28);
            lblRechercher.TabIndex = 5;
            lblRechercher.Text = "Rechercher :";
            // 
            // lblNombreResultats
            // 
            lblNombreResultats.AutoSize = true;
            lblNombreResultats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblNombreResultats.ForeColor = System.Drawing.Color.RoyalBlue;
            lblNombreResultats.Location = new System.Drawing.Point(420, 380);
            lblNombreResultats.Name = "lblNombreResultats";
            lblNombreResultats.Size = new System.Drawing.Size(0, 35);
            lblNombreResultats.TabIndex = 6;
            // 
            // AfficherCommandeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(960, 462);
            Controls.Add(lblNombreResultats);
            Controls.Add(lblRechercher);
            Controls.Add(txtRechercher);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(dgvCommandes);
            Text = "Liste des Commandes";
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ResumeLayout(false);
            PerformLayout();
            
            
        }
        
        #endregion

        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.Label lblNombreResultats;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNomMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrixTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescription;
        
    }
}