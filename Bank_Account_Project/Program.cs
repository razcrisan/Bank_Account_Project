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
                Savings savings = new Savings(500.00);
                Checking checking = new Checking(350.00);


            

            string newTransaction;

            do
            {
                //When user launches Applicating they will see this menu.



                double minBalance = 200.00;
                Console.WriteLine("Please enter the number of your desired option.");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                Console.WriteLine();


                int menuOptions = int.Parse(Console.ReadLine());

                if (menuOptions == 1)
                {
                    client1.displayInfo();
                }
                if (menuOptions == 2)
                {

                    Console.WriteLine("a. Checkings Account");
                    Console.WriteLine("b. Savings Account");
                    Console.WriteLine("c. Return to Main Menu");
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
                if (menuOptions == 3)
                {
                    Console.WriteLine("Which account would you like to deposit into?");
                    Console.WriteLine("a. Checkings");
                    Console.WriteLine("b. Savings");
                    Console.WriteLine("c. Return to Main Menu");
                    char menuOptions2 = char.Parse(Console.ReadLine().ToLower());
                    if (menuOptions2 == 'a')
                    {
                        Console.WriteLine("Enter deposit amount:");
                        double depositAmount = double.Parse(Console.ReadLine());
                        checking.Deposit();
                        Console.WriteLine("Your new balance is: $" + (checking.Deposit() + depositAmount));



                    }
                    else if (menuOptions2 == 'b')
                    {
                        Console.WriteLine("Enter deposit amount:");
                        savings.depositAmount = double.Parse(Console.ReadLine());
                        double newBalance = savings.Deposit();
                        Console.WriteLine("Your new balance is: $" + (savings.Deposit()));

                    }
                }
                if (menuOptions == 4)
                {
                    Console.WriteLine("Which account would you like to withdraw from?");
                    Console.WriteLine("a. Checkings");
                    Console.WriteLine("b. Savings");
                    Console.WriteLine("c. Return to Main Menu");
                    char menuOptions2 = char.Parse(Console.ReadLine().ToLower());
                    if (menuOptions2 == 'a')
                    {
                        Console.WriteLine("Enter withdraw amount:");
                        checking.withdrawAmount = double.Parse(Console.ReadLine());
                        double newBalance = checking.Withdraw();
                        if (newBalance < 0)
                        {
                            Console.WriteLine("You cannot overdraft from checking.");
                            Console.WriteLine("Enter new withdraw amount");
                            checking.withdrawAmount = double.Parse(Console.ReadLine());
                            double newBalance2 = checking.Withdraw();
                            Console.WriteLine("Balance after withdraw is: $" + (checking.Withdraw()));
                        }
                    }
                    else if (menuOptions2 == 'b')
                    {
                        Console.WriteLine("Enter withdraw amount:");
                        savings.withdrawAmount = double.Parse(Console.ReadLine());
                        double NewBalance = savings.Withdraw();
                        Console.WriteLine("Balance after withdraw is: $" + (savings.Withdraw()));
                        if (minBalance <= 200.00)
                        {
                            Console.WriteLine("You are attempting to withdraw more");
                            Console.WriteLine("than your minimum balance allows. Please enter new amount");
                            savings.withdrawAmount = double.Parse(Console.ReadLine());
                            Console.WriteLine("Balance after withdraw is: $" + (savings.Withdraw()));
                        }
                    }

                }
                if (menuOptions == 5)
                {
                    Console.WriteLine("Thanks for choosing our bank");
                    newTransaction = Console.ReadLine().Trim().Trim();
                }
                while (newTransaction == "YES")
                    if (newTransaction == "NO")
                    {
                        Console.WriteLine("Thank you for visiting our bank, have a nice day!");
                    }




            

        }
    }
}
