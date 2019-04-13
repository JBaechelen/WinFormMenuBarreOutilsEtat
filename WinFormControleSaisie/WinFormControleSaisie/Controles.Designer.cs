namespace WinFormControleSaisie
{
    partial class Controles
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.bouttonValider = new System.Windows.Forms.Button();
            this.bouttonAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.testNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.testDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.testMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.testCP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.testNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(96, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(158, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(96, 120);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(101, 20);
            this.txtMontant.TabIndex = 1;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            this.txtMontant.Leave += new System.EventHandler(this.txtMontant_Leave);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(96, 159);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(60, 20);
            this.txtCP.TabIndex = 2;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            this.txtCP.Leave += new System.EventHandler(this.txtCP_Leave);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(96, 78);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(101, 20);
            this.txtDate.TabIndex = 3;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // bouttonValider
            // 
            this.bouttonValider.Location = new System.Drawing.Point(244, 175);
            this.bouttonValider.Name = "bouttonValider";
            this.bouttonValider.Size = new System.Drawing.Size(75, 23);
            this.bouttonValider.TabIndex = 4;
            this.bouttonValider.Text = "Valider";
            this.bouttonValider.UseVisualStyleBackColor = true;
            this.bouttonValider.Click += new System.EventHandler(this.bouttonValider_Click);
            // 
            // bouttonAnnuler
            // 
            this.bouttonAnnuler.Location = new System.Drawing.Point(244, 204);
            this.bouttonAnnuler.Name = "bouttonAnnuler";
            this.bouttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bouttonAnnuler.TabIndex = 5;
            this.bouttonAnnuler.Text = "Effacer";
            this.bouttonAnnuler.UseVisualStyleBackColor = true;
            this.bouttonAnnuler.Click += new System.EventHandler(this.bouttonAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(JJ/MM/AAAA)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Montant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code Postal";
            // 
            // testNom
            // 
            this.testNom.ContainerControl = this;
            // 
            // testDate
            // 
            this.testDate.ContainerControl = this;
            // 
            // testMontant
            // 
            this.testMontant.ContainerControl = this;
            // 
            // testCP
            // 
            this.testCP.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 239);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bouttonAnnuler);
            this.Controls.Add(this.bouttonValider);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtNom);
            this.Name = "Form1";
            this.Text = "Les contrôles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FermetureFormulaire);
            ((System.ComponentModel.ISupportInitialize)(this.testNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button bouttonValider;
        private System.Windows.Forms.Button bouttonAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider testNom;
        private System.Windows.Forms.ErrorProvider testDate;
        private System.Windows.Forms.ErrorProvider testMontant;
        private System.Windows.Forms.ErrorProvider testCP;
    }
}

