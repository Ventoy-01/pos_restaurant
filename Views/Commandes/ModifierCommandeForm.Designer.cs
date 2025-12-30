using System.ComponentModel;

namespace Pos_Restaurant.Views.Commandes
{
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
            components = new System.ComponentModel.Container();
            lblTitre = new System.Windows.Forms.Label();
            lblMenu = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            comboMenu = new System.Windows.Forms.ComboBox();
            comboClient = new System.Windows.Forms.ComboBox();
            lblQuantite = new System.Windows.Forms.Label();
            txtQuantite = new System.Windows.Forms.NumericUpDown();
            lblPrixTotal = new System.Windows.Forms.Label();
            txtPrixTotal = new System.Windows.Forms.NumericUpDown();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnAnnuler = new System.Windows.Forms.Button();
            lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrixTotal).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            lblTitre.ForeColor = System.Drawing.Color.Blue;
            lblTitre.Location = new System.Drawing.Point(200, 20);
            lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new System.Drawing.Size(319, 33);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "MODIFIER COMMANDE";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblMenu.Location = new System.Drawing.Point(40, 80);
            lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new System.Drawing.Size(70, 28);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu :";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblClient.Location = new System.Drawing.Point(40, 140);
            lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(73, 28);
            lblClient.TabIndex = 2;
            lblClient.Text = "Client :";
            // 
            // comboMenu
            // 
            comboMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            comboMenu.FormattingEnabled = true;
            comboMenu.Location = new System.Drawing.Point(180, 77);
            comboMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            comboMenu.Name = "comboMenu";
            comboMenu.Size = new System.Drawing.Size(450, 36);
            comboMenu.TabIndex = 1;
            // 
            // comboClient
            // 
            comboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            comboClient.FormattingEnabled = true;
            comboClient.Location = new System.Drawing.Point(180, 137);
            comboClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            comboClient.Name = "comboClient";
            comboClient.Size = new System.Drawing.Size(450, 36);
            comboClient.TabIndex = 2;
            // 
            // lblQuantite
            // 
            lblQuantite.AutoSize = true;
            lblQuantite.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblQuantite.Location = new System.Drawing.Point(40, 200);
            lblQuantite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new System.Drawing.Size(97, 28);
            lblQuantite.TabIndex = 4;
            lblQuantite.Text = "Quantité :";
            // 
            // txtQuantite
            // 
            txtQuantite.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtQuantite.Location = new System.Drawing.Point(180, 197);
            txtQuantite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtQuantite.Minimum = new decimal(new int[] { 1, 0, 0, 0});
            txtQuantite.Name = "txtQuantite";
            txtQuantite.Size = new System.Drawing.Size(150, 34);
            txtQuantite.TabIndex = 3;
            txtQuantite.Value = new decimal(new int[] { 1, 0, 0, 0});
            // 
            // lblPrixTotal
            // 
            lblPrixTotal.AutoSize = true;
            lblPrixTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPrixTotal.Location = new System.Drawing.Point(40, 260);
            lblPrixTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrixTotal.Name = "lblPrixTotal";
            lblPrixTotal.Size = new System.Drawing.Size(96, 28);
            lblPrixTotal.TabIndex = 6;
            lblPrixTotal.Text = "Prix total :";
            // 
            // txtPrixTotal
            // 
            txtPrixTotal.DecimalPlaces = 2;
            txtPrixTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPrixTotal.Location = new System.Drawing.Point(180, 257);
            txtPrixTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPrixTotal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            txtPrixTotal.Name = "txtPrixTotal";
            txtPrixTotal.ReadOnly = true;
            txtPrixTotal.Size = new System.Drawing.Size(150, 34);
            txtPrixTotal.TabIndex = 7;
            txtPrixTotal.ThousandsSeparator = true;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblDescription.Location = new System.Drawing.Point(40, 320);
            lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(121, 28);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtDescription.Location = new System.Drawing.Point(180, 317);
            txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(450, 100);
            txtDescription.TabIndex = 4;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.RoyalBlue;
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEnregistrer.ForeColor = System.Drawing.Color.White;
            btnEnregistrer.Location = new System.Drawing.Point(180, 450);
            btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new System.Drawing.Size(150, 50);
            btnEnregistrer.TabIndex = 5;
            btnEnregistrer.Text = "💾 Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += new System.EventHandler(btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = System.Drawing.Color.Gray;
            btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAnnuler.ForeColor = System.Drawing.Color.White;
            btnAnnuler.Location = new System.Drawing.Point(340, 450);
            btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new System.Drawing.Size(150, 50);
            btnAnnuler.TabIndex = 6;
            btnAnnuler.Text = "❌ Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblMessage.Location = new System.Drawing.Point(40, 520);
            lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(0, 25);
            lblMessage.TabIndex = 12;
            // 
            // ModifierCommandeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 550);
            Controls.Add(lblMessage);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtPrixTotal);
            Controls.Add(lblPrixTotal);
            Controls.Add(txtQuantite);
            Controls.Add(lblQuantite);
            Controls.Add(comboClient);
            Controls.Add(comboMenu);
            Controls.Add(lblClient);
            Controls.Add(lblMenu);
            Controls.Add(lblTitre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierCommandeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Modifier Commande";
            ((System.ComponentModel.ISupportInitialize)txtQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrixTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox comboMenu;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown txtQuantite;
        private System.Windows.Forms.Label lblPrixTotal;
        private System.Windows.Forms.NumericUpDown txtPrixTotal;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblMessage;
    }
}