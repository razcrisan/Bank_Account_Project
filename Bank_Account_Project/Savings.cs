using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Savings : BankAccount
    {
        //fields
        //double min balance the lowest amount of money to have is $200
        protected double savingsAccountBalance = 500.00;
        public double minBalance = 200.00;
      

     
        //Default Constructor
        public double NewSavings
        {
            get { return this.savingsAccountBalance; }
        }

        private double MinBalance
        {
            get { return this.minBalance; }
        }
        //constructors

        public Savings(double savingsAccountBalance)
        {
            this.savingsAccountBalance = savingsAccountBalance;
        }

        //method
        public override void Balance()
        {
           Console.WriteLine("Your savings account balance is: $ " + savingsAccountBalance);
        }

        public override double Deposit()
        {
            return savingsAccountBalance + depositAmount; 
        }
        
        public override double Withdraw()
        {
            return savingsAccountBalance - withdrawAmount;
        }





    }

}
