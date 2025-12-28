namespace Pos_Restaurant.Views.Clients
{
    partial class AfficherClientForm
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
            dgvClients = new System.Windows.Forms.DataGridView();
            txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtMontantDette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAjouter = new System.Windows.Forms.Button();
            btnModifier = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            txtRechercher = new System.Windows.Forms.TextBox();
            lblRechercher = new System.Windows.Forms.Label();
            lblMessageRecherche = new System.Windows.Forms.Label();
            lblNombreResultats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.ColumnHeadersHeight = 34;
            dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { txtId, txtNom, txtPrenom, txtSexe, txtTelephone, txtEmail, txtMontantDette });
            dgvClients.Location = new System.Drawing.Point(12, 120);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersWidth = 62;
            dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new System.Drawing.Size(1029, 380);
            dgvClients.TabIndex = 0;
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
            // txtNom
            // 
            txtNom.DataPropertyName = "Nom";
            txtNom.HeaderText = "Nom";
            txtNom.MinimumWidth = 8;
            txtNom.Name = "txtNom";
            txtNom.ReadOnly = true;
            txtNom.Width = 150;
            // 
            // txtPrenom
            // 
            txtPrenom.DataPropertyName = "Prenom";
            txtPrenom.HeaderText = "Prénom";
            txtPrenom.MinimumWidth = 8;
            txtPrenom.Name = "txtPrenom";
            txtPrenom.ReadOnly = true;
            txtPrenom.Width = 150;
            // 
            // txtSexe
            // 
            txtSexe.DataPropertyName = "Sexe";
            txtSexe.HeaderText = "Sexe";
            txtSexe.MinimumWidth = 8;
            txtSexe.Name = "txtSexe";
            txtSexe.ReadOnly = true;
            txtSexe.Width = 100;
            // 
            // txtTelephone
            // 
            txtTelephone.DataPropertyName = "Telephone";
            txtTelephone.HeaderText = "Téléphone";
            txtTelephone.MinimumWidth = 8;
            txtTelephone.Name = "txtTelephone";
            txtTelephone.ReadOnly = true;
            txtTelephone.Width = 150;
            // 
            // txtEmail
            // 
            txtEmail.DataPropertyName = "Email";
            txtEmail.HeaderText = "Email";
            txtEmail.MinimumWidth = 8;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Width = 200;
            // 
            // txtMontantDette
            // 
            txtMontantDette.DataPropertyName = "MontantDette";
            txtMontantDette.HeaderText = "Montant Dette (HTG)";
            txtMontantDette.MinimumWidth = 8;
            txtMontantDette.Name = "txtMontantDette";
            txtMontantDette.ReadOnly = true;
            txtMontantDette.Width = 150;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = System.Drawing.Color.RoyalBlue;
            btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAjouter.ForeColor = System.Drawing.Color.White;
            btnAjouter.Location = new System.Drawing.Point(850, 70);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(150, 41);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = System.Drawing.Color.Gold;
            btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnModifier.ForeColor = System.Drawing.Color.Black;
            btnModifier.Location = new System.Drawing.Point(694, 70);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new System.Drawing.Size(150, 41);
            btnModifier.TabIndex = 3;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = System.Drawing.Color.Crimson;
            btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnSupprimer.ForeColor = System.Drawing.Color.White;
            btnSupprimer.Location = new System.Drawing.Point(538, 70);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(150, 41);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // txtRechercher
            // 
            txtRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtRechercher.Location = new System.Drawing.Point(12, 75);
            txtRechercher.Name = "txtRechercher";
            txtRechercher.PlaceholderText = "ID, Nom, prénom, tél ou email...";
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
            // lblMessageRecherche
            // 
            lblMessageRecherche.AutoSize = true;
            lblMessageRecherche.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMessageRecherche.ForeColor = System.Drawing.Color.Gray;
            lblMessageRecherche.Location = new System.Drawing.Point(12, 503);
            lblMessageRecherche.Name = "lblMessageRecherche";
            lblMessageRecherche.Size = new System.Drawing.Size(0, 25);
            lblMessageRecherche.TabIndex = 6;
            lblMessageRecherche.Visible = false;
            // 
            // lblNombreResultats
            // 
            lblNombreResultats.AutoSize = true;
            lblNombreResultats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblNombreResultats.ForeColor = System.Drawing.Color.RoyalBlue;
            lblNombreResultats.Location = new System.Drawing.Point(420, 480);
            lblNombreResultats.Name = "lblNombreResultats";
            lblNombreResultats.Size = new System.Drawing.Size(0, 25);
            lblNombreResultats.TabIndex = 7;
            // 
            // AfficherClientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1053, 537);
            Controls.Add(lblNombreResultats);
            Controls.Add(lblMessageRecherche);
            Controls.Add(lblRechercher);
            Controls.Add(txtRechercher);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dgvClients);
            Text = "Liste des clients";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.Label lblMessageRecherche;
        private System.Windows.Forms.Label lblNombreResultats;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMontantDette;
    }
}