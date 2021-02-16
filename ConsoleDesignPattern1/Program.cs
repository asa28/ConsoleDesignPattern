using System;

namespace ConsoleDesignPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string x = Console.ReadLine();
            //int y = Int16.Parse(x);
            //User user1 = new User("ahmed", y);
            //Console.WriteLine("the X is {0}",y);
            //Console.WriteLine(user1.Name);
            //Console.WriteLine(user1.Id);
            //user1.sayHello();
            //User user2 = new User();
            //user2.sayHello();

            //ITaxCalaulator calc = GetTaxCalculator();
            //calc.calculateCarTax();
            //calc.calculateHomeTax();

            //Account Ahmed_account = new Account();
            //Ahmed_account.total = 100;

            MailService mail1 = new MailService();
            mail1.sendEmail();
        }

        // Impelentaion
        // Programming to interface (not concerte implementaion)
        // make it static  to call directory from main class
        // coupling  
        public static ITaxCalaulator GetTaxCalculator()
        {
            return new Tax2021();
        }
    }
}
