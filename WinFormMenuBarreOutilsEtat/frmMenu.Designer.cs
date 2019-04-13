namespace WinFormMenuBarreOutilsEtat
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.idButton = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhase1 = new System.Windows.Forms.ToolStripMenuItem();
            this.additionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhase2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôlesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhase3 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.defilementButton = new System.Windows.Forms.ToolStripMenuItem();
            this.syntheseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFenetres = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.barOutils = new System.Windows.Forms.ToolStrip();
            this.toolStripIdButton = new System.Windows.Forms.ToolStripButton();
            this.phase3SplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.checkBoxToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.defilementToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.syntheseToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.dateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar.SuspendLayout();
            this.barOutils.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnection,
            this.menuPhase1,
            this.menuPhase2,
            this.menuPhase3,
            this.menuFenetres});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.MdiWindowListItem = this.menuFenetres;
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(612, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuBar";
            // 
            // menuConnection
            // 
            this.menuConnection.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idButton,
            this.quitButton});
            this.menuConnection.Name = "menuConnection";
            this.menuConnection.Size = new System.Drawing.Size(81, 20);
            this.menuConnection.Text = "Connection";
            // 
            // idButton
            // 
            this.idButton.BackColor = System.Drawing.SystemColors.Control;
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(130, 22);
            this.idButton.Text = "S\'identifier";
            this.idButton.Click += new System.EventHandler(this.idButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(130, 22);
            this.quitButton.Text = "Quitter";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // menuPhase1
            // 
            this.menuPhase1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionButton});
            this.menuPhase1.Name = "menuPhase1";
            this.menuPhase1.Size = new System.Drawing.Size(59, 20);
            this.menuPhase1.Text = "Phase 1";
            // 
            // additionButton
            // 
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(144, 22);
            this.additionButton.Text = "Additionneur";
            this.additionButton.Click += new System.EventHandler(this.additionneurButton_Click);
            // 
            // menuPhase2
            // 
            this.menuPhase2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrôlesButton});
            this.menuPhase2.Name = "menuPhase2";
            this.menuPhase2.Size = new System.Drawing.Size(59, 20);
            this.menuPhase2.Text = "Phase 2";
            // 
            // contrôlesButton
            // 
            this.contrôlesButton.Name = "contrôlesButton";
            this.contrôlesButton.Size = new System.Drawing.Size(125, 22);
            this.contrôlesButton.Text = "Contrôles";
            this.contrôlesButton.Click += new System.EventHandler(this.contrôlesMenu_Click);
            // 
            // menuPhase3
            // 
            this.menuPhase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxButton,
            this.listBoxButton,
            this.comboBoxButton,
            this.defilementButton,
            this.syntheseButton});
            this.menuPhase3.Name = "menuPhase3";
            this.menuPhase3.Size = new System.Drawing.Size(59, 20);
            this.menuPhase3.Text = "Phase 3";
            // 
            // checkBoxButton
            // 
            this.checkBoxButton.Name = "checkBoxButton";
            this.checkBoxButton.Size = new System.Drawing.Size(133, 22);
            this.checkBoxButton.Text = "CheckBox";
            this.checkBoxButton.Click += new System.EventHandler(this.checkBoxButton_Click);
            // 
            // listBoxButton
            // 
            this.listBoxButton.Name = "listBoxButton";
            this.listBoxButton.Size = new System.Drawing.Size(133, 22);
            this.listBoxButton.Text = "ListBox";
            this.listBoxButton.Click += new System.EventHandler(this.listBoxButton_Click);
            // 
            // comboBoxButton
            // 
            this.comboBoxButton.Name = "comboBoxButton";
            this.comboBoxButton.Size = new System.Drawing.Size(133, 22);
            this.comboBoxButton.Text = "ComboBox";
            this.comboBoxButton.Click += new System.EventHandler(this.comboBoxButton_Click);
            // 
            // defilementButton
            // 
            this.defilementButton.Name = "defilementButton";
            this.defilementButton.Size = new System.Drawing.Size(133, 22);
            this.defilementButton.Text = "Defilement";
            this.defilementButton.Click += new System.EventHandler(this.defilementButton_Click);
            // 
            // syntheseButton
            // 
            this.syntheseButton.Name = "syntheseButton";
            this.syntheseButton.Size = new System.Drawing.Size(133, 22);
            this.syntheseButton.Text = "Synthese";
            this.syntheseButton.Click += new System.EventHandler(this.syntheseButton_Click);
            // 
            // menuFenetres
            // 
            this.menuFenetres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeButton,
            this.horizontalButton,
            this.verticalButton});
            this.menuFenetres.Name = "menuFenetres";
            this.menuFenetres.Size = new System.Drawing.Size(63, 20);
            this.menuFenetres.Text = "Fenêtres";
            // 
            // cascadeButton
            // 
            this.cascadeButton.Name = "cascadeButton";
            this.cascadeButton.Size = new System.Drawing.Size(152, 22);
            this.cascadeButton.Text = "Cascade";
            this.cascadeButton.Click += new System.EventHandler(this.cascadeButton_Click);
            // 
            // horizontalButton
            // 
            this.horizontalButton.Name = "horizontalButton";
            this.horizontalButton.Size = new System.Drawing.Size(152, 22);
            this.horizontalButton.Text = "Horizontal";
            this.horizontalButton.Click += new System.EventHandler(this.horizontalButton_Click);
            // 
            // verticalButton
            // 
            this.verticalButton.Name = "verticalButton";
            this.verticalButton.Size = new System.Drawing.Size(152, 22);
            this.verticalButton.Text = "Vertical";
            this.verticalButton.Click += new System.EventHandler(this.verticalButton_Click);
            // 
            // barOutils
            // 
            this.barOutils.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.barOutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIdButton,
            this.phase3SplitButton});
            this.barOutils.Location = new System.Drawing.Point(0, 24);
            this.barOutils.Name = "barOutils";
            this.barOutils.Size = new System.Drawing.Size(612, 25);
            this.barOutils.TabIndex = 2;
            this.barOutils.Text = "barOutils";
            // 
            // toolStripIdButton
            // 
            this.toolStripIdButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripIdButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripIdButton.Image")));
            this.toolStripIdButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripIdButton.Name = "toolStripIdButton";
            this.toolStripIdButton.Size = new System.Drawing.Size(67, 22);
            this.toolStripIdButton.Text = "S\'identifier";
            this.toolStripIdButton.Click += new System.EventHandler(this.toolStripIdButton_Click);
            // 
            // phase3SplitButton
            // 
            this.phase3SplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.phase3SplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStrip,
            this.listBoxToolStrip,
            this.comboBoxToolStrip,
            this.defilementToolStrip,
            this.syntheseToolStrip});
            this.phase3SplitButton.Image = ((System.Drawing.Image)(resources.GetObject("phase3SplitButton.Image")));
            this.phase3SplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.phase3SplitButton.Name = "phase3SplitButton";
            this.phase3SplitButton.Size = new System.Drawing.Size(63, 22);
            this.phase3SplitButton.Text = "Phase 3";
            // 
            // checkBoxToolStrip
            // 
            this.checkBoxToolStrip.Name = "checkBoxToolStrip";
            this.checkBoxToolStrip.Size = new System.Drawing.Size(133, 22);
            this.checkBoxToolStrip.Text = "CheckBox";
            this.checkBoxToolStrip.Click += new System.EventHandler(this.checkBoxToolStrip_Click);
            // 
            // listBoxToolStrip
            // 
            this.listBoxToolStrip.Name = "listBoxToolStrip";
            this.listBoxToolStrip.Size = new System.Drawing.Size(133, 22);
            this.listBoxToolStrip.Text = "ListBox";
            this.listBoxToolStrip.Click += new System.EventHandler(this.listBoxToolStrip_Click);
            // 
            // comboBoxToolStrip
            // 
            this.comboBoxToolStrip.Name = "comboBoxToolStrip";
            this.comboBoxToolStrip.Size = new System.Drawing.Size(133, 22);
            this.comboBoxToolStrip.Text = "ComboBox";
            this.comboBoxToolStrip.Click += new System.EventHandler(this.comboBoxToolStrip_Click);
            // 
            // defilementToolStrip
            // 
            this.defilementToolStrip.Name = "defilementToolStrip";
            this.defilementToolStrip.Size = new System.Drawing.Size(133, 22);
            this.defilementToolStrip.Text = "Defilement";
            this.defilementToolStrip.Click += new System.EventHandler(this.defilementToolStrip_Click);
            // 
            // syntheseToolStrip
            // 
            this.syntheseToolStrip.Name = "syntheseToolStrip";
            this.syntheseToolStrip.Size = new System.Drawing.Size(133, 22);
            this.syntheseToolStrip.Text = "Synthese";
            this.syntheseToolStrip.Click += new System.EventHandler(this.syntheseToolStrip_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateLabel,
            this.actionLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 404);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(612, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusBar";
            // 
            // dateLabel
            // 
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(72, 17);
            this.dateLabel.Text = "Date du jour";
            // 
            // actionLabel
            // 
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(137, 17);
            this.actionLabel.Text = "Derniere action effectuer";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 426);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.barOutils);
            this.Controls.Add(this.menuBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmMenu";
            this.Text = "Creéer des formulaire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fermeture);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.barOutils.ResumeLayout(false);
            this.barOutils.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuConnection;
        private System.Windows.Forms.ToolStripMenuItem menuPhase1;
        private System.Windows.Forms.ToolStripMenuItem menuPhase2;
        private System.Windows.Forms.ToolStripMenuItem menuPhase3;
        private System.Windows.Forms.ToolStripMenuItem menuFenetres;
        private System.Windows.Forms.ToolStripMenuItem idButton;
        private System.Windows.Forms.ToolStripMenuItem quitButton;
        private System.Windows.Forms.ToolStripMenuItem additionButton;
        private System.Windows.Forms.ToolStripMenuItem contrôlesButton;
        private System.Windows.Forms.ToolStripMenuItem checkBoxButton;
        private System.Windows.Forms.ToolStripMenuItem listBoxButton;
        private System.Windows.Forms.ToolStripMenuItem comboBoxButton;
        private System.Windows.Forms.ToolStripMenuItem defilementButton;
        private System.Windows.Forms.ToolStripMenuItem syntheseButton;
        private System.Windows.Forms.ToolStripMenuItem cascadeButton;
        private System.Windows.Forms.ToolStripMenuItem horizontalButton;
        private System.Windows.Forms.ToolStripMenuItem verticalButton;
        private System.Windows.Forms.ToolStrip barOutils;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel dateLabel;
        private System.Windows.Forms.ToolStripStatusLabel actionLabel;
        private System.Windows.Forms.ToolStripButton toolStripIdButton;
        private System.Windows.Forms.ToolStripSplitButton phase3SplitButton;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStrip;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStrip;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStrip;
        private System.Windows.Forms.ToolStripMenuItem defilementToolStrip;
        private System.Windows.Forms.ToolStripMenuItem syntheseToolStrip;

    }
}

