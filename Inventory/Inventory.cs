using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    internal class Inventory
    {
       public List<Seeds> Rice;
       public List<Seeds> Wheat;
       public List<Seeds> Pulses;
        public Inventory()
        {
            Rice = new List<Seeds>();
            Wheat = new List<Seeds>();
            Pulses = new List<Seeds>();
        }
        public override string ToString()
        {
            string result = "";
            result += "\nRice: \n";
            foreach (Seeds s in Rice)
            {
                result+= s.ToString();
            } 
            result += "\nWheat: \n";
            foreach (Seeds s in Wheat)
            {
                result+= s.ToString();
            } 
            result += "\nPulses: \n";
            foreach (Seeds s in Pulses)
            {
                result+= s.ToString();
            }
            return result;
        }
    }
}
