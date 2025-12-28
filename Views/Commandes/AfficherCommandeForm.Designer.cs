using System.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pos_Restaurant.Views.Commandes;

partial class AfficherCommandeForm
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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "AfficherCommandeForm";
        
        dgvCommandes = new System.Windows.Forms.DataGridView();
        txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtIdMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtNomMenu  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtType  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtPrix  = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtPrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btnAjouter = new System.Windows.Forms.Button();
        btnModifier = new System.Windows.Forms.Button();
        btnSupprimer = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
        SuspendLayout();
        
        dgvCommandes.AllowUserToAddRows = false;
        dgvCommandes.ColumnHeadersHeight = 34;
        dgvCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { txtId, txtIdMenu, txtNomMenu, txtType, txtIdClient, txtNomClient, txtPrix, txtQuantite, txtPrixTotal, txtDescription });
        dgvCommandes.Location = new System.Drawing.Point(-1, 192);
        dgvCommandes.Name = "dgvCommandes";
        dgvCommandes.ReadOnly = true;
        dgvCommandes.RowHeadersWidth = 40;
        dgvCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCommandes.Size = new System.Drawing.Size(1200, 257);
        dgvCommandes.TabIndex = 0;
        
        //txtid
        txtId.DataPropertyName = "Id";
        txtId.HeaderText = "ID";
        txtId.MinimumWidth = 8;
        txtId.Name = "txtId";
        txtId.ReadOnly = true;
        txtId.Width = 50;
        
        //txtIdMenu
        txtIdMenu.DataPropertyName = "Id";
        txtIdMenu.HeaderText = "IDMenu";
        txtIdMenu.MinimumWidth = 8;
        txtIdMenu.Name = "txtId";
        txtIdMenu.ReadOnly = true;
        txtIdMenu.Width = 50;
        
       //txtNomMenu
      txtNomMenu.DataPropertyName = "Nom";
      txtNomMenu.HeaderText = "Nom Menu";
      txtNomMenu.MinimumWidth = 8;
      txtNomMenu.Name = "txtNom";
      txtNomMenu.ReadOnly = true;
      txtNomMenu.Width = 100; 
      
      //txtType
      txtType.DataPropertyName = "Type";
      txtType.HeaderText = "Type";
      txtType.MinimumWidth = 8;
      txtType.Name = "txtType";
      txtType.ReadOnly = true;
      txtType.Width = 70;
      
      //txtIdClient
      txtIdClient.DataPropertyName = "Id";
      txtIdClient.HeaderText = "IDClient";
      txtIdClient.MinimumWidth = 8;
      txtIdClient.Name = "txtId";
      txtIdClient.ReadOnly = true;
      txtIdClient.Width = 50;
      
        //txtnomClient
        txtNomClient.DataPropertyName = "Nom";
        txtNomClient.HeaderText = "Nom Client";
        txtNomClient.MinimumWidth = 8;
        txtNomClient.Name = "txtNom";
        txtNomClient.ReadOnly = true;
        txtNomClient.Width = 150;
        
        
        // txtPrix
        txtPrix.DataPropertyName = "Prix";
        txtPrix.HeaderText = "Prix";
        txtPrix.MinimumWidth = 8;
        txtPrix.Name = "txtPrix";
        txtPrix.ReadOnly = true;
        txtPrix.Width = 70;
        
        //txtQuantite
        txtQuantite.DataPropertyName = "Quantite";
        txtQuantite.HeaderText = "Quantite";
        txtQuantite.MinimumWidth = 8;
        txtQuantite.Name = "txtQuantite";
        txtQuantite.ReadOnly = true;
        txtQuantite.Width = 70;
        
        //txtPrixTotal
        txtPrixTotal.DataPropertyName = "PrixTotal";
        txtPrixTotal.HeaderText = "PrixTotal";
        txtPrixTotal.MinimumWidth = 8;
        txtPrixTotal.Name = "txtPrixTotal";
        txtPrixTotal.ReadOnly = true;
        txtPrixTotal.Width = 100;
        
        //txtDesctption
        txtDescription.DataPropertyName = "Description";
        txtDescription.HeaderText = "Description";
        txtDescription.MinimumWidth = 8;
        txtDescription.Name = "txtDescription";
        txtDescription.ReadOnly = true;
        txtDescription.Width = 150;
        
        //btnAjouter
        btnAjouter.BackColor = System.Drawing.Color.RoyalBlue;
        btnAjouter.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAjouter.ForeColor = System.Drawing.Color.White;
        btnAjouter.Location = new System.Drawing.Point(672, 90);
        btnAjouter.Name = "btnAjouter";
        btnAjouter.Size = new System.Drawing.Size(284, 45);
        btnAjouter.TabIndex = 1;
        btnAjouter.Text = "Ajouter une commande";
        btnAjouter.UseVisualStyleBackColor = false;
        btnAjouter.Click += btnAjouter_Click;
        
        // btnModifier
        // 
        btnModifier.BackColor = System.Drawing.Color.Gold;
        btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnModifier.ForeColor = System.Drawing.Color.Black;
        btnModifier.Location = new System.Drawing.Point(439, 90);
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
        btnSupprimer.Location = new System.Drawing.Point(278, 90);
        btnSupprimer.Name = "btnSupprimer";
        btnSupprimer.Size = new System.Drawing.Size(155, 41);
        btnSupprimer.TabIndex = 2;
        btnSupprimer.Text = "Supprimer";
        btnSupprimer.UseVisualStyleBackColor = false;
        btnSupprimer.Click += btnSupprimer_Click;
        
        
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000,500);
        Controls.Add(btnAjouter);
        Controls.Add(btnModifier);
        Controls.Add(btnSupprimer);
        Controls.Add(dgvCommandes);
        Text = "Liste des Commandes";
        ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
        ResumeLayout(false);
    }
    
    


    private System.Windows.Forms.Button btnModifier;
    private System.Windows.Forms.Button btnSupprimer;
    private System.Windows.Forms.Button btnAjouter;
    

    private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtNomMenu;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtType; 
    private System.Windows.Forms.DataGridViewTextBoxColumn txtNomClient; 
    private System.Windows.Forms.DataGridViewTextBoxColumn txtIdClient;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtIdMenu;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtPrixTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtPrix; 
    private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantite;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtDescription;
    private System.Windows.Forms.DataGridView dgvCommandes;

    #endregion
}