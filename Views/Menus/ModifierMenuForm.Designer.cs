using System.ComponentModel;

namespace Pos_Restaurant.Views.Menus;

partial class ModifierMenuForm
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
    ///
    private System.Windows.Forms.DataGridView dgvMenus;
    
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "ModifierMenuForm";
        
        
        DataGridViewLinkColumn colAction = new DataGridViewLinkColumn();
        colAction.Name = "Action";
        colAction.HeaderText = "Actions";
        colAction.ActiveLinkColor = Color.Blue;
        colAction.LinkBehavior = LinkBehavior.HoverUnderline;
        colAction.LinkColor = Color.Blue;
        dgvMenus.Columns.Add(colAction);
        
        // Lors de l'ajout d'une ligne
        int rowIndex = dgvMenus.Rows.Add();
        dgvMenus.Rows[rowIndex].Cells["Action"].Value = "Modifier | Supprimer";

        


    }
    
    private void dgvMenus_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Vérifier que c'est la bonne colonne et pas l'entête
        if (e.ColumnIndex == dgvMenus.Columns["Action"].Index && e.RowIndex >= 0)
        {
            // On récupère l'ID de la ligne (supposons que l'ID est en colonne 0)
            var id = dgvMenus.Rows[e.RowIndex].Cells["txtId"].Value;

            // On peut afficher un menu contextuel à la position de la souris
            // OU utiliser une logique de zone de clic (plus complexe)
        
            // ASTUCE SIMPLE : Utilisez un petit menu contextuel (ContextMenuStrip)
            // qui s'affiche au clic sur la cellule "Actions".
        }
    }


    #endregion
}