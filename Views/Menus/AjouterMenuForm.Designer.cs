// Views/AjouterMenuForm.Designer.cs
namespace Pos_Restaurant.Views.Menus
{
    partial class AjouterMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        
        // Déclaration des contrôles
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown txtQuantite;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Label lblMessage;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterMenuForm));
            lblTitre = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            txtNom = new System.Windows.Forms.TextBox();
            lblType = new System.Windows.Forms.Label();
            comboType = new System.Windows.Forms.ComboBox();
            lblPrix = new System.Windows.Forms.Label();
            txtPrix = new System.Windows.Forms.TextBox();
            lblQuantite = new System.Windows.Forms.Label();
            txtQuantite = new System.Windows.Forms.NumericUpDown();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnVider = new System.Windows.Forms.Button();
            lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantite).BeginInit();
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
            lblTitre.Size = new System.Drawing.Size(245, 33);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "NOUVEAU MENU";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(50, 96);
            lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(56, 25);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            txtNom.Location = new System.Drawing.Point(250, 90);
            txtNom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(414, 31);
            txtNom.TabIndex = 2;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new System.Drawing.Point(50, 163);
            lblType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(53, 25);
            lblType.TabIndex = 3;
            lblType.Text = "Type:";
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Plat", "Dessert", "Boisson" });
            comboType.Location = new System.Drawing.Point(250, 158);
            comboType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboType.Name = "comboType";
            comboType.Size = new System.Drawing.Size(414, 33);
            comboType.TabIndex = 4;
            comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblPrix
            // 
            lblPrix.AutoSize = true;
            lblPrix.Location = new System.Drawing.Point(50, 231);
            lblPrix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPrix.Name = "lblPrix";
            lblPrix.Size = new System.Drawing.Size(92, 25);
            lblPrix.TabIndex = 5;
            lblPrix.Text = "Prix (HTG):";
            // 
            // txtPrix
            // 
            txtPrix.Location = new System.Drawing.Point(250, 225);
            txtPrix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new System.Drawing.Size(414, 31);
            txtPrix.TabIndex = 6;
            // 
            // lblQuantite
            // 
            lblQuantite.AutoSize = true;
            lblQuantite.Location = new System.Drawing.Point(50, 298);
            lblQuantite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new System.Drawing.Size(84, 25);
            lblQuantite.TabIndex = 7;
            lblQuantite.Text = "Quantité:";
            // 
            // txtQuantite
            // 
            txtQuantite.Location = new System.Drawing.Point(250, 292);
            txtQuantite.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtQuantite.Name = "txtQuantite";
            txtQuantite.Size = new System.Drawing.Size(417, 31);
            txtQuantite.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(50, 365);
            lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(106, 25);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(250, 360);
            txtDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(414, 112);
            txtDescription.TabIndex = 10;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)255)), ((int)((byte)128)));
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEnregistrer.Location = new System.Drawing.Point(250, 500);
            btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new System.Drawing.Size(200, 67);
            btnEnregistrer.TabIndex = 11;
            btnEnregistrer.Text = "ENREGISTRER";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnVider
            // 
            btnVider.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)128)));
            btnVider.Location = new System.Drawing.Point(467, 500);
            btnVider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnVider.Name = "btnVider";
            btnVider.Size = new System.Drawing.Size(200, 67);
            btnVider.TabIndex = 12;
            btnVider.Text = "VIDER";
            btnVider.UseVisualStyleBackColor = false;
            btnVider.Click += btnVider_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = System.Drawing.Color.Honeydew;
            lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblMessage.Location = new System.Drawing.Point(50, 596);
            lblMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(615, 75);
            lblMessage.TabIndex = 13;
            lblMessage.Text = "Prêt à enregistrer...";
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AjouterMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(723, 694);
            Controls.Add(lblMessage);
            Controls.Add(btnVider);
            Controls.Add(btnEnregistrer);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtQuantite);
            Controls.Add(lblQuantite);
            Controls.Add(txtPrix);
            Controls.Add(lblPrix);
            Controls.Add(comboType);
            Controls.Add(lblType);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(lblTitre);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ajouter un menu";
            ((System.ComponentModel.ISupportInitialize)txtQuantite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        
        #endregion
    }
}