namespace Pos_Restaurant.Views.Users
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            gbloginContent = new System.Windows.Forms.GroupBox();
            panelEllipseTop = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            lblRestaurantName = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            lblForgetPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblInstruction = new System.Windows.Forms.Label();
            lblLoginTitle = new System.Windows.Forms.Label();
            gbloginContent.SuspendLayout();
            SuspendLayout();
            // 
            // gbloginContent
            // 
            gbloginContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            gbloginContent.BackColor = System.Drawing.Color.White;
            gbloginContent.Controls.Add(panelEllipseTop);
            gbloginContent.Controls.Add(lblWelcome);
            gbloginContent.Controls.Add(lblRestaurantName);
            gbloginContent.Controls.Add(btnLogin);
            gbloginContent.Controls.Add(lblForgetPassword);
            gbloginContent.Controls.Add(txtPassword);
            gbloginContent.Controls.Add(txtUsername);
            gbloginContent.Controls.Add(lblPassword);
            gbloginContent.Controls.Add(lblUsername);
            gbloginContent.Controls.Add(lblInstruction);
            gbloginContent.Controls.Add(lblLoginTitle);
            gbloginContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            gbloginContent.Location = new System.Drawing.Point(41, 12);
            gbloginContent.Name = "gbloginContent";
            gbloginContent.Padding = new System.Windows.Forms.Padding(20);
            gbloginContent.Size = new System.Drawing.Size(375, 626);
            gbloginContent.TabIndex = 0;
            gbloginContent.TabStop = false;
            // 
            // panelEllipseTop
            // 
            panelEllipseTop.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
            panelEllipseTop.Location = new System.Drawing.Point(129, 47);
            panelEllipseTop.Name = "panelEllipseTop";
            panelEllipseTop.Size = new System.Drawing.Size(100, 75);
            panelEllipseTop.TabIndex = 10;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
            lblWelcome.Location = new System.Drawing.Point(35, 138);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(297, 40);
            lblWelcome.TabIndex = 9;
            lblWelcome.Text = "Bienvenue au";
            lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestaurantName
            // 
            lblRestaurantName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblRestaurantName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
            lblRestaurantName.Location = new System.Drawing.Point(35, 178);
            lblRestaurantName.Name = "lblRestaurantName";
            lblRestaurantName.Size = new System.Drawing.Size(297, 45);
            lblRestaurantName.TabIndex = 8;
            lblRestaurantName.Text = "POS RESTAURANT";
            lblRestaurantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(65, 524);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(234, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "🔓 Se Connecter";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
                //
            // lblForgetPassword
            // 
            lblForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            lblForgetPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
            lblForgetPassword.Location = new System.Drawing.Point(8, 467);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new System.Drawing.Size(312, 38);
            lblForgetPassword.TabIndex = 6;
            lblForgetPassword.Text = "🔑 Mot de passe oublié ?";
            lblForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtPassword.Location = new System.Drawing.Point(58, 407);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "⌨️ Entrer votre mot de passe";
            txtPassword.Size = new System.Drawing.Size(262, 34);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtUsername.Location = new System.Drawing.Point(65, 310);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "👤 Entrer votre username";
            txtUsername.Size = new System.Drawing.Size(262, 34);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
            lblPassword.Location = new System.Drawing.Point(30, 371);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(312, 28);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mot de passe";
            lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
            lblUsername.Location = new System.Drawing.Point(30, 279);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(312, 28);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Nom d\'utilisateur";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblInstruction.ForeColor = System.Drawing.Color.Gray;
            lblInstruction.Location = new System.Drawing.Point(30, 240);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new System.Drawing.Size(297, 28);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "Veuillez entrer vos identifiants";
            lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
            lblLoginTitle.Location = new System.Drawing.Point(23, 205);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new System.Drawing.Size(297, 35);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(721, 661);
            Controls.Add(gbloginContent);
            Cursor = System.Windows.Forms.Cursors.Default;
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Connexion - POS Restaurant";
            gbloginContent.ResumeLayout(false);
            gbloginContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbloginContent;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgetPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Panel panelEllipseTop;
    }
}