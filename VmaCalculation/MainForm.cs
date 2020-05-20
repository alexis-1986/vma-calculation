using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace VmaCalculation
{
    public partial class Form1 : Form
    {

        private double _distance;
        private double _min;
        private double _sec;
        private int _nbRepet; 

        public Form1()
        {
            InitializeComponent();
            txtVma.Enabled = false;
        }

        private void CmdGo_Click(object sender, EventArgs e)
        {
            bool paramOK = true;
            StringBuilder errMes = new StringBuilder();

            if (!double.TryParse(txtDistance.Text, out _distance) || _distance <= 0)
            {
                errMes.AppendLine("Distance non valide ...");
                paramOK = false;
            }

            if (!double.TryParse(txtMin.Text, out _min) || _min < 0)
            {
                errMes.AppendLine("Minute(s) non valide(s) ...");
                paramOK = false;
            }

            if (!double.TryParse(txtSec.Text, out _sec) || _sec < 0)
            {
                errMes.AppendLine("Second(s) non valide(s) ...");
                paramOK = false;
            }

            if (!int.TryParse(txtNbRepetitions.Text, out _nbRepet) || _nbRepet <= 0)
            {
                errMes.AppendLine("Nb répétition(s) non valide ...");
                paramOK = false;
            }


            if (!paramOK)
            {
                MessageBox.Show(errMes.ToString());
                return;
            }

          
            Lois l = new Lois();
            txtVma.Enabled = true;
            txtVma.Text = l.CalculeVma(_distance, _min, _sec, _nbRepet);

          //  Debug.WriteLine("Index: " + res.IndexOf(_nbRepet));
        }

        private void txtDistance_Validated(object sender, EventArgs e)
        {
           // if (txtDistance.Text == string.Empty)
                txtVma.Text = string.Empty;
                txtVma.Enabled = false;
        }

        private void txtMin_Validated(object sender, EventArgs e)
        {
           // if (txtMin.Text == string.Empty)
                txtVma.Text = string.Empty;
                txtVma.Enabled = false;
        }

        private void txtSec_Validated(object sender, EventArgs e)
        {
           // if (txtSec.Text == string.Empty)
                txtVma.Text = string.Empty;
                txtVma.Enabled = false;
                
        }

        private void txtNbRepetitions_Validated(object sender, EventArgs e)
        {
          //  if (txtNbRepetitions.Text == string.Empty)
                txtVma.Text = string.Empty;
                txtVma.Enabled = false;
        }

        private void txtDistance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMin.Focus();
            }
        }

        private void txtSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNbRepetitions.Focus();
            }
        }

        private void txtMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSec.Focus();
            }
        }

        private void txtNbRepetitions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDistance.Focus();
            }
        }

      
    }
}
