// Views/AjouterClientForm.Designer.cs
namespace Pos_Restaurant.Views.Clients
{
    partial class AjouterClientForm
    {
        private System.ComponentModel.IContainer components = null;
        
        // Déclaration des contrôles
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
        private System.Windows.Forms.NumericUpDown txtMontantDette;
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
            txtMontantDette = new System.Windows.Forms.NumericUpDown();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnVider = new System.Windows.Forms.Button();
            lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtMontantDette).BeginInit();
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
            lblTitre.Text = "NOUVEAU CLIENT";
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
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new System.Drawing.Point(50, 163);
            lblPrenom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(78, 25);
            lblPrenom.TabIndex = 3;
            lblPrenom.Text = "Prénom:";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new System.Drawing.Point(250, 158);
            txtPrenom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new System.Drawing.Size(414, 31);
            txtPrenom.TabIndex = 4;
            // 
            // lblSexe
            // 
            lblSexe.AutoSize = true;
            lblSexe.Location = new System.Drawing.Point(50, 231);
            lblSexe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new System.Drawing.Size(52, 25);
            lblSexe.TabIndex = 5;
            lblSexe.Text = "Sexe:";
            // 
            // comboSexe
            // 
            comboSexe.FormattingEnabled = true;
            comboSexe.Items.AddRange(new object[] { "Masculin", "Feminin" });
            comboSexe.Location = new System.Drawing.Point(250, 225);
            comboSexe.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboSexe.Name = "comboSexe";
            comboSexe.Size = new System.Drawing.Size(414, 33);
            comboSexe.TabIndex = 6;
            comboSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new System.Drawing.Point(50, 298);
            lblTelephone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(96, 25);
            lblTelephone.TabIndex = 7;
            lblTelephone.Text = "Téléphone:";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new System.Drawing.Point(250, 292);
            txtTelephone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(414, 31);
            txtTelephone.TabIndex = 8;
            txtTelephone.MaxLength = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(50, 365);
            lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(58, 25);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(250, 360);
            txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(414, 31);
            txtEmail.TabIndex = 10;
            // 
            // lblMontantDette
            // 
            lblMontantDette.AutoSize = true;
            lblMontantDette.Location = new System.Drawing.Point(50, 432);
            lblMontantDette.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMontantDette.Name = "lblMontantDette";
            lblMontantDette.Size = new System.Drawing.Size(178, 25);
            lblMontantDette.TabIndex = 11;
            lblMontantDette.Text = "Montant dette (HTG):";
            // 
            // txtMontantDette
            // 
            txtMontantDette.Location = new System.Drawing.Point(250, 427);
            txtMontantDette.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMontantDette.Name = "txtMontantDette";
            txtMontantDette.Size = new System.Drawing.Size(414, 31);
            txtMontantDette.TabIndex = 12;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)255)), ((int)((byte)128)));
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEnregistrer.Location = new System.Drawing.Point(250, 500);
            btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new System.Drawing.Size(200, 67);
            btnEnregistrer.TabIndex = 13;
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
            btnVider.TabIndex = 14;
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
            lblMessage.TabIndex = 15;
            lblMessage.Text = "Prêt à enregistrer...";
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AjouterClientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(723, 694);
            Controls.Add(lblMessage);
            Controls.Add(btnVider);
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
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ajouter un client";
            ((System.ComponentModel.ISupportInitialize)txtMontantDette).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        
        #endregion
    }
}