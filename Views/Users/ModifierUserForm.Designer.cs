
namespace Pos_Restaurant.Views.Users
{
    partial class ModifierUserForm
    {
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitre = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            lblRole = new System.Windows.Forms.Label();
            comboRole = new System.Windows.Forms.ComboBox();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnAnnuler = new System.Windows.Forms.Button();
            lblInfoPassword = new System.Windows.Forms.Label();
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
            lblTitre.Size = new System.Drawing.Size(278, 33);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "MODIFIER COMPTE";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblUsername.Location = new System.Drawing.Point(50, 90);
            lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(179, 28);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "👤 Nom d'utilisateur :";
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtUsername.Location = new System.Drawing.Point(250, 87);
            txtUsername.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(414, 34);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblPassword.Location = new System.Drawing.Point(50, 150);
            lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(144, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mot de passe :";
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtPassword.Location = new System.Drawing.Point(250, 147);
            txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new System.Drawing.Size(414, 34);
            txtPassword.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblConfirmPassword.Location = new System.Drawing.Point(50, 210);
            lblConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(198, 28);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirmer :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtConfirmPassword.Location = new System.Drawing.Point(250, 207);
            txtConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new System.Drawing.Size(414, 34);
            txtConfirmPassword.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblRole.Location = new System.Drawing.Point(50, 270);
            lblRole.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(57, 28);
            lblRole.TabIndex = 7;
            lblRole.Text = "Rôle :";
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "admin","user" });
            comboRole.Location = new System.Drawing.Point(250, 267);
            comboRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboRole.Name = "comboRole";
            comboRole.Size = new System.Drawing.Size(414, 36);
            comboRole.TabIndex = 4;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEnregistrer.Location = new System.Drawing.Point(250, 340);
            btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new System.Drawing.Size(200, 67);
            btnEnregistrer.TabIndex = 5;
            btnEnregistrer.Text = "ENREGISTRER";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAnnuler.Location = new System.Drawing.Point(464, 340);
            btnAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new System.Drawing.Size(200, 67);
            btnAnnuler.TabIndex = 6;
            btnAnnuler.Text = "ANNULER";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // lblInfoPassword
            // 
            lblInfoPassword.AutoSize = true;
            lblInfoPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblInfoPassword.ForeColor = System.Drawing.Color.Gray;
            lblInfoPassword.Location = new System.Drawing.Point(250, 310);
            lblInfoPassword.Name = "lblInfoPassword";
            lblInfoPassword.Size = new System.Drawing.Size(414, 21);
            lblInfoPassword.TabIndex = 10;
            lblInfoPassword.Text = "Laissez les champs mot de passe vides pour ne pas modifier";
            // 
            // ModifierUserForm
            // 
            AcceptButton = btnEnregistrer;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnAnnuler;
            ClientSize = new System.Drawing.Size(723, 430);
            Controls.Add(lblInfoPassword);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(comboRole);
            Controls.Add(lblRole);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitre);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierUserForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Modifier un utilisateur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblInfoPassword;
    }
}