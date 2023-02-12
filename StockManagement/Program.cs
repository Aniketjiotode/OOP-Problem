using System;

namespace StockAccount_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlecome To Stock Account Management");
            StockManger manger= new StockManger();
            while (true)
            {
                Console.WriteLine("Enter 1 to Add Stocks \nEnter 2 for Stock Report");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        manger.AddStock();
                        break;
                    case 2:
                        manger.StockReport();
                        break;
                        
                }
            }
        }
    }
}
