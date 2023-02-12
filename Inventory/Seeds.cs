using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    internal class Seeds
    {
        public String Brand; 
        public int Weight; 
        public int PricePerKg;
        public override string ToString()
        {
            return $"\nBrand: {Brand}\nWeight: {Weight}\nPricePerKg: {PricePerKg}";
        }
    }
}
