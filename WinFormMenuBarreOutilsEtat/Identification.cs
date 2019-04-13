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
    public partial class Identification : Form
    {
        string userName;

        public string UserNamer
        {
            get { return userName; }
        }

        public Identification()
        {
            InitializeComponent();
        }

        frmMenu frm = null;

        public Identification(frmMenu _parent)
        {
            InitializeComponent();
            frm = _parent;
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            loginBox.Text = "";
            passBox.Text = "";
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == passBox.Text)
            {
                if (loginBox.Text != "")
                {
                    idError.SetError(passBox, "");
                    idEmptyError.SetError(loginBox, "");
                    userName = loginBox.Text;
                    frm.IdOk();
                    this.Close();
                }
                else
                {
                    idEmptyError.SetError(loginBox, "Veuillez entrer un identifiant.");
                }                
            }
            else
            {
                idEmptyError.SetError(loginBox, "");
                idError.SetError(passBox, "Le password doit être similaire à l'indentifiant.");
            }
        }
    }
}
