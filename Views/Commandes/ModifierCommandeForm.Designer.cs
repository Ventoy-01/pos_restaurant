using System.ComponentModel;
using Pos_Restaurant.Models;
using Pos_Restaurant.Dao;

namespace Pos_Restaurant.Views.Commandes;

partial class ModifierCommandeForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>



    private List<MenusModel> menus = new MenusDao().Lister();
    List<ClientsModel> clients = new ClientsDao().Lister();
    
    // Déclaration des contrôles
    private System.Windows.Forms.Label lblTitre;
    private System.Windows.Forms.Label lblMenu;
    // private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.Label lblClient;
    // private System.Windows.Forms.TextBox txtPrenom;
    // private System.Windows.Forms.Label lblSexe;
    private System.Windows.Forms.ComboBox comboMenu;
    private System.Windows.Forms.ComboBox comboClient;
    
    private System.Windows.Forms.Label lblQuantite;
    private System.Windows.Forms.NumericUpDown txtQuantite;
    private System.Windows.Forms.Label lblPrixTotal;
    private System.Windows.Forms.NumericUpDown txtPrixTotal;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.TextBox txtDescription;
    // private System.Windows.Forms.Label lblMontantDette;
    // private System.Windows.Forms.NumericUpDown txtMontantDette;
    private System.Windows.Forms.Button btnEnregistrer;
    // private System.Windows.Forms.Button btnVider;
    // private System.Windows.Forms.Label lblMessage;
    
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
        
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierCommandeForm));
        lblTitre = new System.Windows.Forms.Label();
        lblMenu = new System.Windows.Forms.Label();
        // txtNom = new System.Windows.Forms.TextBox();
        lblClient = new System.Windows.Forms.Label();
        // txtPrenom = new System.Windows.Forms.TextBox();
        // lblSexe = new System.Windows.Forms.Label();
        comboMenu = new System.Windows.Forms.ComboBox();
        comboClient = new System.Windows.Forms.ComboBox();
        lblQuantite = new System.Windows.Forms.Label();
        txtQuantite = new System.Windows.Forms.NumericUpDown();
        lblPrixTotal = new System.Windows.Forms.Label();
        txtPrixTotal = new System.Windows.Forms.NumericUpDown();
        lblDescription = new System.Windows.Forms.Label();
        txtDescription = new System.Windows.Forms.TextBox();
        // lblMontantDette = new System.Windows.Forms.Label();
        // txtMontantDette = new System.Windows.Forms.NumericUpDown();
        btnEnregistrer = new System.Windows.Forms.Button();
        // btnVider = new System.Windows.Forms.Button();
        // lblMessage = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)txtPrixTotal).BeginInit();
        SuspendLayout();
        // 
        // lblTitre
        // 
        lblTitre.AutoSize = true;
        lblTitre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
        lblTitre.ForeColor = System.Drawing.Color.Blue;
        lblTitre.Location = new System.Drawing.Point(300, 19);
        lblTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new System.Drawing.Size(263, 33);
        lblTitre.TabIndex = 0;
        lblTitre.Text = "MODIFIER COMMANDE";
        // 
        // lblMenu
        // 
        lblMenu.AutoSize = true;
        lblMenu.Location = new System.Drawing.Point(50, 96);
        lblMenu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblMenu.Name = "lblMenu";
        lblMenu.Size = new System.Drawing.Size(56, 25);
        lblMenu.TabIndex = 1;
        lblMenu.Text = "Menu :";
        
        
        //comboMenus
        comboMenu.FormattingEnabled = true;
        // comboMenu.Items.AddRange(new object[] { 1, 2 });
        foreach (var menu in menus)
        {
            comboMenu.Items.Add($"{menu.Id} - {menu.Nom}");
        }
        comboMenu.Location = new System.Drawing.Point(250, 90);
        comboMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        comboMenu.Name = "comboMenu";
        comboMenu.Size = new System.Drawing.Size(414, 33);
        comboMenu.TabIndex = 6;
        // 
      
        
        lblClient.AutoSize = true;
        lblClient.Location = new System.Drawing.Point(50, 190);
        lblClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblClient.Name = "lblClient";
        lblClient.Size = new System.Drawing.Size(78, 25);
        lblClient.TabIndex = 3;
        lblClient.Text = "Client:";
        // 
        //comboClient
        comboClient.FormattingEnabled = true;
    
        foreach (var client in clients)
        {
            comboClient.Items.Add($"{client.Id} - {client.Nom}");
        }
        
        comboClient.Location = new System.Drawing.Point(250, 190);
        comboClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        comboClient.Name = "comboClient";
        comboClient.Size = new System.Drawing.Size(414, 33);
        comboClient.TabIndex = 6;
       
        
        // 
        // lblQuantite
        // 
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new System.Drawing.Point(50, 298);
        lblQuantite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblQuantite.Name = "lblQuantite";
        lblQuantite.Size = new System.Drawing.Size(96, 25);
        lblQuantite.TabIndex = 7;
        lblQuantite.Text = "Quantite:";
        // 
        // txtQuantite
        // 
        txtQuantite.Location = new System.Drawing.Point(250, 292);
        txtQuantite.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        txtQuantite.Name = "txtQuantite";
        txtQuantite.Size = new System.Drawing.Size(414, 31);
        txtQuantite.TabIndex = 8;
        // 
        // lblPrixTotal
        // 
        lblPrixTotal.AutoSize = true;
        lblPrixTotal.Location = new System.Drawing.Point(50, 365);
        lblPrixTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblPrixTotal.Name = "lblPrixTotal";
        lblPrixTotal.Size = new System.Drawing.Size(58, 25);
        lblPrixTotal.TabIndex = 9;
        lblPrixTotal.Text = "Prix Total:";
        // 
        // txtPrixTotal
        // 
        txtPrixTotal.Location = new System.Drawing.Point(250, 360);
        txtPrixTotal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        txtPrixTotal.Name = "txtPrixTotal";
        txtPrixTotal.Size = new System.Drawing.Size(414, 31);
        txtPrixTotal.TabIndex = 10;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Location = new System.Drawing.Point(50, 425);
        lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new System.Drawing.Size(106, 25);
        lblDescription.TabIndex = 11;
        lblDescription.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new System.Drawing.Point(250, 425);
        txtDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtDescription.Size = new System.Drawing.Size(414, 82);
        txtDescription.TabIndex = 12;
        // 
        // btnEnregistrer
        // 
        btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)255)), ((int)((byte)128)));
        btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnEnregistrer.Location = new System.Drawing.Point(250, 530);
        btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.Size = new System.Drawing.Size(200, 67);
        btnEnregistrer.TabIndex = 13;
        btnEnregistrer.Text = "ENREGISTRER";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Click += btnEnregistrer_Click;
      
            
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "AjouterCommandeForm";
        
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(723, 694);
        
   
        Controls.Add(lblClient);
        // Controls.Add(btnVider);
        Controls.Add(btnEnregistrer);
     
        Controls.Add(txtPrixTotal);
        Controls.Add(lblPrixTotal);
        Controls.Add(txtQuantite);
        Controls.Add(lblQuantite);
        Controls.Add(comboMenu);
        Controls.Add(comboClient);
        Controls.Add(lblDescription);
        Controls.Add(txtDescription);
        // Controls.Add(txtNom);
        Controls.Add(lblMenu);
        Controls.Add(lblTitre);
        
        Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Ajouter une Commande";
        ((System.ComponentModel.ISupportInitialize)txtPrixTotal).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}