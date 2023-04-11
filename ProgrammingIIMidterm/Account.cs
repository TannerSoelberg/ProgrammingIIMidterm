using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIIMidterm
{
    internal class Account
    {
        //Private Variables
        private decimal _balance;

        //Constructor
        public Account(decimal balance)
        {
            Balance = balance;
        }

        //Getters & Setters
        public decimal Balance
        {
            get { return _balance; }
            set {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    MessageBox.Show("Balance connot be negative.");
                }
            }
        }

        //Methods
        /// <summary>
        /// This method takes an amount, and if greater than 0, attempts to add it to the account's balance.
        /// </summary>
        /// <param name="amount"> An inputted decimal. </param>
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                MessageBox.Show("Credited amount must be greater than zero.");
            }
        }

        /// <summary>
        /// This method takes an amount and attempts to subtract it from the account.
        /// </summary>
        /// <param name="amount"> A decimal amount to be subtracted from the account. </param>
        /// <returns> True or false based on whether the action occurred. </returns>
        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                MessageBox.Show("Debit amount exceeded account balance.");
                OK = false;
            }

            return OK;
        }
    }
}
