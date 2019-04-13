namespace WinFormSynthese
{
    partial class Synthese
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox = new System.Windows.Forms.ListBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.CapitalBox = new System.Windows.Forms.TextBox();
            this.monthBar = new System.Windows.Forms.HScrollBar();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.taux9 = new System.Windows.Forms.RadioButton();
            this.taux8 = new System.Windows.Forms.RadioButton();
            this.taux7 = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.viderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.nbPayback = new System.Windows.Forms.Label();
            this.paybackLabel = new System.Windows.Forms.Label();
            this.montantLabel = new System.Windows.Forms.Label();
            this.errorCapital = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 185);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(236, 84);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(128, 22);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // CapitalBox
            // 
            this.CapitalBox.Location = new System.Drawing.Point(128, 48);
            this.CapitalBox.Name = "CapitalBox";
            this.CapitalBox.Size = new System.Drawing.Size(100, 20);
            this.CapitalBox.TabIndex = 2;
            this.CapitalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapitalBox_KeyPress);
            // 
            // monthBar
            // 
            this.monthBar.LargeChange = 20;
            this.monthBar.Location = new System.Drawing.Point(188, 104);
            this.monthBar.Maximum = 259;
            this.monthBar.Minimum = 1;
            this.monthBar.Name = "monthBar";
            this.monthBar.Size = new System.Drawing.Size(144, 23);
            this.monthBar.TabIndex = 3;
            this.monthBar.Value = 1;
            this.monthBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.monthBar_Scroll);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.taux9);
            this.groupBox.Controls.Add(this.taux8);
            this.groupBox.Controls.Add(this.taux7);
            this.groupBox.Location = new System.Drawing.Point(363, 22);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(99, 142);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Taux d\'intérêt";
            // 
            // taux9
            // 
            this.taux9.AutoSize = true;
            this.taux9.Location = new System.Drawing.Point(28, 105);
            this.taux9.Name = "taux9";
            this.taux9.Size = new System.Drawing.Size(39, 17);
            this.taux9.TabIndex = 2;
            this.taux9.TabStop = true;
            this.taux9.Tag = "9";
            this.taux9.Text = "9%";
            this.taux9.UseVisualStyleBackColor = true;
            this.taux9.CheckedChanged += new System.EventHandler(this.taux9_CheckedChanged);
            // 
            // taux8
            // 
            this.taux8.AutoSize = true;
            this.taux8.Location = new System.Drawing.Point(28, 66);
            this.taux8.Name = "taux8";
            this.taux8.Size = new System.Drawing.Size(39, 17);
            this.taux8.TabIndex = 1;
            this.taux8.TabStop = true;
            this.taux8.Tag = "8";
            this.taux8.Text = "8%";
            this.taux8.UseVisualStyleBackColor = true;
            this.taux8.CheckedChanged += new System.EventHandler(this.taux8_CheckedChanged);
            // 
            // taux7
            // 
            this.taux7.AutoSize = true;
            this.taux7.Location = new System.Drawing.Point(28, 29);
            this.taux7.Name = "taux7";
            this.taux7.Size = new System.Drawing.Size(39, 17);
            this.taux7.TabIndex = 0;
            this.taux7.TabStop = true;
            this.taux7.Tag = "7";
            this.taux7.Text = "7%";
            this.taux7.UseVisualStyleBackColor = true;
            this.taux7.CheckedChanged += new System.EventHandler(this.taux7_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(492, 33);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // viderButton
            // 
            this.viderButton.Location = new System.Drawing.Point(492, 82);
            this.viderButton.Name = "viderButton";
            this.viderButton.Size = new System.Drawing.Size(74, 23);
            this.viderButton.TabIndex = 6;
            this.viderButton.Text = "Annuler";
            this.viderButton.UseVisualStyleBackColor = true;
            this.viderButton.Click += new System.EventHandler(this.viderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Capital Emprunté";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(150, 104);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(34, 13);
            this.monthLabel.TabIndex = 9;
            this.monthLabel.Text = "durée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Durée en mois du \r\nRemboursement";
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.Location = new System.Drawing.Point(9, 169);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(146, 13);
            this.listBoxLabel.TabIndex = 11;
            this.listBoxLabel.Text = "Périodicité de remboursement";
            // 
            // nbPayback
            // 
            this.nbPayback.AutoSize = true;
            this.nbPayback.Location = new System.Drawing.Point(339, 212);
            this.nbPayback.Name = "nbPayback";
            this.nbPayback.Size = new System.Drawing.Size(63, 13);
            this.nbPayback.TabIndex = 12;
            this.nbPayback.Text = "nb payback";
            // 
            // paybackLabel
            // 
            this.paybackLabel.AutoSize = true;
            this.paybackLabel.Location = new System.Drawing.Point(426, 212);
            this.paybackLabel.Name = "paybackLabel";
            this.paybackLabel.Size = new System.Drawing.Size(89, 13);
            this.paybackLabel.TabIndex = 13;
            this.paybackLabel.Text = "Remboursements";
            // 
            // montantLabel
            // 
            this.montantLabel.AutoSize = true;
            this.montantLabel.Location = new System.Drawing.Point(449, 249);
            this.montantLabel.Name = "montantLabel";
            this.montantLabel.Size = new System.Drawing.Size(45, 13);
            this.montantLabel.TabIndex = 14;
            this.montantLabel.Text = "montant";
            // 
            // errorCapital
            // 
            this.errorCapital.ContainerControl = this;
            // 
            // Synthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 292);
            this.Controls.Add(this.montantLabel);
            this.Controls.Add(this.paybackLabel);
            this.Controls.Add(this.nbPayback);
            this.Controls.Add(this.listBoxLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viderButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.monthBar);
            this.Controls.Add(this.CapitalBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.listBox);
            this.Name = "Synthese";
            this.Text = "Emprunts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Synthese_FormClosing);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCapital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox CapitalBox;
        private System.Windows.Forms.HScrollBar monthBar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton taux9;
        private System.Windows.Forms.RadioButton taux8;
        private System.Windows.Forms.RadioButton taux7;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button viderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label listBoxLabel;
        private System.Windows.Forms.Label nbPayback;
        private System.Windows.Forms.Label paybackLabel;
        private System.Windows.Forms.Label montantLabel;
        private System.Windows.Forms.ErrorProvider errorCapital;
    }
}

