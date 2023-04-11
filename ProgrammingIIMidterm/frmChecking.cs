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
    public partial class frmChecking : Form
    {
        private ATMUser CurrentUser = null;

        public frmChecking(ATMUser _user)
        {
            CurrentUser = _user;

            InitializeComponent();
        }

        private void frmChecking_Load(object sender, EventArgs e)
        {
            lblAccount.Text = CurrentUser.CheckingNum.ToString();
            lblBalance.Text = CurrentUser.CheckingAccount.Balance.ToString("C");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMain fm = new frmMain(CurrentUser);

            fm.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal n;
            if (decimal.TryParse(txbTransfer.Text, out n))
            {
                if (n > 0)
                {
                    bool ActionDone = false;

                    if (CurrentUser.CheckingAccount.Balance >= n)
                    {
                        ActionDone = true;
                        CurrentUser.CheckingAccount.Balance -= n;
                        CurrentUser.SavingsAccount.Balance += n;
                    }
                    else
                    {
                        MessageBox.Show("There is not enough money in your checking account for this action.");
                    }
                    if (ActionDone == true)
                    {
                        lblBalance.Text = CurrentUser.CheckingAccount.Balance.ToString("C");
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

                    if (CurrentUser.CheckingAccount.Balance >= n)
                    {
                        ActionDone = true;
                        CurrentUser.CheckingAccount.Balance -= n;
                    }
                    else if ((CurrentUser.CheckingAccount.Balance + CurrentUser.SavingsAccount.Balance) >= n)
                    {
                        ActionDone = true;
                        decimal diff = n - CurrentUser.CheckingAccount.Balance;

                        CurrentUser.CheckingAccount.Balance = 0;
                        CurrentUser.SavingsAccount.Balance -= diff;
                    }
                    else
                    {
                        MessageBox.Show("There is not enough money in your accounts.");
                    }
                    if (ActionDone == true)
                    {
                        lblBalance.Text = CurrentUser.CheckingAccount.Balance.ToString("C");
                        SQLHelper.UpdateUser(CurrentUser);
                        MessageBox.Show("Funds withdrawn.");
                    }
                }
            }
        }
    }
}
