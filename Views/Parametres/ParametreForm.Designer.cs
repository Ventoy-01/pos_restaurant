namespace Pos_Restaurant.Views
{
    partial class ParametreForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametreForm));
            tabControl = new System.Windows.Forms.TabControl();
            tabGeneral = new System.Windows.Forms.TabPage();
            numTVA = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            txtDevise = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtTelephone = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtAdresse = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtNomRestaurant = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabApparence = new System.Windows.Forms.TabPage();
            panelPreview = new System.Windows.Forms.Panel();
            label11 = new System.Windows.Forms.Label();
            comboTheme = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            tabSysteme = new System.Windows.Forms.TabPage();
            btnSauvegarderBD = new System.Windows.Forms.Button();
            btnTestImprimante = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            btnEnregistrer = new System.Windows.Forms.Button();
            btnAnnuler = new System.Windows.Forms.Button();
            btnRestaurer = new System.Windows.Forms.Button();
            tabControl.SuspendLayout();
            tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTVA).BeginInit();
            tabApparence.SuspendLayout();
            tabSysteme.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabGeneral);
            tabControl.Controls.Add(tabApparence);
            tabControl.Controls.Add(tabSysteme);
            tabControl.Location = new System.Drawing.Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(760, 450);
            tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(numTVA);
            tabGeneral.Controls.Add(label6);
            tabGeneral.Controls.Add(txtDevise);
            tabGeneral.Controls.Add(label5);
            tabGeneral.Controls.Add(txtTelephone);
            tabGeneral.Controls.Add(label4);
            tabGeneral.Controls.Add(txtAdresse);
            tabGeneral.Controls.Add(label3);
            tabGeneral.Controls.Add(txtNomRestaurant);
            tabGeneral.Controls.Add(label2);
            tabGeneral.Controls.Add(label1);
            tabGeneral.Location = new System.Drawing.Point(4, 34);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            tabGeneral.Size = new System.Drawing.Size(752, 412);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "⚙️ Général";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // numTVA
            // 
            numTVA.DecimalPlaces = 2;
            numTVA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            numTVA.Location = new System.Drawing.Point(200, 250);
            numTVA.Name = "numTVA";
            numTVA.Size = new System.Drawing.Size(200, 34);
            numTVA.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label6.Location = new System.Drawing.Point(50, 252);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(108, 28);
            label6.TabIndex = 9;
            label6.Text = "📊 TVA (%) :";
            // 
            // txtDevise
            // 
            txtDevise.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtDevise.Location = new System.Drawing.Point(200, 200);
            txtDevise.Name = "txtDevise";
            txtDevise.Size = new System.Drawing.Size(200, 34);
            txtDevise.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label5.Location = new System.Drawing.Point(50, 202);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 28);
            label5.TabIndex = 7;
            label5.Text = "💰 Devise :";
            // 
            // txtTelephone
            // 
            txtTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtTelephone.Location = new System.Drawing.Point(200, 150);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(400, 34);
            txtTelephone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label4.Location = new System.Drawing.Point(50, 152);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 28);
            label4.TabIndex = 5;
            label4.Text = "📱 Téléphone :";
            // 
            // txtAdresse
            // 
            txtAdresse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtAdresse.Location = new System.Drawing.Point(200, 100);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new System.Drawing.Size(400, 34);
            txtAdresse.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.Location = new System.Drawing.Point(50, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 28);
            label3.TabIndex = 3;
            label3.Text = "🏠 Adresse :";
            // 
            // txtNomRestaurant
            // 
            txtNomRestaurant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtNomRestaurant.Location = new System.Drawing.Point(200, 50);
            txtNomRestaurant.Name = "txtNomRestaurant";
            txtNomRestaurant.Size = new System.Drawing.Size(400, 34);
            txtNomRestaurant.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(50, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(137, 28);
            label2.TabIndex = 1;
            label2.Text = "🏪 Nom restaurant :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(50, 300);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(550, 25);
            label1.TabIndex = 0;
            label1.Text = "⚠️ Les modifications seront appliquées au prochain redémarrage.";
            // 
            // tabApparence
            // 
            tabApparence.Controls.Add(panelPreview);
            tabApparence.Controls.Add(label11);
            tabApparence.Controls.Add(comboTheme);
            tabApparence.Controls.Add(label10);
            tabApparence.Controls.Add(label9);
            tabApparence.Location = new System.Drawing.Point(4, 34);
            tabApparence.Name = "tabApparence";
            tabApparence.Padding = new System.Windows.Forms.Padding(3);
            tabApparence.Size = new System.Drawing.Size(752, 412);
            tabApparence.TabIndex = 1;
            tabApparence.Text = "🎨 Apparence";
            tabApparence.UseVisualStyleBackColor = true;
            // 
            // panelPreview
            // 
            panelPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelPreview.Location = new System.Drawing.Point(300, 150);
            panelPreview.Name = "panelPreview";
            panelPreview.Size = new System.Drawing.Size(200, 100);
            panelPreview.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label11.Location = new System.Drawing.Point(300, 120);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(78, 25);
            label11.TabIndex = 3;
            label11.Text = "Aperçu :";
            // 
            // comboTheme
            // 
            comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboTheme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            comboTheme.FormattingEnabled = true;
            comboTheme.Items.AddRange(new object[] {
            "orange",
            "bleu",
            "vert",
            "violet"});
            comboTheme.Location = new System.Drawing.Point(200, 50);
            comboTheme.Name = "comboTheme";
            comboTheme.Size = new System.Drawing.Size(300, 36);
            comboTheme.TabIndex = 0;
            comboTheme.SelectedIndexChanged += comboTheme_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label10.Location = new System.Drawing.Point(50, 52);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(81, 28);
            label10.TabIndex = 1;
            label10.Text = "🎨 Thème :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label9.ForeColor = System.Drawing.Color.Gray;
            label9.Location = new System.Drawing.Point(50, 100);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(450, 25);
            label9.TabIndex = 0;
            label9.Text = "Choisissez la couleur principale de l'interface de l'application.";
            // 
            // tabSysteme
            // 
            tabSysteme.Controls.Add(btnSauvegarderBD);
            tabSysteme.Controls.Add(btnTestImprimante);
            tabSysteme.Controls.Add(label13);
            tabSysteme.Controls.Add(label12);
            tabSysteme.Location = new System.Drawing.Point(4, 34);
            tabSysteme.Name = "tabSysteme";
            tabSysteme.Size = new System.Drawing.Size(752, 412);
            tabSysteme.TabIndex = 2;
            tabSysteme.Text = "💻 Système";
            tabSysteme.UseVisualStyleBackColor = true;
            // 
            // btnSauvegarderBD
            // 
            btnSauvegarderBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            btnSauvegarderBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSauvegarderBD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnSauvegarderBD.ForeColor = System.Drawing.Color.White;
            // btnSauvegarderBD.Image = ((System.Drawing.Image)(resources.GetObject("btnSauvegarderBD.Image")));
            btnSauvegarderBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSauvegarderBD.Location = new System.Drawing.Point(50, 200);
            btnSauvegarderBD.Name = "btnSauvegarderBD";
            btnSauvegarderBD.Size = new System.Drawing.Size(300, 60);
            btnSauvegarderBD.TabIndex = 1;
            btnSauvegarderBD.Text = "💾 Sauvegarder base de données";
            btnSauvegarderBD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSauvegarderBD.UseVisualStyleBackColor = false;
        
            // 
            // btnTestImprimante
            // 
            btnTestImprimante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            btnTestImprimante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTestImprimante.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnTestImprimante.ForeColor = System.Drawing.Color.White;
            // btnTestImprimante.Image = ((System.Drawing.Image)(resources.GetObject("btnTestImprimante.Image")));
            btnTestImprimante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTestImprimante.Location = new System.Drawing.Point(50, 100);
            btnTestImprimante.Name = "btnTestImprimante";
            btnTestImprimante.Size = new System.Drawing.Size(300, 60);
            btnTestImprimante.TabIndex = 0;
            btnTestImprimante.Text = "🖨️ Test d'impression";
            btnTestImprimante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTestImprimante.UseVisualStyleBackColor = false;
            btnTestImprimante.Click += btnTestImprimante_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label13.ForeColor = System.Drawing.Color.Gray;
            label13.Location = new System.Drawing.Point(50, 270);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(500, 25);
            label13.TabIndex = 3;
            label13.Text = "Créez une sauvegarde de vos données pour éviter toute perte.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label12.ForeColor = System.Drawing.Color.Gray;
            label12.Location = new System.Drawing.Point(50, 170);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(450, 25);
            label12.TabIndex = 2;
            label12.Text = "Imprimez une page de test pour vérifier la configuration.";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEnregistrer.Location = new System.Drawing.Point(450, 480);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new System.Drawing.Size(200, 50);
            btnEnregistrer.TabIndex = 1;
            btnEnregistrer.Text = "💾 ENREGISTRER";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAnnuler.Location = new System.Drawing.Point(660, 480);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new System.Drawing.Size(112, 50);
            btnAnnuler.TabIndex = 2;
            btnAnnuler.Text = "❌ ANNULER";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnRestaurer
            // 
            btnRestaurer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            btnRestaurer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnRestaurer.Location = new System.Drawing.Point(12, 480);
            btnRestaurer.Name = "btnRestaurer";
            btnRestaurer.Size = new System.Drawing.Size(200, 50);
            btnRestaurer.TabIndex = 3;
            btnRestaurer.Text = "⚙️ RESTAURER";
            btnRestaurer.UseVisualStyleBackColor = false;
            btnRestaurer.Click += btnRestaurer_Click;
            // 
            // ParametreForm
            // 
            AcceptButton = btnEnregistrer;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnAnnuler;
            ClientSize = new System.Drawing.Size(784, 542);
            Controls.Add(btnRestaurer);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(tabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParametreForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "⚙️ Paramètres";
            tabControl.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTVA).EndInit();
            tabApparence.ResumeLayout(false);
            tabApparence.PerformLayout();
            tabSysteme.ResumeLayout(false);
            tabSysteme.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabApparence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomRestaurant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDevise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTheme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabSysteme;
        private System.Windows.Forms.Button btnSauvegarderBD;
        private System.Windows.Forms.Button btnTestImprimante;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnRestaurer;
    }
}