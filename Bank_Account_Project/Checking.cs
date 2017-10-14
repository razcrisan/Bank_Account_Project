using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Checking : BankAccount
    {
        private double checkingAccountBalance;
  



        //Fields double will hold accound balance
        //constructor
        public double CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
        }

        //default constructor
        public Checking()
        {

        }

        //constructor
        public Checking(double checkingAccountBalance)
        {
            this.checkingAccountBalance = checkingAccountBalance;
        }

        //method
        public override void Balance()
        {
            Console.WriteLine(checkingAccountBalance);
        }

        public override double Deposit()
        {
            return checkingAccountBalance + depositAmount;
        }

        public override double Withdraw()
        {
            return checkingAccountBalance - withdrawAmount;
        }

    



        
    }
}
