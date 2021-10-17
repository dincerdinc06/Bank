using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var Customer1 = new Customer(6879461,"Dinçer", "Dinç",5568.74,2000);
            var Customer2 = new Customer(9875615, "Engin", "Demirog",15500.25,1989);

            CustomerManager.CustomerAdd(Customer1);
            CustomerManager.CustomerAdd(Customer2);

            CustomerManager.CustomerDelete(Customer1);
            CustomerManager.CustomerDelete(Customer2);

            Console.ReadKey();


        }
    }
}
