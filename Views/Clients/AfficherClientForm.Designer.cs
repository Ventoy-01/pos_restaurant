using System.ComponentModel;

namespace Pos_Restaurant.Views.Clients;

partial class AfficherClientForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
        SuspendLayout();
        // 
        // dgvClients
        // 
        dgvClients.AllowUserToAddRows = false;
        dgvClients.ColumnHeadersHeight = 34;
        dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { txtId, txtNom, txtPrenom, txtSexe, txtTelephone, txtEmail, txtMontantDette });
        dgvClients.Location = new System.Drawing.Point(12, 100);
        dgvClients.MultiSelect = false;
        dgvClients.Name = "dgvClients";
        dgvClients.ReadOnly = true;
        dgvClients.RowHeadersWidth = 62;
        dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvClients.Size = new System.Drawing.Size(1140, 400);
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
        btnAjouter.Location = new System.Drawing.Point(850, 50);
        btnAjouter.Name = "btnAjouter";
        btnAjouter.Size = new System.Drawing.Size(150, 41);
        btnAjouter.TabIndex = 1;
        btnAjouter.Text = "Ajouter";
        btnAjouter.UseVisualStyleBackColor = false;
        btnAjouter.Click += btnAjouter_Click;
        // 
        // btnModifier
        // 
        btnModifier.BackColor = System.Drawing.Color.Gold;
        btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnModifier.ForeColor = System.Drawing.Color.Black;
        btnModifier.Location = new System.Drawing.Point(694, 50);
        btnModifier.Name = "btnModifier";
        btnModifier.Size = new System.Drawing.Size(150, 41);
        btnModifier.TabIndex = 2;
        btnModifier.Text = "Modifier";
        btnModifier.UseVisualStyleBackColor = false;
        // 
        // btnSupprimer
        // 
        btnSupprimer.BackColor = System.Drawing.Color.Crimson;
        btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSupprimer.ForeColor = System.Drawing.Color.White;
        btnSupprimer.Location = new System.Drawing.Point(538, 50);
        btnSupprimer.Name = "btnSupprimer";
        btnSupprimer.Size = new System.Drawing.Size(150, 41);
        btnSupprimer.TabIndex = 3;
        btnSupprimer.Text = "Supprimer";
        btnSupprimer.UseVisualStyleBackColor = false;
        btnSupprimer.Click += btnSupprimer_Click;
        // 
        // txtRechercher
        // 
        txtRechercher.Location = new System.Drawing.Point(150, 54);
        txtRechercher.Name = "txtRechercher";
        txtRechercher.PlaceholderText = "Nom, téléphone ou email...";
        txtRechercher.Size = new System.Drawing.Size(300, 31);
        txtRechercher.TabIndex = 4;
        // 
        // lblRechercher
        // 
        lblRechercher.AutoSize = true;
        lblRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblRechercher.Location = new System.Drawing.Point(12, 58);
        lblRechercher.Name = "lblRechercher";
        lblRechercher.Size = new System.Drawing.Size(116, 28);
        lblRechercher.TabIndex = 5;
        lblRechercher.Text = "Rechercher :";
        // 
        // AfficherClientForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1053, 512);
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

    private System.Windows.Forms.Button btnAjouter;
    private System.Windows.Forms.Button btnModifier;
    private System.Windows.Forms.Button btnSupprimer;
    private System.Windows.Forms.TextBox txtRechercher;
    private System.Windows.Forms.Label lblRechercher;

    private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtNom;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtPrenom;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtSexe;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtTelephone;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtMontantDette;
    private System.Windows.Forms.DataGridView dgvClients;

    #endregion
}