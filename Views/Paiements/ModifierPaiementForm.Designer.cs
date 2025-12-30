namespace Pos_Restaurant.Views.Paiements
{
    partial class ModifierPaiementForm
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
            lblTitre = new System.Windows.Forms.Label();
            lblIdPaiement = new System.Windows.Forms.Label();
            lblIdCommande = new System.Windows.Forms.Label();
            txtIdCommande = new System.Windows.Forms.TextBox();
            lblMontant = new System.Windows.Forms.Label();
            txtMontant = new System.Windows.Forms.TextBox();
            lblMontantHTG = new System.Windows.Forms.Label();
            lblDatePaiement = new System.Windows.Forms.Label();
            dtpDatePaiement = new System.Windows.Forms.DateTimePicker();
            lblModePaiement = new System.Windows.Forms.Label();
            comboModePaiement = new System.Windows.Forms.ComboBox();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnAnnuler = new System.Windows.Forms.Button();
            lblStatutPrix = new System.Windows.Forms.Label();
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
            lblTitre.Size = new System.Drawing.Size(271, 33);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "MODIFIER PAIEMENT";
            // 
            // lblIdPaiement
            // 
            lblIdPaiement.AutoSize = true;
            lblIdPaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblIdPaiement.ForeColor = System.Drawing.Color.DarkBlue;
            lblIdPaiement.Location = new System.Drawing.Point(50, 70);
            lblIdPaiement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblIdPaiement.Name = "lblIdPaiement";
            lblIdPaiement.Size = new System.Drawing.Size(37, 28);
            lblIdPaiement.TabIndex = 1;
            lblIdPaiement.Text = "ID:";
            
            // lblStatutPrix
            lblStatutPrix.AutoSize = true;
            lblStatutPrix.Location = new System.Drawing.Point(380, 175);
            lblStatutPrix.Name = "lblStatutPrix";
            lblStatutPrix.Size = new System.Drawing.Size(0, 13);

            // 
            // lblIdCommande
            // 
            lblIdCommande.AutoSize = true;
            lblIdCommande.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblIdCommande.Location = new System.Drawing.Point(50, 120);
            lblIdCommande.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblIdCommande.Name = "lblIdCommande";
            lblIdCommande.Size = new System.Drawing.Size(145, 28);
            lblIdCommande.TabIndex = 2;
            lblIdCommande.Text = "ID Commande :";
            // 
            // txtIdCommande
            // 
            txtIdCommande.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtIdCommande.Location = new System.Drawing.Point(250, 117);
            txtIdCommande.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtIdCommande.Name = "txtIdCommande";
            txtIdCommande.ReadOnly = true;
            txtIdCommande.Size = new System.Drawing.Size(414, 34);
            txtIdCommande.TabIndex = 1;
            txtIdCommande.KeyPress += txtIdCommande_KeyPress;
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMontant.Location = new System.Drawing.Point(50, 180);
            lblMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new System.Drawing.Size(86, 28);
            lblMontant.TabIndex = 4;
            lblMontant.Text = "Montant :";
            // 
            // txtMontant
            // 
            txtMontant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtMontant.Location = new System.Drawing.Point(250, 177);
            txtMontant.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new System.Drawing.Size(350, 34);
            txtMontant.TabIndex = 2;
            txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtMontant.KeyPress += txtMontant_KeyPress;
            txtMontant.TextChanged += txtMontant_TextChanged;
            // 
            // lblMontantHTG
            // 
            lblMontantHTG.AutoSize = true;
            lblMontantHTG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMontantHTG.Location = new System.Drawing.Point(610, 180);
            lblMontantHTG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMontantHTG.Name = "lblMontantHTG";
            lblMontantHTG.Size = new System.Drawing.Size(54, 28);
            lblMontantHTG.TabIndex = 6;
            lblMontantHTG.Text = "HTG";
            // 
            // lblDatePaiement
            // 
            lblDatePaiement.AutoSize = true;
            lblDatePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblDatePaiement.Location = new System.Drawing.Point(50, 240);
            lblDatePaiement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDatePaiement.Name = "lblDatePaiement";
            lblDatePaiement.Size = new System.Drawing.Size(138, 28);
            lblDatePaiement.TabIndex = 7;
            lblDatePaiement.Text = "Date paiement :";
            // 
            // dtpDatePaiement
            // 
            dtpDatePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            dtpDatePaiement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDatePaiement.Location = new System.Drawing.Point(250, 237);
            dtpDatePaiement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dtpDatePaiement.Name = "dtpDatePaiement";
            dtpDatePaiement.Size = new System.Drawing.Size(414, 34);
            dtpDatePaiement.TabIndex = 3;
            // 
            // lblModePaiement
            // 
            lblModePaiement.AutoSize = true;
            lblModePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblModePaiement.Location = new System.Drawing.Point(50, 300);
            lblModePaiement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblModePaiement.Name = "lblModePaiement";
            lblModePaiement.Size = new System.Drawing.Size(152, 28);
            lblModePaiement.TabIndex = 9;
            lblModePaiement.Text = "Mode paiement :";
            // 
            // comboModePaiement
            // 
            comboModePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboModePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            comboModePaiement.FormattingEnabled = true;
            comboModePaiement.Items.AddRange(new object[] { "Cash", "Carte debit", "Carte Credit", "Cheque" });
            comboModePaiement.Location = new System.Drawing.Point(250, 297);
            comboModePaiement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboModePaiement.Name = "comboModePaiement";
            comboModePaiement.Size = new System.Drawing.Size(414, 36);
            comboModePaiement.TabIndex = 4;

            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEnregistrer.Location = new System.Drawing.Point(250, 430);
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
            btnAnnuler.Location = new System.Drawing.Point(464, 430);
            btnAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new System.Drawing.Size(200, 67);
            btnAnnuler.TabIndex = 7;
            btnAnnuler.Text = "ANNULER";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // ModifierPaiementForm
            // 
            AcceptButton = btnEnregistrer;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnAnnuler;
            ClientSize = new System.Drawing.Size(723, 520);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(comboModePaiement);
            Controls.Add(lblModePaiement);
            Controls.Add(dtpDatePaiement);
            Controls.Add(lblDatePaiement);
            Controls.Add(lblMontantHTG);
            Controls.Add(txtMontant);
            Controls.Add(lblMontant);
            Controls.Add(txtIdCommande);
            Controls.Add(lblIdCommande);
            Controls.Add(lblIdPaiement);
            Controls.Add(lblTitre);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierPaiementForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Modifier un paiement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStatutPrix;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblIdPaiement;
        private System.Windows.Forms.Label lblIdCommande;
        private System.Windows.Forms.TextBox txtIdCommande;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblMontantHTG;
        private System.Windows.Forms.Label lblDatePaiement;
        private System.Windows.Forms.DateTimePicker dtpDatePaiement;
        private System.Windows.Forms.Label lblModePaiement;
        private System.Windows.Forms.ComboBox comboModePaiement;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}