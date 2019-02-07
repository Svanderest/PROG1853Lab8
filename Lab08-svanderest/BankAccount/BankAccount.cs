using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Sebastian van der Est
namespace BankAccount
{
    class BankAccount
    {
        private string name;
        protected decimal balance;
        private int accNumber;
        private DateTime open;
        public const string BankName = "New Bank";

        public string ClientName
        {
            get { return name; }
            set
            {
                if (value == "")
                    name = "Unknown";
                else
                    name = value;
            }
        }

        public string Balance
        {
            get { return balance.ToString("C2"); }
        }

        public int AccountNumber
        {
            get { return accNumber; }
        }

        public string DateOpen
        {
            get { return open.ToLongDateString(); }
        }

        public BankAccount( int accountNumber, decimal startBalance )
        {
            this.ClientName = "";
            this.balance = startBalance;
            this.open = new DateTime();
        }

        public BankAccount( int accoutNumber, decimal startBalance, string nameOfClient )
        {
            this.ClientName = nameOfClient;
            this.balance = startBalance;
            this.open = new DateTime();
        }

        public void Deposit (decimal amount)
        {
            if (amount >= 0)
                this.balance += amount;
        }

        public void Withdrawal (decimal amount)
        {
            if (amount >= 0 && amount <= this.balance)
                this.balance -= amount;
        }
    }
}
