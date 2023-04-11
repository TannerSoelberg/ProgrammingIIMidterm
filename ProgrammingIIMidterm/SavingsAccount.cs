using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIIMidterm
{
    internal class SavingsAccount : Account
    {
        //Private Variables
        private decimal _interestRate;

        //Constructor
        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }

        //Getters & Setters
        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value >= 0)
                {
                    _interestRate = value;
                }
                else
                    MessageBox.Show("Interest rate must be greater than zero.");
            }
        }

        //Methods
        /// <summary>
        /// This method calculates simple interest based on the relative Balance and InterestRate.
        /// </summary>
        /// <returns> This returns a simple interest decimal. </returns>
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
