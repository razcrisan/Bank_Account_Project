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
            

            //When user launches Applicating they will see this menu.
            Console.WriteLine("Please enter the number of your desired option.");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");

            int menuOptions = int.Parse(Console.ReadLine());

            if (menuOptions == 1)
            {
                client1.displayInfo();
            }
            else if (menuOptions == 2)
            {
                
                Console.WriteLine("a: Checkings Account");
                Console.WriteLine("b: Savings Account");
                char menuOptions2 = char.Parse(Console.ReadLine());
                if (menuOptions2 == 'a')
                {

                }
                else if (menuOptions2 == 'b')
                {

                }
                
            }
           


        }
    }
}
