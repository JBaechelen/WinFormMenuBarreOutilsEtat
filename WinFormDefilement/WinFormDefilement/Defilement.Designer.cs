namespace WinFormDefilement
{
    partial class Defilement
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
            this.redNumber = new System.Windows.Forms.NumericUpDown();
            this.redBar = new System.Windows.Forms.HScrollBar();
            this.greenBar = new System.Windows.Forms.HScrollBar();
            this.greenNumber = new System.Windows.Forms.NumericUpDown();
            this.blueBar = new System.Windows.Forms.HScrollBar();
            this.blueNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redPanel = new System.Windows.Forms.Panel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.bluePanel = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.redNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // redNumber
            // 
            this.redNumber.Location = new System.Drawing.Point(258, 23);
            this.redNumber.Name = "redNumber";
            this.redNumber.Size = new System.Drawing.Size(71, 20);
            this.redNumber.TabIndex = 0;
            this.redNumber.ValueChanged += new System.EventHandler(this.redNumber_ValueChanged);
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(54, 23);
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(201, 20);
            this.redBar.TabIndex = 1;
            this.redBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redBar_Scroll);
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(54, 68);
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(201, 20);
            this.greenBar.TabIndex = 3;
            this.greenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenBar_Scroll);
            // 
            // greenNumber
            // 
            this.greenNumber.Location = new System.Drawing.Point(258, 68);
            this.greenNumber.Name = "greenNumber";
            this.greenNumber.Size = new System.Drawing.Size(71, 20);
            this.greenNumber.TabIndex = 2;
            this.greenNumber.ValueChanged += new System.EventHandler(this.greenNumber_ValueChanged);
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(54, 113);
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(201, 20);
            this.blueBar.TabIndex = 5;
            this.blueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueBar_Scroll);
            // 
            // blueNumber
            // 
            this.blueNumber.Location = new System.Drawing.Point(258, 113);
            this.blueNumber.Name = "blueNumber";
            this.blueNumber.Size = new System.Drawing.Size(71, 20);
            this.blueNumber.TabIndex = 4;
            this.blueNumber.ValueChanged += new System.EventHandler(this.blueNumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rouge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bleu";
            // 
            // redPanel
            // 
            this.redPanel.Location = new System.Drawing.Point(335, 23);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(77, 20);
            this.redPanel.TabIndex = 9;
            // 
            // greenPanel
            // 
            this.greenPanel.Location = new System.Drawing.Point(335, 68);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(77, 20);
            this.greenPanel.TabIndex = 10;
            // 
            // bluePanel
            // 
            this.bluePanel.Location = new System.Drawing.Point(335, 113);
            this.bluePanel.Name = "bluePanel";
            this.bluePanel.Size = new System.Drawing.Size(77, 20);
            this.bluePanel.TabIndex = 10;
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(15, 151);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(397, 74);
            this.colorPanel.TabIndex = 11;
            // 
            // Defilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 237);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.greenPanel);
            this.Controls.Add(this.bluePanel);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueBar);
            this.Controls.Add(this.blueNumber);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.greenNumber);
            this.Controls.Add(this.redBar);
            this.Controls.Add(this.redNumber);
            this.Name = "Defilement";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Defilement_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.redNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown redNumber;
        private System.Windows.Forms.HScrollBar redBar;
        private System.Windows.Forms.HScrollBar greenBar;
        private System.Windows.Forms.NumericUpDown greenNumber;
        private System.Windows.Forms.HScrollBar blueBar;
        private System.Windows.Forms.NumericUpDown blueNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.Panel bluePanel;
        private System.Windows.Forms.Panel colorPanel;
    }
}

