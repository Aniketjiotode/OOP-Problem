using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StockAccount_Management
{
    internal class StockManger
    {
        public Stock_portfolio portfolio;
        public StockManger()
        {
            portfolio = new Stock_portfolio();
        }
        public void AddStock()
        {
            Stocks S = new Stocks();
            Console.WriteLine("Enter Name Of The Stock");
            S.Stock_Name = Console.ReadLine();
            Console.WriteLine("Enter Number Of Shares");
            S.NumberOf_shares = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price Of The Stock");
            S.Stock_Price = double.Parse(Console.ReadLine());
            portfolio.stock.Add(S);
        }

        public void StockReport()
        {
            Stocks st=null;
            foreach (Stocks s in portfolio.stock)
            {
                st = s;
                if (st != null)
                {
                    Console.WriteLine($"\nValue Of {st.Stock_Name} = {st.StockValue()}");
                }
            }
            if (st != null)
            {
                Console.WriteLine($"\nTotal Value Of All Stocks in portfolio = {portfolio.TotalStock_Value()}");
            }
            else
            {
                Console.WriteLine("No Data Available");
            }
        }
    }
}



