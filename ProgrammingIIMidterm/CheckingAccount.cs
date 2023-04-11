using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIIMidterm
{
    internal class CheckingAccount : Account
    {
        //Private Variables
        private decimal _fee;

        //Constructor
        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = fee;
        }

        //Getters & Setters
        public decimal Fee
        {
            get { return _fee; }
            set { 
                if (value >= 0)
                {
                    _fee = value;
                }
                else
                {
                    MessageBox.Show("Fee cannot be less than zero.");
                }    
            }
        }

        //Methods
        /// <summary>
        /// This method takes an amount and attempts to add it to the balance. It then subtracts a fee.
        /// </summary>
        /// <param name="amount"> A decimal amount to be creditted to an account. </param>
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        /// <summary>
        /// This method takes an amount and first checks if it can be subtracted from the account. If so, it subtracts the amount directly from the account.
        /// </summary>
        /// <param name="amount"> A decimal amount to be taken from an account. </param>
        /// <returns> True/false based on whether the action occurred. </returns>
        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }

            return false;
        }
    }
}
