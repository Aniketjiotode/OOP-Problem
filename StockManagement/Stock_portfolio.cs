using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccount_Management
{
    internal class Stock_portfolio
    {
       public List<Stocks> stock;

        public Stock_portfolio()
        {
            stock = new List<Stocks>();
        }

        public double TotalStock_Value()
        {
            double TotalValue=0;
            foreach(Stocks st in stock)
            {
                TotalValue += st.Stock_Price * st.NumberOf_shares;
            }
            return TotalValue;
        }
    }
}
