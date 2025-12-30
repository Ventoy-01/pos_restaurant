namespace Pos_Restaurant.Views.Paiements
{
    partial class AjouterPaiementForm
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
            lblIdCommande = new System.Windows.Forms.Label();
            comboIdCommande = new System.Windows.Forms.ComboBox();
            lblMontant = new System.Windows.Forms.Label();
            txtMontant = new System.Windows.Forms.TextBox();
            lblStatutPrix = new System.Windows.Forms.Label();
            lblDatePaiement = new System.Windows.Forms.Label();
            dtpDatePaiement = new System.Windows.Forms.DateTimePicker();
            lblModePaiement = new System.Windows.Forms.Label();
            comboModePaiement = new System.Windows.Forms.ComboBox();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnVider = new System.Windows.Forms.Button();
            lblMessage = new System.Windows.Forms.Label();
            lblMontantHTG = new System.Windows.Forms.Label();
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
            lblTitre.Size = new System.Drawing.Size(274, 33);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "NOUVEAU PAIEMENT";
            // 
            // lblIdCommande
            // 
            lblIdCommande.AutoSize = true;
            lblIdCommande.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblIdCommande.Location = new System.Drawing.Point(50, 90);
            lblIdCommande.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblIdCommande.Name = "lblIdCommande";
            lblIdCommande.Size = new System.Drawing.Size(145, 28);
            lblIdCommande.TabIndex = 1;
            lblIdCommande.Text = "Commande :";
            // 
            // comboIdCommande
            // 
            comboIdCommande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboIdCommande.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            comboIdCommande.FormattingEnabled = true;
            comboIdCommande.Location = new System.Drawing.Point(250, 87);
            comboIdCommande.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboIdCommande.Name = "comboIdCommande";
            comboIdCommande.Size = new System.Drawing.Size(414, 36);
            comboIdCommande.TabIndex = 1;
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblMontant.Location = new System.Drawing.Point(50, 150);
            lblMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new System.Drawing.Size(86, 28);
            lblMontant.TabIndex = 3;
            lblMontant.Text = "Montant :";
            // 
            // txtMontant
            // 
            txtMontant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtMontant.Location = new System.Drawing.Point(250, 147);
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
            lblMontantHTG.Location = new System.Drawing.Point(610, 150);
            lblMontantHTG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMontantHTG.Name = "lblMontantHTG";
            lblMontantHTG.Size = new System.Drawing.Size(54, 28);
            lblMontantHTG.TabIndex = 5;
            lblMontantHTG.Text = "HTG";
            //

            // lblStatutPrix
            lblStatutPrix.AutoSize = true;
            lblStatutPrix.Location = new System.Drawing.Point(380, 175);
            lblStatutPrix.Name = "lblStatutPrix";
            lblStatutPrix.Size = new System.Drawing.Size(0, 13);

            // 
            // lblDatePaiement
            // 
            lblDatePaiement.AutoSize = true;
            lblDatePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblDatePaiement.Location = new System.Drawing.Point(50, 210);
            lblDatePaiement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDatePaiement.Name = "lblDatePaiement";
            lblDatePaiement.Size = new System.Drawing.Size(138, 28);
            lblDatePaiement.TabIndex = 6;
            lblDatePaiement.Text = "Date paiement :";
            // 
            // dtpDatePaiement
            // 
            dtpDatePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            dtpDatePaiement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDatePaiement.Location = new System.Drawing.Point(250, 207);
            dtpDatePaiement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dtpDatePaiement.Name = "dtpDatePaiement";
            dtpDatePaiement.Size = new System.Drawing.Size(414, 34);
            dtpDatePaiement.TabIndex = 3;
            // 
            // lblModePaiement
            // 
            lblModePaiement.AutoSize = true;
            lblModePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblModePaiement.Location = new System.Drawing.Point(50, 270);
            lblModePaiement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblModePaiement.Name = "lblModePaiement";
            lblModePaiement.Size = new System.Drawing.Size(152, 28);
            lblModePaiement.TabIndex = 8;
            lblModePaiement.Text = "Mode paiement :";
            // 
            // comboModePaiement
            // 
            comboModePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboModePaiement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            comboModePaiement.FormattingEnabled = true;
            comboModePaiement.Items.AddRange(new object[] { "Cash", "Carte Debit", "Carte Credit", "Cheque" });
            comboModePaiement.Location = new System.Drawing.Point(250, 267);
            comboModePaiement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            comboModePaiement.Name = "comboModePaiement";
            comboModePaiement.Size = new System.Drawing.Size(414, 36);
            comboModePaiement.TabIndex = 4;
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
            // btnVider
            // 
            btnVider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnVider.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnVider.Location = new System.Drawing.Point(464, 340);
            btnVider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnVider.Name = "btnVider";
            btnVider.Size = new System.Drawing.Size(200, 67);
            btnVider.TabIndex = 6;
            btnVider.Text = "VIDER";
            btnVider.UseVisualStyleBackColor = false;
            btnVider.Click += btnVider_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = System.Drawing.Color.Honeydew;
            lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblMessage.Location = new System.Drawing.Point(50, 430);
            lblMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(615, 75);
            lblMessage.TabIndex = 12;
            lblMessage.Text = "Prêt à enregistrer...";
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AjouterPaiementForm
            // 
            AcceptButton = btnEnregistrer;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(723, 530);
            Controls.Add(lblMessage);
            Controls.Add(btnVider);
            Controls.Add(btnEnregistrer);
            Controls.Add(comboModePaiement);
            Controls.Add(lblModePaiement);
            Controls.Add(dtpDatePaiement);
            Controls.Add(lblDatePaiement);
            Controls.Add(lblMontantHTG);
            Controls.Add(txtMontant);
            Controls.Add(lblMontant);
            Controls.Add(lblStatutPrix);
            Controls.Add(comboIdCommande);
            Controls.Add(lblIdCommande);
            Controls.Add(lblTitre);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AjouterPaiementForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Ajouter un paiement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblIdCommande;
        private System.Windows.Forms.ComboBox comboIdCommande;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblMontantHTG;
        private System.Windows.Forms.Label lblStatutPrix;
        private System.Windows.Forms.Label lblDatePaiement;
        private System.Windows.Forms.DateTimePicker dtpDatePaiement;
        private System.Windows.Forms.Label lblModePaiement;
        private System.Windows.Forms.ComboBox comboModePaiement;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Label lblMessage;
    }
}