using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDesignPattern1
{
    public class Account
    {
        //Attributes
        private float balance { get; set; }
        public int total { get; set; }

        //Methods
        public void setBalance(float balance)
        {
            this.balance = balance;
        }
        public float getBalance() 
        {
            return balance;
        }

        public int MyProperty { get; set; }
    }
}
