using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;

namespace Inventory
{
    internal class InventoryManager
    {
        public Inventory inventory;
        public InventoryManager()
        {
            inventory = new Inventory();
        }

        public void AddToInventory()
        {
            Console.WriteLine("Enter: \nR to add Rice in inventory \nW to add Wheat in inventory \nP to add Pulses in inventory");
            char input = Console.ReadLine()[0];
            switch (input)
            {
                case 'R':
                    inventory.Rice.Add(TakeUserInput());
                    break;
                case 'W':
                    inventory.Wheat.Add(TakeUserInput());
                    break;
                case 'P':
                    inventory.Pulses.Add(TakeUserInput());
                    break;
                default:
                    Console.WriteLine("Invalid input try agin");
                    break;
            }
        }

        public void Save()
        {
            string path = @"C:\json\Inventory.json";
            var jsonInventory = JsonConvert.SerializeObject(inventory,Formatting.Indented);
            File.WriteAllText(path,jsonInventory);
        }
        public void Load()
        {
            string path = @"C:\json\Inventory.json";
            var json =File.ReadAllText(path);
            inventory= JsonConvert.DeserializeObject<Inventory>(json);
            DisplayInventory();
        }
        private Seeds TakeUserInput()
        {
            Console.WriteLine("Enter Brand Name:");
            string BrandName = Console.ReadLine();
            Console.WriteLine("Enter Weight:");
            string Weight = Console.ReadLine();
            Console.WriteLine("Enter Price Per Kg:");
            string Price = Console.ReadLine();
            Seeds s = new Seeds();
            s.Brand = BrandName;
            s.Weight = int.Parse(Weight);
            s.PricePerKg = int.Parse(Price);
            Console.WriteLine("Successully added..");
            return s;
        }
        public void DisplayInventory()
        {
            Console.WriteLine(inventory.ToString());
        }


    }
}
