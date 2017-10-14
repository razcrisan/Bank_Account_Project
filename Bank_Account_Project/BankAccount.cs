using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    abstract class BankAccount
    {
        //Fields
        private int accountNumber;
        public double depositAmount;
        private double accountBalance;
        public double withdrawAmount;
        
        
       
            
            //properties
        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public double DepositAmount
        {
            get { return this.depositAmount; }
            set { this.depositAmount = value; }
        }

        public double AccountBalance { get; }

        //abstract method
        public abstract void Balance();
    
        public abstract double Deposit();

        public abstract double Withdraw();

        
        
        

    }
}
