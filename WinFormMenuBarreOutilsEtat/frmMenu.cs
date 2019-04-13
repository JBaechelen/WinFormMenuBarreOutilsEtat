using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormControleSaisie;
using WinFormAdditioneur;
using CheckBoxBoutonRadio;
using WindowsListBox;
using WinFormListBoxComboBox;
using WinFormDefilement;
using WinFormSynthese;

namespace WinFormMenuBarreOutilsEtat
{
    public partial class frmMenu : Form
    {
        string intermediaire, user;
        int nombre = 0;
        Identification frmId;

        public string Intermediaire
        {
            set { intermediaire = value; }
        }

        public frmMenu()
        {
            InitializeComponent();
            frmId = new Identification(this);
            menuPhase1.Enabled = false;
            menuPhase2.Enabled = false;
            menuPhase3.Enabled = false;
            menuFenetres.Enabled = false;
            phase3SplitButton.Enabled = false;
            actionLabel.Text = "";
        }

        public void IdOk()
        {
            menuPhase1.Enabled = true;
            menuPhase2.Enabled = true;
            menuPhase3.Enabled = true;
            menuFenetres.Enabled = true;
            phase3SplitButton.Enabled = true;
            actionLabel.Text = idButton.Text;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Date;
            dateLabel.Text = date.ToString("d");
        }

        private void idButton_Click(object sender, EventArgs e)
        {
            if (menuPhase1.Enabled == false)
            {
                frmId.Show();
            }
            else
            {
                user = frmId.UserNamer;
                MessageBox.Show("Vous êtes déjà connecté en tant qu'" + user + ".", "Erreur");
            }
        }

        private void toolStripIdButton_Click(object sender, EventArgs e)
        {
            if (menuPhase1.Enabled == false)
            {
                frmId.Show();
            }
            else
            {
                user = frmId.UserNamer;
                MessageBox.Show("Vous êtes déjà connecté en tant que " + user + ".", "Erreur");
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "Fin", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void additionneurButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = additionButton.Text;
            Additionneur child = new Additionneur();
            nombre = Application.OpenForms.OfType<Additionneur>().Count();
            child.Text += " N°" + (nombre + 1);
            child.MdiParent = this;
            child.Show();
        }

        private void contrôlesMenu_Click(object sender, EventArgs e)
        {
            actionLabel.Text = contrôlesButton.Text;
            Controles child = new Controles();
            child.MdiParent = this;
            child.Show();
        }

        private void checkBoxButton_Click(object sender, EventArgs e)
        {
            Saisie child = new Saisie(this);
            child.MdiParent = this;
            child.Show();                      
        }

        public void CheckBoxLauncher(object sender, EventArgs e)
        {
            actionLabel.Text = checkBoxButton.Text;
            LesCheckBox child = new LesCheckBox();
            child.MdiParent = this;
            nombre = Application.OpenForms.OfType<LesCheckBox>().Count();
            child.Text = "CheckBox et RadioButton N°" + (nombre + 1);
            child.RecuperationSaisie(intermediaire);
            child.Show();
        }

        private void listBoxButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = listBoxButton.Text;
            LesListBox child = new LesListBox();
            child.MdiParent = this;
            child.Show();
        }

        private void comboBoxButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = comboBoxButton.Text;
            LesComboBox child = new LesComboBox();
            child.MdiParent = this;
            child.Show();
        }

        private void defilementButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = defilementButton.Text;
            Defilement child = new Defilement();
            child.MdiParent = this;
            child.Show();
        }

        private void syntheseButton_Click(object sender, EventArgs e)
        {
            actionLabel.Text = syntheseButton.Text;
            Synthese child = new Synthese();
            child.MdiParent = this;
            child.Show();
        }

        private void checkBoxToolStrip_Click(object sender, EventArgs e)
        {
            checkBoxButton_Click(this, e);
        }

        private void listBoxToolStrip_Click(object sender, EventArgs e)
        {
            listBoxButton_Click(this, e);
        }

        private void comboBoxToolStrip_Click(object sender, EventArgs e)
        {
            comboBoxButton_Click(this, e);
        }

        private void defilementToolStrip_Click(object sender, EventArgs e)
        {
            defilementButton_Click(this, e);
        }

        private void syntheseToolStrip_Click(object sender, EventArgs e)
        {
            syntheseButton_Click(this, e);
        }

        private void cascadeButton_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalButton_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalButton_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void Fermeture(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter?", "Fin", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
