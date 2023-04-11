using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingIIMidterm
{
    //object
    public class ATMUser
    {
        private int _CustId;
        private int _Pin;
        private int _CheckingNum;
        private int _SavingsNum;

        private SavingsAccount _SavingsAccount;
        private CheckingAccount _CheckingAccount;

        public ATMUser(int custid, int pin) 
        {
            CustId = custid;
            Pin = pin;
        }

        public int CustId
        {
            get
            { return _CustId; }
            set
            { 
                if (value > 0)
                {
                    _CustId = value;
                }
            }
        }

        public int Pin
        {
            get
            { return _Pin; }
            set
            { _Pin = value; }
        }

        public int CheckingNum
        {
            get
            { return _CheckingNum; }
            set
            {
                if (value >= 0)
                {
                    _CheckingNum = value;
                }
            }
        }

        public int SavingsNum
        {
            get
            { return _SavingsNum; }
            set
            {
                if (value >= 0)
                {
                    _SavingsNum = value;
                }
            }
        }

        internal CheckingAccount CheckingAccount
        {
            get
            { return _CheckingAccount; }
            set
            {
                _CheckingAccount = value;
            }
        }

        internal SavingsAccount SavingsAccount
        {
            get
            { return _SavingsAccount; }
            set
            {
                _SavingsAccount = value;
            }
        }

        //Methods
    }
}