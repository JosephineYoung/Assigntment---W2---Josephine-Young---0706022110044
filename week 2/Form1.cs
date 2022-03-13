using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int varInt = 0;
        string varStr;
        
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text.ToUpper() == "RESTART")
            {
                lblOutput.Text = "[EMPTY]";
                lblOutput.ForeColor = Color.Black;
            }
            else if (txtBoxInput.Text.Substring(0, 6).ToUpper() == "WARNA:")
            {
                lblOutput.Text = txtBoxInput.Text;
            }
            {
                if (txtBoxInput.Text.Substring(6).ToUpper() == "MERAH")
                    lblOutput.ForeColor = Color.Red;
            }
            {
                if (txtBoxInput.Text.Substring(6).ToUpper() == "HIJAU")
                    lblOutput.ForeColor = Color.Green;
            }
            {
                if (txtBoxInput.Text.Substring(6).ToUpper() == "BIRU")
                    lblOutput.ForeColor = Color.Blue;
            }
            {
                if (txtBoxInput.Text.Substring(6).ToUpper() == "DEFAULT")
                    lblOutput.ForeColor = Color.Black;
            }
            btnStyleOrganizer();
        }

        private void btnStyleOrganizer()
        {
            if (txtBoxInput.Text.Substring(0, 4).ToUpper() == "ISI:")
            {
                lblOutput.Text = txtBoxInput.Text.Substring(4);
            }
            else if (txtBoxInput.Text.ToUpper() == "HIDE")
            {
                lblOutput.Visible = false;
            }
            else if (txtBoxInput.Text.ToUpper() == "SHOWN")
            {
                lblOutput.Visible = true;
            }
            
        }
    }
}