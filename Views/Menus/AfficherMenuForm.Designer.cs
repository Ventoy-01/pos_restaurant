using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pos_Restaurant.Views.Menus;

partial class AfficherMenuForm
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
        dgvMenus = new System.Windows.Forms.DataGridView();
        txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
        txtAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btnAjouter = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgvMenus).BeginInit();
        SuspendLayout();
        // 
        // dgvMenus
        // 
        dgvMenus.AllowUserToAddRows = false;
        dgvMenus.ColumnHeadersHeight = 34;
        dgvMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { txtId, txtNom, txtType, txtPrix, txtQuantite, txtDescription });
        dgvMenus.Location = new System.Drawing.Point(-1, 192);
        dgvMenus.Name = "dgvMenus";
        dgvMenus.ReadOnly = true;
        dgvMenus.RowHeadersWidth = 62;
        dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvMenus.Size = new System.Drawing.Size(965, 257);
        dgvMenus.TabIndex = 0;
        // 
        // txtId
        // 
        txtId.DataPropertyName = "Id";
        txtId.HeaderText = "ID";
        txtId.MinimumWidth = 8;
        txtId.Name = "txtId";
        txtId.ReadOnly = true;
        txtId.Width = 150;
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
        txtType.Width = 150;
        // 
        // txtPrix
        // 
        txtPrix.DataPropertyName = "PrixUnitaire";
        txtPrix.HeaderText = "Prix Unitaire";
        txtPrix.MinimumWidth = 8;
        txtPrix.Name = "txtPrix";
        txtPrix.ReadOnly = true;
        txtPrix.Width = 150;
        // 
        // txtQuantite
        // 
        txtQuantite.DataPropertyName = "Quantite";
        txtQuantite.HeaderText = "Quantite";
        txtQuantite.MinimumWidth = 8;
        txtQuantite.Name = "txtQuantite";
        txtQuantite.ReadOnly = true;
        txtQuantite.Width = 150;
        // 
        // txtDescription
        // 
        txtDescription.DataPropertyName = "Description";
        txtDescription.HeaderText = "Description";
        txtDescription.MinimumWidth = 8;
        txtDescription.Name = "txtDescription";
        txtDescription.ReadOnly = true;
        txtDescription.Width = 150;
        // 
        // txtAction
        // 
        txtAction.MinimumWidth = 8;
        txtAction.Name = "txtAction";
        txtAction.Width = 150;
        // 
        // btnAjouter
        // 
        btnAjouter.BackColor = System.Drawing.Color.RoyalBlue;
        btnAjouter.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAjouter.ForeColor = System.Drawing.Color.White;
        btnAjouter.Location = new System.Drawing.Point(672, 51);
        btnAjouter.Name = "btnAjouter";
        btnAjouter.Size = new System.Drawing.Size(204, 41);
        btnAjouter.TabIndex = 1;
        btnAjouter.Text = "Ajouter un menu";
        btnAjouter.UseVisualStyleBackColor = false;
        btnAjouter.Click += btnAjouter_Click;
        // 
        // AfficherMenuForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(967, 450);
        Controls.Add(btnAjouter);
        Controls.Add(dgvMenus);
        Text = "Liste des menus";
        ((System.ComponentModel.ISupportInitialize)dgvMenus).EndInit();
        ResumeLayout(false);
    }


    // private System.Windows.Forms.DataGridViewTextBoxColumn txtId;

    

    private System.Windows.Forms.DataGridViewTextBoxColumn txtAction;

    private System.Windows.Forms.Button btnAjouter;

    private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtNom;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtType; 
    private System.Windows.Forms.DataGridViewTextBoxColumn txtPrix; 
    private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantite;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtDescription;
    private System.Windows.Forms.DataGridView dgvMenus;

    #endregion
}

