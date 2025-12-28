namespace Pos_Restaurant.Views.Menus
{
    partial class ModifierMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierMenuForm));
            lblTitre = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            txtNom = new System.Windows.Forms.TextBox();
            lblType = new System.Windows.Forms.Label();
            // txtType = new System.Windows.Forms.TextBox();
            lblQuantite = new System.Windows.Forms.Label();
            txtQuantite = new System.Windows.Forms.NumericUpDown();
            lblPrixUnitaire = new System.Windows.Forms.Label();
            txtPrixUnitaire = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnAnnuler = new System.Windows.Forms.Button();
            comboType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantite).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblTitre.ForeColor = System.Drawing.Color.Blue;
            lblTitre.Location = new System.Drawing.Point(275, 19);
            lblTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(224, 33);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "MODIFIER MENU";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblNom.Location = new System.Drawing.Point(50, 90);
            lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(56, 28);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            txtNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtNom.Location = new System.Drawing.Point(250, 87);
            txtNom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(414, 34);
            txtNom.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblType.Location = new System.Drawing.Point(50, 150);
            lblType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(53, 28);
            lblType.TabIndex = 3;
            lblType.Text = "Type:";
            // 
            // comboType
            // 
            comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Plat", "Dessert", "Boisson"});
            comboType.Location = new System.Drawing.Point(250, 147);
            comboType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboType.Name = "comboType";
            comboType.Size = new System.Drawing.Size(414, 36);
            comboType.TabIndex = 2;
            // 
            // lblQuantite
            // 
            lblQuantite.AutoSize = true;
            lblQuantite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblQuantite.Location = new System.Drawing.Point(50, 210);
            lblQuantite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new System.Drawing.Size(84, 28);
            lblQuantite.TabIndex = 5;
            lblQuantite.Text = "Quantité:";
            // 
            // txtQuantite
            // 
            txtQuantite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtQuantite.Location = new System.Drawing.Point(250, 207);
            txtQuantite.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtQuantite.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtQuantite.Name = "txtQuantite";
            txtQuantite.Size = new System.Drawing.Size(414, 34);
            txtQuantite.TabIndex = 3;
            txtQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrixUnitaire
            // 
            lblPrixUnitaire.AutoSize = true;
            lblPrixUnitaire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblPrixUnitaire.Location = new System.Drawing.Point(50, 270);
            lblPrixUnitaire.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPrixUnitaire.Name = "lblPrixUnitaire";
            lblPrixUnitaire.Size = new System.Drawing.Size(113, 28);
            lblPrixUnitaire.TabIndex = 7;
            lblPrixUnitaire.Text = "Prix Unitaire:";
            // 
            // txtPrixUnitaire
            // 
            txtPrixUnitaire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtPrixUnitaire.Location = new System.Drawing.Point(250, 267);
            txtPrixUnitaire.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtPrixUnitaire.Name = "txtPrixUnitaire";
            txtPrixUnitaire.Size = new System.Drawing.Size(414, 34);
            txtPrixUnitaire.TabIndex = 4;
            txtPrixUnitaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblDescription.Location = new System.Drawing.Point(50, 330);
            lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(106, 28);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtDescription.Location = new System.Drawing.Point(250, 327);
            txtDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(414, 112);
            txtDescription.TabIndex = 5;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEnregistrer.Location = new System.Drawing.Point(250, 460);
            btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new System.Drawing.Size(200, 67);
            btnEnregistrer.TabIndex = 6;
            btnEnregistrer.Text = "ENREGISTRER";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAnnuler.Location = new System.Drawing.Point(464, 460);
            btnAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new System.Drawing.Size(200, 67);
            btnAnnuler.TabIndex = 7;
            btnAnnuler.Text = "ANNULER";
            btnAnnuler.UseVisualStyleBackColor = false;
            // btnAnnuler.Click += btnAnnuler_Click;
            // 
            // ModifierMenuForm
            // 
            AcceptButton = btnEnregistrer;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnAnnuler;
            ClientSize = new System.Drawing.Size(723, 550);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtPrixUnitaire);
            Controls.Add(lblPrixUnitaire);
            Controls.Add(txtQuantite);
            Controls.Add(lblQuantite);
            Controls.Add(comboType);
            Controls.Add(lblType);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(lblTitre);
            // Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierMenuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Modifier un menu";
            ((System.ComponentModel.ISupportInitialize)txtQuantite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}