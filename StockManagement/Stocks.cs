using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccount_Management
{
    internal class Stocks
    {
        public string Stock_Name;
        public double Stock_Price;
        public int NumberOf_shares;
        public double Stock_Value;
        public double StockValue()
        {
            return Stock_Value = Stock_Price * NumberOf_shares;
        }
    }
}
