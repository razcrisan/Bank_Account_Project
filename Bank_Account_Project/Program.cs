using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client1 = new Bank_Account_Project.Client("Razvan", "Crisan", 1234);
            Savings savings = new Savings(1000.00);
            Checking checking = new Checking(350.00);



            //start of the do while loop
            string newTransaction = "";
            do
            {


                //When user launches Applicating they will see this menu.
                //and will cycle after every transaction with a do-while loop
                double minBalance = 200.00;
                Console.WriteLine("Please enter the number of your desired option.");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                //readline for user to cycle through options.
                int menuOptions = int.Parse(Console.ReadLine());

                //if else statement for first option
                if (menuOptions == 1)
                {
                    client1.displayInfo();
                }
                //if else statement for a/b options.
                if (menuOptions == 2)
                {

                    Console.WriteLine("a. Checkings Account");
                    Console.WriteLine("b. Savings Account");
                    
                    char menuOptions2 = char.Parse(Console.ReadLine().ToLower());
                    if (menuOptions2 == 'a')
                    {
                        checking.Balance();
                    }
                    else if (menuOptions2 == 'b')
                    {
                        savings.Balance();
                    }



                }

                //if else statement for option 3 (deposit).
                if (menuOptions == 3)
                {
                    Console.WriteLine("Which account would you like to deposit into?");
                    Console.WriteLine("a. Checkings");
                    Console.WriteLine("b. Savings");
                    // 
                    char menuOptions2 = char.Parse(Console.ReadLine().ToLower());
                    if (menuOptions2 == 'a')
                    {
                        //checking deposit
                        Console.WriteLine("Enter deposit amount:");
                        double depositAmount = double.Parse(Console.ReadLine());
                        checking.Deposit();
                        Console.WriteLine("Your new balance is: $" + (checking.Deposit() + depositAmount));



                    }
                    else if (menuOptions2 == 'b')
                    {
                        //savings deposit
                        Console.WriteLine("Enter deposit amount:");
                        savings.depositAmount = double.Parse(Console.ReadLine());
                        double newBalance = savings.Deposit();
                        Console.WriteLine("Your new balance is: $" + (savings.Deposit()));

                    }
                }

                //if else statement for withdraw option 4
                if (menuOptions == 4)
                {
                    Console.WriteLine("Which account would you like to withdraw from?");
                    Console.WriteLine("a. Checkings");
                    Console.WriteLine("b. Savings");
                    char menuOptions2 = char.Parse(Console.ReadLine().ToLower());
                    if (menuOptions2 == 'a')
                    {
                        //checkings withdraw pulling methods from Checking class
                        Console.WriteLine("Enter withdraw amount:");
                        checking.withdrawAmount = double.Parse(Console.ReadLine());
                        double newBalance = checking.Withdraw();
                        Console.WriteLine("Your new Balance is: $" + checking.Withdraw());
                        
                        if (newBalance < 0)
                        {
                            //if user pull more money than he has in his account
                            //then user will be prompted to enter new amount 
                            //this amount will pull money from his original checking balance.
                            Console.WriteLine("You cannot overdraft from checking.");
                            Console.WriteLine("Enter new withdraw amount");
                            checking.withdrawAmount = double.Parse(Console.ReadLine());
                            checking.Withdraw();
                            Console.WriteLine("Balance after withdraw is: $" + (checking.Withdraw()));
                        }
                    }
                    else if (menuOptions2 == 'b')
                    {
                        //savings withdraw
                        Console.WriteLine("Enter withdraw amount:");
                        savings.withdrawAmount = double.Parse(Console.ReadLine());
                        savings.Withdraw();
                        double newBalance2 = savings.Withdraw();
                        Console.WriteLine("Balance after withdraw is: $" + (savings.Withdraw()));
                        if (minBalance <= 200.00)
                        {
                            //this amount will not let the user go under their $200 limit
                            //then user will be prompted to enter new amount 
                            //this amount will pull money from his original savings balance.
                            Console.WriteLine("You are attempting to withdraw more");
                            Console.WriteLine("than your minimum balance allows. Please enter new amount");
                            savings.withdrawAmount = double.Parse(Console.ReadLine());
                            Console.WriteLine("Balance after withdraw is: $" + (savings.Withdraw()));
                        }
                    }



                }

                //if else statement for exit option
                else if (menuOptions == 5)
                {
                    Console.WriteLine("Have a great day!");

                }
                //the user will be asked to make another transaction.
                else
                {
                    Console.WriteLine("Would you like to make another transaction? YES/NO");
                    newTransaction = Console.ReadLine().ToUpper();
                }


            }

            //do-while loop will end program if user selects no 
            while (newTransaction == "YES");
            if (newTransaction == "NO")
            {
                Console.WriteLine("Thank you for visiting our bank, have a nice day!");
            }


            //The End






        }

     }
}
