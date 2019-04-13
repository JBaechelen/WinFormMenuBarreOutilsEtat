namespace WinFormListBoxComboBox
{
    partial class LesComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LesComboBox));
            this.listBox = new System.Windows.Forms.ListBox();
            this.sourceList = new System.Windows.Forms.ComboBox();
            this.addCible = new System.Windows.Forms.Button();
            this.addAllCible = new System.Windows.Forms.Button();
            this.addSource = new System.Windows.Forms.Button();
            this.addAllSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(171, 29);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(137, 160);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedValueChanged);
            // 
            // sourceList
            // 
            this.sourceList.FormattingEnabled = true;
            this.sourceList.Location = new System.Drawing.Point(12, 29);
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(103, 21);
            this.sourceList.TabIndex = 1;
            this.sourceList.DropDown += new System.EventHandler(this.sourceList_DropDown);
            this.sourceList.SelectedValueChanged += new System.EventHandler(this.sourceList_SelectedValueChanged);
            // 
            // addCible
            // 
            this.addCible.Location = new System.Drawing.Point(121, 29);
            this.addCible.Name = "addCible";
            this.addCible.Size = new System.Drawing.Size(44, 23);
            this.addCible.TabIndex = 2;
            this.addCible.Text = ">";
            this.addCible.UseVisualStyleBackColor = true;
            this.addCible.Click += new System.EventHandler(this.addCible_Click);
            // 
            // addAllCible
            // 
            this.addAllCible.Location = new System.Drawing.Point(121, 58);
            this.addAllCible.Name = "addAllCible";
            this.addAllCible.Size = new System.Drawing.Size(44, 23);
            this.addAllCible.TabIndex = 3;
            this.addAllCible.Text = ">>";
            this.addAllCible.UseVisualStyleBackColor = true;
            this.addAllCible.Click += new System.EventHandler(this.addAllCible_Click);
            // 
            // addSource
            // 
            this.addSource.Location = new System.Drawing.Point(121, 137);
            this.addSource.Name = "addSource";
            this.addSource.Size = new System.Drawing.Size(44, 23);
            this.addSource.TabIndex = 4;
            this.addSource.Text = "<";
            this.addSource.UseVisualStyleBackColor = true;
            this.addSource.Click += new System.EventHandler(this.addSource_Click);
            // 
            // addAllSource
            // 
            this.addAllSource.Location = new System.Drawing.Point(121, 166);
            this.addAllSource.Name = "addAllSource";
            this.addAllSource.Size = new System.Drawing.Size(44, 23);
            this.addAllSource.TabIndex = 5;
            this.addAllSource.Text = "<<";
            this.addAllSource.UseVisualStyleBackColor = true;
            this.addAllSource.Click += new System.EventHandler(this.addAllSource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cible";
            // 
            // moveUp
            // 
            this.moveUp.Image = ((System.Drawing.Image)(resources.GetObject("moveUp.Image")));
            this.moveUp.Location = new System.Drawing.Point(202, 195);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(35, 37);
            this.moveUp.TabIndex = 8;
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.Image = ((System.Drawing.Image)(resources.GetObject("moveDown.Image")));
            this.moveDown.Location = new System.Drawing.Point(243, 195);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(35, 37);
            this.moveDown.TabIndex = 9;
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // LesComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 262);
            this.Controls.Add(this.moveDown);
            this.Controls.Add(this.moveUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAllSource);
            this.Controls.Add(this.addSource);
            this.Controls.Add(this.addAllCible);
            this.Controls.Add(this.addCible);
            this.Controls.Add(this.sourceList);
            this.Controls.Add(this.listBox);
            this.Name = "LesComboBox";
            this.Text = "Les listes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LesComboBox_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox sourceList;
        private System.Windows.Forms.Button addCible;
        private System.Windows.Forms.Button addAllCible;
        private System.Windows.Forms.Button addSource;
        private System.Windows.Forms.Button addAllSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
    }
}

