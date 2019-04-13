using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMenuBarreOutilsEtat
{
    public partial class Saisie : Form
    {
        public Saisie()
        {
            InitializeComponent();
        }

        frmMenu _parent = null;

        public Saisie(frmMenu parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            if (leTexte.Text != "")
            {
                _parent.Intermediaire = leTexte.Text;
                _parent.CheckBoxLauncher(this, e);
                this.Hide();
            }
        }

        // Permet de reouvrir les form
        private void Saisie_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            leTexte.Text = "";
            this.Hide();
        }
    }
}
