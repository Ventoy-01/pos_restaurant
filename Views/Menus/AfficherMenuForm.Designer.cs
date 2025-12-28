namespace Pos_Restaurant.Views.Menus
{
    partial class AfficherMenuForm
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
            dgvMenus = new System.Windows.Forms.DataGridView();
            txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAjouter = new System.Windows.Forms.Button();
            btnModifier = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            txtRechercher = new System.Windows.Forms.TextBox();
            lblRechercher = new System.Windows.Forms.Label();
            lblNombreResultats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvMenus).BeginInit();
            SuspendLayout();
            // 
            // dgvMenus
            // 
            dgvMenus.AllowUserToAddRows = false;
            dgvMenus.ColumnHeadersHeight = 34;
            dgvMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { txtId, txtNom, txtType, txtPrix, txtQuantite, txtDescription });
            dgvMenus.Location = new System.Drawing.Point(12, 120);
            dgvMenus.Name = "dgvMenus";
            dgvMenus.ReadOnly = true;
            dgvMenus.RowHeadersWidth = 62;
            dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMenus.Size = new System.Drawing.Size(943, 328);
            dgvMenus.TabIndex = 0;
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
            // txtType
            // 
            txtType.DataPropertyName = "Type";
            txtType.HeaderText = "Type";
            txtType.MinimumWidth = 8;
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Width = 120;
            // 
            // txtPrix
            // 
            txtPrix.DataPropertyName = "PrixUnitaire";
            txtPrix.HeaderText = "Prix Unitaire (HTG)";
            txtPrix.MinimumWidth = 8;
            txtPrix.Name = "txtPrix";
            txtPrix.ReadOnly = true;
            txtPrix.Width = 130;
            // 
            // txtQuantite
            // 
            txtQuantite.DataPropertyName = "Quantite";
            txtQuantite.HeaderText = "Quantité";
            txtQuantite.MinimumWidth = 8;
            txtQuantite.Name = "txtQuantite";
            txtQuantite.ReadOnly = true;
            txtQuantite.Width = 100;
            // 
            // txtDescription
            // 
            txtDescription.DataPropertyName = "Description";
            txtDescription.HeaderText = "Description";
            txtDescription.MinimumWidth = 8;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Width = 300;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = System.Drawing.Color.RoyalBlue;
            btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAjouter.ForeColor = System.Drawing.Color.White;
            btnAjouter.Location = new System.Drawing.Point(800, 70);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(155, 41);
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
            btnModifier.Location = new System.Drawing.Point(639, 70);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new System.Drawing.Size(155, 41);
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
            btnSupprimer.Location = new System.Drawing.Point(478, 70);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(155, 41);
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
            txtRechercher.PlaceholderText = "Nom, type ou description...";
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
            // AfficherMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(967, 460);
            Controls.Add(lblNombreResultats);
            Controls.Add(lblRechercher);
            Controls.Add(txtRechercher);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(dgvMenus);
            Text = "Liste des menus";
            ((System.ComponentModel.ISupportInitialize)dgvMenus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.Label lblNombreResultats;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescription;
    }
}