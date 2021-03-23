using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class SavingsAccount
    {
        // Fields
        private string _accountNumber;
        private decimal _internetRate;
        private decimal _balance;

        // Consutuctor
        public SavingsAccount()
        {
            _accountNumber = "";
            _internetRate = 0;
            _balance = 0;
        }

        // Account Number property
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value;  }
        }

        // Interest Rate property
        public decimal InterestRate
        {
            get { return _internetRate; }
            set { _internetRate = value; }
        }

        // Balance property
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
