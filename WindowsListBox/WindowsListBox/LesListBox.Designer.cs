namespace WindowsListBox
{
    partial class LesListBox
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
            this.newElemText = new System.Windows.Forms.TextBox();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.TextBox();
            this.selIndexBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.newElemLabel = new System.Windows.Forms.Label();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.selIndexLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.listLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.errorIndex = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddElement = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddElement)).BeginInit();
            this.SuspendLayout();
            // 
            // newElemText
            // 
            this.newElemText.Location = new System.Drawing.Point(12, 35);
            this.newElemText.Name = "newElemText";
            this.newElemText.Size = new System.Drawing.Size(95, 20);
            this.newElemText.TabIndex = 0;
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(141, 34);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(33, 20);
            this.indexBox.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 154);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(95, 95);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Ajout Liste";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(191, 32);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(120, 23);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Sélectionner";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(191, 61);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Vider la liste";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(227, 162);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(33, 20);
            this.countBox.TabIndex = 6;
            // 
            // selIndexBox
            // 
            this.selIndexBox.Location = new System.Drawing.Point(227, 191);
            this.selIndexBox.Name = "selIndexBox";
            this.selIndexBox.Size = new System.Drawing.Size(33, 20);
            this.selIndexBox.TabIndex = 7;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(227, 222);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(84, 20);
            this.textBox.TabIndex = 8;
            // 
            // newElemLabel
            // 
            this.newElemLabel.AutoSize = true;
            this.newElemLabel.Location = new System.Drawing.Point(9, 9);
            this.newElemLabel.Name = "newElemLabel";
            this.newElemLabel.Size = new System.Drawing.Size(82, 13);
            this.newElemLabel.TabIndex = 9;
            this.newElemLabel.Text = "Nouvel Elément";
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Location = new System.Drawing.Point(138, 132);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(54, 13);
            this.propertyLabel.TabIndex = 10;
            this.propertyLabel.Text = "Propriétés";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(138, 229);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(28, 13);
            this.textLabel.TabIndex = 11;
            this.textLabel.Text = "Text";
            // 
            // selIndexLabel
            // 
            this.selIndexLabel.AutoSize = true;
            this.selIndexLabel.Location = new System.Drawing.Point(138, 198);
            this.selIndexLabel.Name = "selIndexLabel";
            this.selIndexLabel.Size = new System.Drawing.Size(75, 13);
            this.selIndexLabel.TabIndex = 12;
            this.selIndexLabel.Text = "SelectedIndex";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(138, 165);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(63, 13);
            this.countLabel.TabIndex = 13;
            this.countLabel.Text = "Items.Count";
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(12, 132);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(37, 13);
            this.listLabel.TabIndex = 14;
            this.listLabel.Text = "LstList";
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(138, 9);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(74, 13);
            this.indexLabel.TabIndex = 15;
            this.indexLabel.Text = "Index Elément";
            // 
            // errorIndex
            // 
            this.errorIndex.ContainerControl = this;
            // 
            // errorAddElement
            // 
            this.errorAddElement.ContainerControl = this;
            // 
            // LesListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.selIndexLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.propertyLabel);
            this.Controls.Add(this.newElemLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.selIndexBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.newElemText);
            this.Name = "LesListBox";
            this.Text = "Les listes et leurs propriétés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LesListBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newElemText;
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.TextBox selIndexBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label newElemLabel;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label selIndexLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.ErrorProvider errorIndex;
        private System.Windows.Forms.ErrorProvider errorAddElement;
    }
}

