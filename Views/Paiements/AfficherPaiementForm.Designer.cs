namespace Pos_Restaurant.Views.Paiements
{
    partial class AfficherPaiementForm
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
            dgvPaiements = new System.Windows.Forms.DataGridView();
            txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtIdCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtDatePaiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtModePaiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAjouter = new System.Windows.Forms.Button();
            btnModifier = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            txtRechercher = new System.Windows.Forms.TextBox();
            lblRechercher = new System.Windows.Forms.Label();
            lblNombreResultats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvPaiements).BeginInit();
            SuspendLayout();
            // 
            // dgvPaiements
            // 
            dgvPaiements.AllowUserToAddRows = false;
            dgvPaiements.ColumnHeadersHeight = 34;
            dgvPaiements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { txtId, txtIdCommande, txtMontant, txtDatePaiement, txtModePaiement });
            dgvPaiements.Location = new System.Drawing.Point(12, 120);
            dgvPaiements.Name = "dgvPaiements";
            dgvPaiements.ReadOnly = true;
            dgvPaiements.RowHeadersWidth = 62;
            dgvPaiements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPaiements.Size = new System.Drawing.Size(943, 350);
            dgvPaiements.TabIndex = 0;
            dgvPaiements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // txtId
            // 
            txtId.DataPropertyName = "Id";
            txtId.HeaderText = "ID";
            txtId.MinimumWidth = 8;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Width = 80;
            // 
            // txtIdCommande
            // 
            txtIdCommande.DataPropertyName = "IdCommande";
            txtIdCommande.HeaderText = "ID Com.";
            txtIdCommande.MinimumWidth = 8;
            txtIdCommande.Name = "txtIdCommande";
            txtIdCommande.ReadOnly = true;
            txtIdCommande.Width = 120;
            // 
            // txtMontant
            // 
            txtMontant.DataPropertyName = "Montant";
            txtMontant.HeaderText = "Montant (HTG)";
            txtMontant.MinimumWidth = 8;
            txtMontant.Name = "txtMontant";
            txtMontant.ReadOnly = true;
            txtMontant.Width = 150;
            // 
            // txtDatePaiement
            // 
            txtDatePaiement.DataPropertyName = "DatePaiement";
            txtDatePaiement.HeaderText = "Date Paiement";
            txtDatePaiement.MinimumWidth = 8;
            txtDatePaiement.Name = "txtDatePaiement";
            txtDatePaiement.ReadOnly = true;
            txtDatePaiement.Width = 150;
            // 
            // txtModePaiement
            // 
            txtModePaiement.DataPropertyName = "ModePaiement";
            txtModePaiement.HeaderText = "Mode Paiement";
            txtModePaiement.MinimumWidth = 8;
            txtModePaiement.Name = "txtModePaiement";
            txtModePaiement.ReadOnly = true;
            txtModePaiement.Width = 150;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = System.Drawing.Color.RoyalBlue;
            btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAjouter.ForeColor = System.Drawing.Color.White;
            btnAjouter.Location = new System.Drawing.Point(800, 70);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(152, 41);
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
            btnModifier.Size = new System.Drawing.Size(152, 41);
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
            btnSupprimer.Location = new System.Drawing.Point(484, 70);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(152, 41);
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
            txtRechercher.PlaceholderText = "ID, ID Commande, montant, mode...";
            txtRechercher.Size = new System.Drawing.Size(400, 34);
            txtRechercher.TabIndex = 1;
            txtRechercher.TextChanged += txtRechercher_TextChanged;
            // 
            // lblRechercher
            // 
            lblRechercher.AutoSize = true;
            lblRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblRechercher.Location = new System.Drawing.Point(12, 42);
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
            lblNombreResultats.Size = new System.Drawing.Size(0, 25);
            lblNombreResultats.TabIndex = 6;
            // 
            // AfficherPaiementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(964, 482);
            Controls.Add(lblNombreResultats);
            Controls.Add(lblRechercher);
            Controls.Add(txtRechercher);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dgvPaiements);
            Text = "Liste des paiements";
            ((System.ComponentModel.ISupportInitialize)dgvPaiements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaiements;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.Label lblNombreResultats;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDatePaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtModePaiement;
    }
}