namespace WinFormMenuBarreOutilsEtat
{
    partial class Saisie
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
            this.validButton = new System.Windows.Forms.Button();
            this.leTexte = new System.Windows.Forms.TextBox();
            this.leTexteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validButton
            // 
            this.validButton.Location = new System.Drawing.Point(218, 28);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(75, 23);
            this.validButton.TabIndex = 0;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // leTexte
            // 
            this.leTexte.Location = new System.Drawing.Point(12, 31);
            this.leTexte.Name = "leTexte";
            this.leTexte.Size = new System.Drawing.Size(200, 20);
            this.leTexte.TabIndex = 1;
            // 
            // leTexteLabel
            // 
            this.leTexteLabel.AutoSize = true;
            this.leTexteLabel.Location = new System.Drawing.Point(13, 15);
            this.leTexteLabel.Name = "leTexteLabel";
            this.leTexteLabel.Size = new System.Drawing.Size(90, 13);
            this.leTexteLabel.TabIndex = 2;
            this.leTexteLabel.Text = "Tapez votre texte";
            // 
            // Saisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 66);
            this.Controls.Add(this.leTexteLabel);
            this.Controls.Add(this.leTexte);
            this.Controls.Add(this.validButton);
            this.Name = "Saisie";
            this.Text = "Saisie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Saisie_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.TextBox leTexte;
        private System.Windows.Forms.Label leTexteLabel;
    }
}