namespace Pos_Restaurant.Views.Clients
{
    partial class ModifierClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierClientForm));
            lblTitre = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            txtNom = new System.Windows.Forms.TextBox();
            lblPrenom = new System.Windows.Forms.Label();
            txtPrenom = new System.Windows.Forms.TextBox();
            lblSexe = new System.Windows.Forms.Label();
            comboSexe = new System.Windows.Forms.ComboBox();
            lblTelephone = new System.Windows.Forms.Label();
            txtTelephone = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblMontantDette = new System.Windows.Forms.Label();
            txtMontantDette = new System.Windows.Forms.TextBox();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnAnnuler = new System.Windows.Forms.Button();
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
            lblTitre.Size = new System.Drawing.Size(241, 33);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "MODIFIER CLIENT";
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
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblPrenom.Location = new System.Drawing.Point(50, 150);
            lblPrenom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(83, 28);
            lblPrenom.TabIndex = 3;
            lblPrenom.Text = "Prénom:";
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtPrenom.Location = new System.Drawing.Point(250, 147);
            txtPrenom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new System.Drawing.Size(414, 34);
            txtPrenom.TabIndex = 2;
            // 
            // lblSexe
            // 
            lblSexe.AutoSize = true;
            lblSexe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblSexe.Location = new System.Drawing.Point(50, 210);
            lblSexe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new System.Drawing.Size(55, 28);
            lblSexe.TabIndex = 5;
            lblSexe.Text = "Sexe:";
            // 
            // comboSexe
            // 
            comboSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboSexe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            comboSexe.FormattingEnabled = true;
            comboSexe.Items.AddRange(new object[] { "Masculin", "Féminin" });
            comboSexe.Location = new System.Drawing.Point(250, 207);
            comboSexe.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboSexe.Name = "comboSexe";
            comboSexe.Size = new System.Drawing.Size(414, 36);
            comboSexe.TabIndex = 3;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblTelephone.Location = new System.Drawing.Point(50, 270);
            lblTelephone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(98, 28);
            lblTelephone.TabIndex = 7;
            lblTelephone.Text = "Téléphone:";
            // 
            // txtTelephone
            // 
            txtTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtTelephone.Location = new System.Drawing.Point(250, 267);
            txtTelephone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(414, 34);
            txtTelephone.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblEmail.Location = new System.Drawing.Point(50, 330);
            lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(63, 28);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtEmail.Location = new System.Drawing.Point(250, 327);
            txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(414, 34);
            txtEmail.TabIndex = 5;
            // 
            // lblMontantDette
            // 
            lblMontantDette.AutoSize = true;
            lblMontantDette.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMontantDette.Location = new System.Drawing.Point(50, 390);
            lblMontantDette.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMontantDette.Name = "lblMontantDette";
            lblMontantDette.Size = new System.Drawing.Size(179, 28);
            lblMontantDette.TabIndex = 11;
            lblMontantDette.Text = "Montant dette (HTG):";
            // 
            // txtMontantDette
            // 
            txtMontantDette.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtMontantDette.Location = new System.Drawing.Point(250, 387);
            txtMontantDette.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMontantDette.Name = "txtMontantDette";
            txtMontantDette.Size = new System.Drawing.Size(414, 34);
            txtMontantDette.TabIndex = 6;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEnregistrer.Location = new System.Drawing.Point(250, 460);
            btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new System.Drawing.Size(200, 67);
            btnEnregistrer.TabIndex = 7;
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
            btnAnnuler.TabIndex = 8;
            btnAnnuler.Text = "ANNULER";
            btnAnnuler.UseVisualStyleBackColor = false;
            //btnAnnuler.Click += btnAnnuler_Click;
            // 
            // ModifierClientForm
            // 
            AcceptButton = btnEnregistrer;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnAnnuler;
            ClientSize = new System.Drawing.Size(723, 550);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(txtMontantDette);
            Controls.Add(lblMontantDette);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelephone);
            Controls.Add(lblTelephone);
            Controls.Add(comboSexe);
            Controls.Add(lblSexe);
            Controls.Add(txtPrenom);
            Controls.Add(lblPrenom);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(lblTitre);
            // Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierClientForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Modifier un client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.ComboBox comboSexe;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMontantDette;
        private System.Windows.Forms.TextBox txtMontantDette;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}