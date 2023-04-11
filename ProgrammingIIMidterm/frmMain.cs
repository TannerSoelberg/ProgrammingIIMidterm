using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingIIMidterm
{
    public partial class frmMain : Form
    {
        private ATMUser CurrentUser = null;

        public frmMain(ATMUser _user)
        {
            CurrentUser = _user;

            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblCheckingNum.Text = CurrentUser.CheckingNum.ToString();
            lblSavingsNum.Text = CurrentUser.SavingsNum.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewChecking_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmChecking fc = new frmChecking(CurrentUser);

            fc.Show();
        }

        private void btnViewSavings_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSavings fs = new frmSavings(CurrentUser);

            fs.Show();
        }
    }
}
