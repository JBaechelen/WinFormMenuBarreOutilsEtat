using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDefilement
{
    public partial class Defilement : Form
    {
        int redValue, greenValue, blueValue;

        public Defilement()
        {
            InitializeComponent();
            redPanel.BackColor = Color.DarkRed;
            greenPanel.BackColor = Color.Green;
            bluePanel.BackColor = Color.Blue;
            SetMaximum();
            Globalization();
        }

        void SetMaximum()
        {
            redBar.Minimum = 0;
            redBar.Maximum = 264;
            greenBar.Minimum = 0;
            greenBar.Maximum = 264;
            blueBar.Minimum = 0;
            blueBar.Maximum = 264;
            redNumber.Maximum = 255;
            greenNumber.Maximum = 255;
            blueNumber.Maximum = 255;            
        }

        void Globalization()
        {
            redValue = (int)redNumber.Value;
            redBar.Value = redValue;
            greenValue = (int)greenNumber.Value;
            greenBar.Value = greenValue;
            blueValue = (int)blueNumber.Value;
            blueBar.Value = blueValue;
            colorPanel.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
        }

        private void redBar_Scroll(object sender, ScrollEventArgs e)
        {
            redNumber.Value = redBar.Value;
            Globalization();
        }

        private void greenBar_Scroll(object sender, ScrollEventArgs e)
        {
            greenNumber.Value = greenBar.Value;
            Globalization();
        }

        private void blueBar_Scroll(object sender, ScrollEventArgs e)
        {
            blueNumber.Value = blueBar.Value;
            Globalization();
        }

        private void redNumber_ValueChanged(object sender, EventArgs e)
        {
            Globalization();
        }

        private void greenNumber_ValueChanged(object sender, EventArgs e)
        {
            Globalization();
        }

        private void blueNumber_ValueChanged(object sender, EventArgs e)
        {
            Globalization();
        }

        private void Defilement_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
