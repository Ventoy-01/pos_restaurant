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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPaiements = new System.Windows.Forms.Button();
            this.btnCommandes = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSidebar.Controls.Add(this.panelUserInfo);
            this.panelSidebar.Controls.Add(this.btnDeconnecter);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnUsers);
            this.panelSidebar.Controls.Add(this.btnPaiements);
            this.panelSidebar.Controls.Add(this.btnCommandes);
            this.panelSidebar.Controls.Add(this.btnClients);
            this.panelSidebar.Controls.Add(this.btnMenus);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 768);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelUserInfo.Controls.Add(this.lblUserIcon);
            this.panelUserInfo.Controls.Add(this.lblUserName);
            this.panelUserInfo.Controls.Add(this.lblUserRole);
            this.panelUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 648);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Padding = new System.Windows.Forms.Padding(10);
            this.panelUserInfo.Size = new System.Drawing.Size(250, 80);
            this.panelUserInfo.TabIndex = 9;
            this.panelUserInfo.Click += new System.EventHandler(this.panelUserInfo_Click);
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIcon.ForeColor = System.Drawing.Color.White;
            this.lblUserIcon.Location = new System.Drawing.Point(10, 10);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(50, 60);
            this.lblUserIcon.TabIndex = 2;
            this.lblUserIcon.Text = "👤";
            this.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(70, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(170, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Utilisateur";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.Silver;
            this.lblUserRole.Location = new System.Drawing.Point(70, 40);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(170, 20);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Rôle";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeconnecter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnecter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnecter.ForeColor = System.Drawing.Color.White;
            // this.btnDeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btnDeconnecter.Image")));
            this.btnDeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnecter.Location = new System.Drawing.Point(0, 728);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDeconnecter.Size = new System.Drawing.Size(250, 40);
            this.btnDeconnecter.TabIndex = 8;
            this.btnDeconnecter.Tag = "menu";
            this.btnDeconnecter.Text = "🚪  Déconnexion";
            this.btnDeconnecter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeconnecter.UseVisualStyleBackColor = false;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            // this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 360);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(250, 60);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Tag = "menu";
            this.btnSettings.Text = "⚙️  Paramètres";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            // this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 300);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(250, 60);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Tag = "menu";
            this.btnUsers.Text = "👤  Utilisateurs";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPaiements
            // 
            this.btnPaiements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaiements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaiements.FlatAppearance.BorderSize = 0;
            this.btnPaiements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaiements.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaiements.ForeColor = System.Drawing.Color.White;
            // this.btnPaiements.Image = ((System.Drawing.Image)(resources.GetObject("btnPaiements.Image")));
            this.btnPaiements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaiements.Location = new System.Drawing.Point(0, 240);
            this.btnPaiements.Name = "btnPaiements";
            this.btnPaiements.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPaiements.Size = new System.Drawing.Size(250, 60);
            this.btnPaiements.TabIndex = 5;
            this.btnPaiements.Tag = "menu";
            this.btnPaiements.Text = "💰  Paiements";
            this.btnPaiements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaiements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaiements.UseVisualStyleBackColor = false;
            this.btnPaiements.Click += new System.EventHandler(this.btnPaiements_Click);
            // 
            // btnCommandes
            // 
            this.btnCommandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCommandes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommandes.FlatAppearance.BorderSize = 0;
            this.btnCommandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommandes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommandes.ForeColor = System.Drawing.Color.White;
            // this.btnCommandes.Image = ((System.Drawing.Image)(resources.GetObject("btnCommandes.Image")));
            this.btnCommandes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommandes.Location = new System.Drawing.Point(0, 180);
            this.btnCommandes.Name = "btnCommandes";
            this.btnCommandes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCommandes.Size = new System.Drawing.Size(250, 60);
            this.btnCommandes.TabIndex = 4;
            this.btnCommandes.Tag = "menu";
            this.btnCommandes.Text = "📋  Commandes";
            this.btnCommandes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommandes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommandes.UseVisualStyleBackColor = false;
            this.btnCommandes.Click += new System.EventHandler(this.btnCommandes_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.White;
            // this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 120);
            this.btnClients.Name = "btnClients";
            this.btnClients.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnClients.Size = new System.Drawing.Size(250, 60);
            this.btnClients.TabIndex = 3;
            this.btnClients.Tag = "menu";
            this.btnClients.Text = "👥  Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnMenus
            // 
            this.btnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenus.FlatAppearance.BorderSize = 0;
            this.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenus.ForeColor = System.Drawing.Color.White;
            // this.btnMenus.Image = ((System.Drawing.Image)(resources.GetObject("btnMenus.Image")));
            this.btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.Location = new System.Drawing.Point(0, 60);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenus.Size = new System.Drawing.Size(250, 60);
            this.btnMenus.TabIndex = 2;
            this.btnMenus.Tag = "menu";
            this.btnMenus.Text = "🍽️  Menus";
            this.btnMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenus.UseVisualStyleBackColor = false;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            // this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(250, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Tag = "menu";
            this.btnDashboard.Text = "📊  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 0);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Visible = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(250, 60);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "POS Restaurant";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblDateTime);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(934, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDateTime.Location = new System.Drawing.Point(600, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(320, 40);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Date et heure";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(934, 688);
            this.panelMain.TabIndex = 2;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 768);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS Restaurant - Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelSidebar.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

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