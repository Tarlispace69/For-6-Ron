using System;

namespace ConsoleApp183
{
    class Program
    {
        const int MEMBERS = 10;
        static void Main(string[] args)
        {
            int i = 0, totalAmount = 0;

            //receiving amount given by each member
            for (i=0; i < MEMBERS; i++)
            {
                Console.WriteLine("HOW MUCH MONEY ARE YOU GIVING????? (in shekels)");
                totalAmount += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total amount: {totalAmount}");
            Console.ReadLine();
        }
    }
}
