using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Checking : BankAccount
    {
        private double newChecking;
  



        //Fields double will hold accound balance
        //constructor
        public double NewChecking
        {
            get { return this.newChecking; }
        }

        //default constructor
        public Checking()
        {

        }

        //constructor
        public Checking(double newChecking)
        {
            this.newChecking = newChecking;
        }

        //method
        public override void Balance()
        {
            Console.WriteLine(newChecking);
        }

        public override double Deposit()
        {
            return newChecking + depositAmount;
        }

        public override double Withdraw()
        {
            return newChecking - withdrawAmount;
        }

    



        
    }
}
