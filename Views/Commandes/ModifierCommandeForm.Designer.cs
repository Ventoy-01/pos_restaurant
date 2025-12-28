using System.ComponentModel;

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
        this.Text = "ModifierCommandeForm";
    }

    private System.Windows.Forms.Label lblTitre;
    private System.Windows.Forms.Label lblNom;
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.ComboBox comboType;
    private System.Windows.Forms.Label lblQuantite;
    private System.Windows.Forms.NumericUpDown txtQuantite;
    private System.Windows.Forms.Label lblPrixUnitaire;
    private System.Windows.Forms.TextBox txtPrixUnitaire;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Button btnEnregistrer;
    private System.Windows.Forms.Button btnAnnuler;
    #endregion
}