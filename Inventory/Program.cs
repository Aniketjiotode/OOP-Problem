using Newtonsoft.Json;
using System;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();
            while (true)
            {
                Console.WriteLine("Enter 1 to Add in Inventory \nEnter 2 to Display Inventory \nEnter 3 to Save Inventory \nEnter 4 to Load Inventory");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        manager.AddToInventory();
                        Console.WriteLine(JsonConvert.SerializeObject(manager.inventory, Formatting.Indented));

                        break;
                    case 2:
                        manager.DisplayInventory();
                        break;
                    case 3:
                        manager.Save();
                        break;
                    case 4:
                        manager.Load();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
        }
    }
}
