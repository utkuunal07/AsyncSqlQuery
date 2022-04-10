using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareLocker
{
    public partial class frmDialog : Form
    {
        private string _Pass;
        private string _Identifier;
        public string MaxRaporCount;
        public frmDialog(string BaseString,
            string Password,int DaysToEnd,int Runed, string info, string Identifier)
        {
            InitializeComponent();
            _Identifier = Identifier;
            sebBaseString.Text = BaseString;
            _Pass = Password;
            lblDays.Text = DaysToEnd.ToString() + " Day(s)";
            lblTimes.Text = Runed.ToString() + " Time(s)";
            //lblText.Text = info;
            if (DaysToEnd <= 0 || Runed <= 0)
            {
                lblDays.Text = "Finished";
                lblTimes.Text = "Finished";
                btnTrial.Enabled = false;
            }

            sebPassword.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MaxRaporCount = sebPassword.Text[0].ToString() + sebPassword.Text[sebPassword.Text.Length - 1].ToString();

            //_Pass = _Pass.Remove(0, 1);
            //_Pass = _Pass.Remove(_Pass.Length - 1);

            string girilenPass = sebPassword.Text.Remove(0, 1);
            girilenPass = girilenPass.Remove(girilenPass.Length - 1);
            if (_Pass.Length==25)
            {
                _Pass = _Pass.Remove(0, 1);
                _Pass = _Pass.Remove(_Pass.Length - 1);

            }
            if (_Pass == girilenPass)
            {
                MessageBox.Show("Þifre doðru", "HýzlýSQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Þifre yanlýþ", "HýzlýSQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnTrial_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void lblComment_Click(object sender, EventArgs e)
        {

        }

        private void grbRegister_Enter(object sender, EventArgs e)
        {

        }

        private void frmDialog_Load(object sender, EventArgs e)
        {
            label1.Text = "Identifier:" + _Identifier;
        }

        private void sebPassword_Load(object sender, EventArgs e)
        {

        }
    }
}