namespace CheckBoxBoutonRadio
{
    partial class LesCheckBox
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
            this.textUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorFond = new System.Windows.Forms.CheckBox();
            this.colorCaractere = new System.Windows.Forms.CheckBox();
            this.casseCaractere = new System.Windows.Forms.CheckBox();
            this.textCopy = new System.Windows.Forms.TextBox();
            this.fondRouge = new System.Windows.Forms.RadioButton();
            this.fondVert = new System.Windows.Forms.RadioButton();
            this.fondBleu = new System.Windows.Forms.RadioButton();
            this.carNoir = new System.Windows.Forms.RadioButton();
            this.carBlanc = new System.Windows.Forms.RadioButton();
            this.carRouge = new System.Windows.Forms.RadioButton();
            this.casseMaj = new System.Windows.Forms.RadioButton();
            this.casseMin = new System.Windows.Forms.RadioButton();
            this.groupFond = new System.Windows.Forms.GroupBox();
            this.groupCaractere = new System.Windows.Forms.GroupBox();
            this.groupCasse = new System.Windows.Forms.GroupBox();
            this.groupChoix = new System.Windows.Forms.GroupBox();
            this.groupFond.SuspendLayout();
            this.groupCaractere.SuspendLayout();
            this.groupCasse.SuspendLayout();
            this.groupChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(24, 35);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(274, 20);
            this.textUser.TabIndex = 0;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tapez votre texte";
            // 
            // colorFond
            // 
            this.colorFond.AutoSize = true;
            this.colorFond.Location = new System.Drawing.Point(6, 19);
            this.colorFond.Name = "colorFond";
            this.colorFond.Size = new System.Drawing.Size(101, 17);
            this.colorFond.TabIndex = 2;
            this.colorFond.Text = "Couleur de fond";
            this.colorFond.UseVisualStyleBackColor = true;
            this.colorFond.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // colorCaractere
            // 
            this.colorCaractere.AutoSize = true;
            this.colorCaractere.Location = new System.Drawing.Point(6, 42);
            this.colorCaractere.Name = "colorCaractere";
            this.colorCaractere.Size = new System.Drawing.Size(130, 17);
            this.colorCaractere.TabIndex = 3;
            this.colorCaractere.Text = "Couleur de caractères";
            this.colorCaractere.UseVisualStyleBackColor = true;
            this.colorCaractere.CheckedChanged += new System.EventHandler(this.colorCaractere_CheckedChanged);
            // 
            // casseCaractere
            // 
            this.casseCaractere.AutoSize = true;
            this.casseCaractere.Location = new System.Drawing.Point(6, 65);
            this.casseCaractere.Name = "casseCaractere";
            this.casseCaractere.Size = new System.Drawing.Size(55, 17);
            this.casseCaractere.TabIndex = 4;
            this.casseCaractere.Text = "Casse";
            this.casseCaractere.UseVisualStyleBackColor = true;
            this.casseCaractere.CheckedChanged += new System.EventHandler(this.casseCaractere_CheckedChanged);
            // 
            // textCopy
            // 
            this.textCopy.Location = new System.Drawing.Point(24, 75);
            this.textCopy.Name = "textCopy";
            this.textCopy.Size = new System.Drawing.Size(243, 20);
            this.textCopy.TabIndex = 7;
            // 
            // fondRouge
            // 
            this.fondRouge.AutoSize = true;
            this.fondRouge.Location = new System.Drawing.Point(6, 19);
            this.fondRouge.Name = "fondRouge";
            this.fondRouge.Size = new System.Drawing.Size(57, 17);
            this.fondRouge.TabIndex = 8;
            this.fondRouge.TabStop = true;
            this.fondRouge.Text = "Rouge";
            this.fondRouge.UseVisualStyleBackColor = true;
            this.fondRouge.CheckedChanged += new System.EventHandler(this.fondRouge_CheckedChanged);
            // 
            // fondVert
            // 
            this.fondVert.AutoSize = true;
            this.fondVert.Location = new System.Drawing.Point(6, 42);
            this.fondVert.Name = "fondVert";
            this.fondVert.Size = new System.Drawing.Size(44, 17);
            this.fondVert.TabIndex = 9;
            this.fondVert.TabStop = true;
            this.fondVert.Text = "Vert";
            this.fondVert.UseVisualStyleBackColor = true;
            this.fondVert.CheckedChanged += new System.EventHandler(this.fondVert_CheckedChanged);
            // 
            // fondBleu
            // 
            this.fondBleu.AutoSize = true;
            this.fondBleu.Location = new System.Drawing.Point(6, 65);
            this.fondBleu.Name = "fondBleu";
            this.fondBleu.Size = new System.Drawing.Size(46, 17);
            this.fondBleu.TabIndex = 10;
            this.fondBleu.TabStop = true;
            this.fondBleu.Text = "Bleu";
            this.fondBleu.UseVisualStyleBackColor = true;
            this.fondBleu.CheckedChanged += new System.EventHandler(this.bleuFond_CheckedChanged);
            // 
            // carNoir
            // 
            this.carNoir.AutoSize = true;
            this.carNoir.Location = new System.Drawing.Point(6, 65);
            this.carNoir.Name = "carNoir";
            this.carNoir.Size = new System.Drawing.Size(44, 17);
            this.carNoir.TabIndex = 13;
            this.carNoir.TabStop = true;
            this.carNoir.Text = "Noir";
            this.carNoir.UseVisualStyleBackColor = true;
            this.carNoir.CheckedChanged += new System.EventHandler(this.carNoir_CheckedChanged);
            // 
            // carBlanc
            // 
            this.carBlanc.AutoSize = true;
            this.carBlanc.Location = new System.Drawing.Point(6, 42);
            this.carBlanc.Name = "carBlanc";
            this.carBlanc.Size = new System.Drawing.Size(52, 17);
            this.carBlanc.TabIndex = 12;
            this.carBlanc.TabStop = true;
            this.carBlanc.Text = "Blanc";
            this.carBlanc.UseVisualStyleBackColor = true;
            this.carBlanc.CheckedChanged += new System.EventHandler(this.carBlanc_CheckedChanged);
            // 
            // carRouge
            // 
            this.carRouge.AutoSize = true;
            this.carRouge.Location = new System.Drawing.Point(6, 19);
            this.carRouge.Name = "carRouge";
            this.carRouge.Size = new System.Drawing.Size(57, 17);
            this.carRouge.TabIndex = 11;
            this.carRouge.TabStop = true;
            this.carRouge.Text = "Rouge";
            this.carRouge.UseVisualStyleBackColor = true;
            this.carRouge.CheckedChanged += new System.EventHandler(this.carRouge_CheckedChanged);
            // 
            // casseMaj
            // 
            this.casseMaj.AutoSize = true;
            this.casseMaj.Location = new System.Drawing.Point(6, 40);
            this.casseMaj.Name = "casseMaj";
            this.casseMaj.Size = new System.Drawing.Size(78, 17);
            this.casseMaj.TabIndex = 15;
            this.casseMaj.TabStop = true;
            this.casseMaj.Text = "Majuscules";
            this.casseMaj.UseVisualStyleBackColor = true;
            this.casseMaj.CheckedChanged += new System.EventHandler(this.casseMaj_CheckedChanged);
            // 
            // casseMin
            // 
            this.casseMin.AutoSize = true;
            this.casseMin.Location = new System.Drawing.Point(6, 17);
            this.casseMin.Name = "casseMin";
            this.casseMin.Size = new System.Drawing.Size(78, 17);
            this.casseMin.TabIndex = 14;
            this.casseMin.TabStop = true;
            this.casseMin.Text = "Minuscules";
            this.casseMin.UseVisualStyleBackColor = true;
            this.casseMin.CheckedChanged += new System.EventHandler(this.casseMin_CheckedChanged);
            // 
            // groupFond
            // 
            this.groupFond.Controls.Add(this.fondRouge);
            this.groupFond.Controls.Add(this.fondVert);
            this.groupFond.Controls.Add(this.fondBleu);
            this.groupFond.Location = new System.Drawing.Point(24, 117);
            this.groupFond.Name = "groupFond";
            this.groupFond.Size = new System.Drawing.Size(87, 90);
            this.groupFond.TabIndex = 19;
            this.groupFond.TabStop = false;
            this.groupFond.Text = "Fond";
            // 
            // groupCaractere
            // 
            this.groupCaractere.Controls.Add(this.carRouge);
            this.groupCaractere.Controls.Add(this.carBlanc);
            this.groupCaractere.Controls.Add(this.carNoir);
            this.groupCaractere.Location = new System.Drawing.Point(117, 117);
            this.groupCaractere.Name = "groupCaractere";
            this.groupCaractere.Size = new System.Drawing.Size(87, 90);
            this.groupCaractere.TabIndex = 20;
            this.groupCaractere.TabStop = false;
            this.groupCaractere.Text = "Caractères";
            // 
            // groupCasse
            // 
            this.groupCasse.Controls.Add(this.casseMin);
            this.groupCasse.Controls.Add(this.casseMaj);
            this.groupCasse.Location = new System.Drawing.Point(210, 142);
            this.groupCasse.Name = "groupCasse";
            this.groupCasse.Size = new System.Drawing.Size(95, 65);
            this.groupCasse.TabIndex = 21;
            this.groupCasse.TabStop = false;
            this.groupCasse.Text = "Casse";
            // 
            // groupChoix
            // 
            this.groupChoix.Controls.Add(this.colorFond);
            this.groupChoix.Controls.Add(this.colorCaractere);
            this.groupChoix.Controls.Add(this.casseCaractere);
            this.groupChoix.Location = new System.Drawing.Point(314, 12);
            this.groupChoix.Name = "groupChoix";
            this.groupChoix.Size = new System.Drawing.Size(151, 86);
            this.groupChoix.TabIndex = 22;
            this.groupChoix.TabStop = false;
            this.groupChoix.Text = "Choix";
            // 
            // LesCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 219);
            this.Controls.Add(this.groupChoix);
            this.Controls.Add(this.groupCasse);
            this.Controls.Add(this.groupCaractere);
            this.Controls.Add(this.groupFond);
            this.Controls.Add(this.textCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUser);
            this.Name = "LesCheckBox";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LesCheckBox_FormClosing);
            this.groupFond.ResumeLayout(false);
            this.groupFond.PerformLayout();
            this.groupCaractere.ResumeLayout(false);
            this.groupCaractere.PerformLayout();
            this.groupCasse.ResumeLayout(false);
            this.groupCasse.PerformLayout();
            this.groupChoix.ResumeLayout(false);
            this.groupChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox colorFond;
        private System.Windows.Forms.CheckBox colorCaractere;
        private System.Windows.Forms.CheckBox casseCaractere;
        private System.Windows.Forms.TextBox textCopy;
        private System.Windows.Forms.RadioButton fondRouge;
        private System.Windows.Forms.RadioButton fondVert;
        private System.Windows.Forms.RadioButton fondBleu;
        private System.Windows.Forms.RadioButton carNoir;
        private System.Windows.Forms.RadioButton carBlanc;
        private System.Windows.Forms.RadioButton carRouge;
        private System.Windows.Forms.RadioButton casseMaj;
        private System.Windows.Forms.RadioButton casseMin;
        private System.Windows.Forms.GroupBox groupFond;
        private System.Windows.Forms.GroupBox groupCaractere;
        private System.Windows.Forms.GroupBox groupCasse;
        private System.Windows.Forms.GroupBox groupChoix;
    }
}

