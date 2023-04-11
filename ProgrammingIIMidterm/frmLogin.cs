using Microsoft.VisualBasic.ApplicationServices;

namespace ProgrammingIIMidterm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblCustNum_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string CustNum = txbCustNum.Text;
            string Pin = txbPin.Text;

            int C1, C2;

            if (int.TryParse(CustNum, out C1) && int.TryParse(Pin, out C2))
            {
                ATMUser NewUser = new ATMUser(C1,C2);

                NewUser = SQLHelper.CheckLogin(NewUser);

                if (NewUser != null)
                {
                    this.Hide();

                    frmMain fm = new frmMain(NewUser);

                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}