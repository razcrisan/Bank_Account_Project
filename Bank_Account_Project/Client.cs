using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Client
    {
        //Fields
        private string firstName;
        private int lastFour;
        private string lastName;
        
        //Properties

        public string FirstName
        {
            get { return this.firstName; }
            
        }

        public int LastFour
        {
            get { return this.lastFour; }
        }

        public string LastName
        {
            get { return this.firstName; }
        }

        public Client()
        {

        }

        public Client (string firstName, string lastName, int lastFour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.lastFour = lastFour;
        }












    }
}
