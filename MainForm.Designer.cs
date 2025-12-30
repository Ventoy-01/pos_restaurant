namespace Pos_Restaurant
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelSidebar = new System.Windows.Forms.Panel();
            panelUserInfo = new System.Windows.Forms.Panel();
            lblUserIcon = new System.Windows.Forms.Label();
            lblUserName = new System.Windows.Forms.Label();
            lblUserRole = new System.Windows.Forms.Label();
            btnDeconnecter = new System.Windows.Forms.Button();
            btnSettings = new System.Windows.Forms.Button();
            btnUsers = new System.Windows.Forms.Button();
            btnPaiements = new System.Windows.Forms.Button();
            btnCommandes = new System.Windows.Forms.Button();
            btnClients = new System.Windows.Forms.Button();
            btnMenus = new System.Windows.Forms.Button();
            btnDashboard = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            panelHeader = new System.Windows.Forms.Panel();
            lblDateTime = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            timerDateTime = new System.Windows.Forms.Timer(components);
            panelSidebar.SuspendLayout();
            panelUserInfo.SuspendLayout();
            panelLogo.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            panelSidebar.Controls.Add(panelUserInfo);
            panelSidebar.Controls.Add(btnDeconnecter);
            panelSidebar.Controls.Add(btnSettings);
            panelSidebar.Controls.Add(btnUsers);
            panelSidebar.Controls.Add(btnPaiements);
            panelSidebar.Controls.Add(btnCommandes);
            panelSidebar.Controls.Add(btnClients);
            panelSidebar.Controls.Add(btnMenus);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(250, 768);
            panelSidebar.TabIndex = 0;
            // 
            // panelUserInfo
            // 
            panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            panelUserInfo.Controls.Add(lblUserIcon);
            panelUserInfo.Controls.Add(lblUserName);
            panelUserInfo.Controls.Add(lblUserRole);
            panelUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            panelUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelUserInfo.Location = new System.Drawing.Point(0, 648);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Padding = new System.Windows.Forms.Padding(10);
            panelUserInfo.Size = new System.Drawing.Size(250, 80);
            panelUserInfo.TabIndex = 9;
            // panelUserInfo.Click += new System.EventHandler(panelUserInfo_Click);
            // 
            // lblUserIcon
            // 
            lblUserIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserIcon.ForeColor = System.Drawing.Color.White;
            lblUserIcon.Location = new System.Drawing.Point(10, 10);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new System.Drawing.Size(50, 60);
            lblUserIcon.TabIndex = 2;
            lblUserIcon.Text = "👤";
            lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserName.ForeColor = System.Drawing.Color.White;
            lblUserName.Location = new System.Drawing.Point(70, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(170, 25);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Utilisateur";
            lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserRole.ForeColor = System.Drawing.Color.Silver;
            lblUserRole.Location = new System.Drawing.Point(70, 40);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new System.Drawing.Size(170, 20);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Rôle";
            lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeconnecter
            // 
            btnDeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnDeconnecter.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnDeconnecter.FlatAppearance.BorderSize = 0;
            btnDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeconnecter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDeconnecter.ForeColor = System.Drawing.Color.White;
            // this.btnDeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btnDeconnecter.Image")));
            btnDeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDeconnecter.Location = new System.Drawing.Point(0, 728);
            btnDeconnecter.Name = "btnDeconnecter";
            btnDeconnecter.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnDeconnecter.Size = new System.Drawing.Size(250, 40);
            btnDeconnecter.TabIndex = 8;
            btnDeconnecter.Tag = "menu";
            btnDeconnecter.Text = "🚪  Déconnexion";
            btnDeconnecter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDeconnecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDeconnecter.UseVisualStyleBackColor = false;
            btnDeconnecter.Click += new System.EventHandler(btnDeconnecter_Click);
            // 
            // btnSettings
            // 
            btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSettings.ForeColor = System.Drawing.Color.White;
            // this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSettings.Location = new System.Drawing.Point(0, 360);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnSettings.Size = new System.Drawing.Size(250, 60);
            btnSettings.TabIndex = 7;
            btnSettings.Tag = "menu";
            btnSettings.Text = "⚙️  Paramètres";
            btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += new System.EventHandler(btnSettings_Click);
            // 
            // btnUsers
            // 
            btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnUsers.ForeColor = System.Drawing.Color.White;
            // this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsers.Location = new System.Drawing.Point(0, 300);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnUsers.Size = new System.Drawing.Size(250, 60);
            btnUsers.TabIndex = 6;
            btnUsers.Tag = "menu";
            btnUsers.Text = "👤  Utilisateurs";
            btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += new System.EventHandler(btnUsers_Click);
            // 
            // btnPaiements
            // 
            btnPaiements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnPaiements.Dock = System.Windows.Forms.DockStyle.Top;
            btnPaiements.FlatAppearance.BorderSize = 0;
            btnPaiements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPaiements.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPaiements.ForeColor = System.Drawing.Color.White;
            // this.btnPaiements.Image = ((System.Drawing.Image)(resources.GetObject("btnPaiements.Image")));
            btnPaiements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPaiements.Location = new System.Drawing.Point(0, 240);
            btnPaiements.Name = "btnPaiements";
            btnPaiements.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnPaiements.Size = new System.Drawing.Size(250, 60);
            btnPaiements.TabIndex = 5;
            btnPaiements.Tag = "menu";
            btnPaiements.Text = "💰  Paiements";
            btnPaiements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPaiements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPaiements.UseVisualStyleBackColor = false;
            btnPaiements.Click += new System.EventHandler(btnPaiements_Click);
            // 
            // btnCommandes
            // 
            btnCommandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnCommandes.Dock = System.Windows.Forms.DockStyle.Top;
            btnCommandes.FlatAppearance.BorderSize = 0;
            btnCommandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCommandes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCommandes.ForeColor = System.Drawing.Color.White;
            // this.btnCommandes.Image = ((System.Drawing.Image)(resources.GetObject("btnCommandes.Image")));
            btnCommandes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCommandes.Location = new System.Drawing.Point(0, 180);
            btnCommandes.Name = "btnCommandes";
            btnCommandes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnCommandes.Size = new System.Drawing.Size(250, 60);
            btnCommandes.TabIndex = 4;
            btnCommandes.Tag = "menu";
            btnCommandes.Text = "📋  Commandes";
            btnCommandes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCommandes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCommandes.UseVisualStyleBackColor = false;
            btnCommandes.Click += new System.EventHandler(btnCommandes_Click);
            // 
            // btnClients
            // 
            btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            btnClients.FlatAppearance.BorderSize = 0;
            btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnClients.ForeColor = System.Drawing.Color.White;
            // this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClients.Location = new System.Drawing.Point(0, 120);
            btnClients.Name = "btnClients";
            btnClients.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnClients.Size = new System.Drawing.Size(250, 60);
            btnClients.TabIndex = 3;
            btnClients.Tag = "menu";
            btnClients.Text = "👥  Clients";
            btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += new System.EventHandler(btnClients_Click);
            // 
            // btnMenus
            // 
            btnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnMenus.Dock = System.Windows.Forms.DockStyle.Top;
            btnMenus.FlatAppearance.BorderSize = 0;
            btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMenus.ForeColor = System.Drawing.Color.White;
            // this.btnMenus.Image = ((System.Drawing.Image)(resources.GetObject("btnMenus.Image")));
            btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenus.Location = new System.Drawing.Point(0, 60);
            btnMenus.Name = "btnMenus";
            btnMenus.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnMenus.Size = new System.Drawing.Size(250, 60);
            btnMenus.TabIndex = 2;
            btnMenus.Tag = "menu";
            btnMenus.Text = "🍽️  Menus";
            btnMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMenus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnMenus.UseVisualStyleBackColor = false;
            btnMenus.Click += new System.EventHandler(btnMenus_Click);
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDashboard.ForeColor = System.Drawing.Color.White;
            // this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.Location = new System.Drawing.Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btnDashboard.Size = new System.Drawing.Size(250, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Tag = "menu";
            btnDashboard.Text = "📊  Dashboard";
            btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += new System.EventHandler(btnDashboard_Click);
            // 
            // panelLogo
            // 
            panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(250, 0);
            panelLogo.TabIndex = 0;
            panelLogo.Visible = false;
            // 
            // lblLogo
            // 
            lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(250, 60);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "POS Restaurant";
            lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            panelHeader.Controls.Add(lblDateTime);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(250, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(934, 170);
            panelHeader.TabIndex = 1;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            lblDateTime.Location = new System.Drawing.Point(600, 20);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(320, 60);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "Date et heure";
            lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(500, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DASHBOARD";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(250, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new System.Windows.Forms.Padding(20);
            panelMain.Size = new System.Drawing.Size(934, 688);
            panelMain.TabIndex = 2;
            // 
            // timerDateTime
            // 
            timerDateTime.Enabled = true;
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += new System.EventHandler(timerDateTime_Tick);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1184, 768);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MinimumSize = new System.Drawing.Size(1400, 600);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "POS Restaurant - Dashboard";
            panelSidebar.ResumeLayout(false);
            panelUserInfo.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnCommandes;
        private System.Windows.Forms.Button btnPaiements;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
    }
}