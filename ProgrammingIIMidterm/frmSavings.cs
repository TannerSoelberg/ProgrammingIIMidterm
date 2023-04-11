using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingIIMidterm
{
    public partial class frmSavings : Form
    {
        private ATMUser CurrentUser = null;

        public frmSavings(ATMUser _user)
        {
            CurrentUser = _user;

            InitializeComponent();
        }

        private void txbTransfer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMain fm = new frmMain(CurrentUser);

            fm.Show();
        }

        private void frmSavings_Load(object sender, EventArgs e)
        {
            lblAccount.Text = CurrentUser.SavingsNum.ToString();
            lblBalance.Text = CurrentUser.SavingsAccount.Balance.ToString("C");
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal n;
            if (decimal.TryParse(txbTransfer.Text, out n))
            {
                if (n > 0)
                {
                    bool ActionDone = false;

                    if (CurrentUser.SavingsAccount.Balance >= n)
                    {
                        ActionDone = true;
                        CurrentUser.SavingsAccount.Balance -= n;
                        CurrentUser.CheckingAccount.Balance += n;
                    }
                    else
                    {
                        MessageBox.Show("There is not enough money in your checking account for this action.");
                    }
                    if (ActionDone == true)
                    {
                        lblBalance.Text = CurrentUser.SavingsAccount.Balance.ToString("C");
                        SQLHelper.UpdateUser(CurrentUser);
                        MessageBox.Show("Funds transferred.");
                    }
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal n;
            if (decimal.TryParse(txbWithdraw.Text, out n))
            {
                if (n > 0)
                {
                    bool ActionDone = false;

                    if (CurrentUser.SavingsAccount.Balance >= n)
                    {
                        ActionDone = true;
                        CurrentUser.SavingsAccount.Balance -= n;
                    }
                    else
                    {
                        MessageBox.Show("There is not enough money in your account.");
                    }
                    if (ActionDone == true)
                    {
                        lblBalance.Text = CurrentUser.SavingsAccount.Balance.ToString("C");
                        SQLHelper.UpdateUser(CurrentUser);
                        MessageBox.Show("Funds withdrawn.");
                    }
                }
            }
        }
    }
}
