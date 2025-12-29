namespace Pos_Restaurant.Views.Users
{
    partial class AfficherUserForm
    {
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvUsers = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAjouter = new System.Windows.Forms.Button();
            btnModifier = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            txtRechercher = new System.Windows.Forms.TextBox();
            lblRechercher = new System.Windows.Forms.Label();
            lblNombreResultats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ColumnHeadersHeight = 34;
            dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            colId,
            colUsername,
            colPassword,
            colRole});
            dgvUsers.Location = new System.Drawing.Point(12, 120);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(920, 380);
            dgvUsers.TabIndex = 0;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 80;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Nom d'utilisateur";
            colUsername.MinimumWidth = 8;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 200;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "Password";
            colPassword.HeaderText = "Mot de passe";
            colPassword.MinimumWidth = 8;
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            colPassword.Width = 200;
            // 
            // colRole
            // 
            colRole.DataPropertyName = "Role";
            colRole.HeaderText = "Rôle";
            colRole.MinimumWidth = 8;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 150;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = System.Drawing.Color.RoyalBlue;
            btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAjouter.ForeColor = System.Drawing.Color.White;
            btnAjouter.Location = new System.Drawing.Point(782, 70);
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
            btnModifier.Location = new System.Drawing.Point(626, 70);
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
            btnSupprimer.Location = new System.Drawing.Point(470, 70);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(160, 41);
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
            txtRechercher.PlaceholderText = "🔍 Username ou rôle...";
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
            // AfficherUserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(944, 512);
            Controls.Add(lblNombreResultats);
            Controls.Add(lblRechercher);
            Controls.Add(txtRechercher);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dgvUsers);
            Text = "Liste des utilisateurs";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.Label lblNombreResultats;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
    }
}