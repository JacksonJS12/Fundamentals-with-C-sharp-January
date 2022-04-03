using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.StoreBoxes
{
    class Item
    {
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }

    }
    class Box
    {
      
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        public decimal PricePerBox
        {
            get
            {
                return this.Item.ItemPrice * this.ItemQuantity;
            }
        }



        internal class Program
        {
            static void Main(string[] args)
            {
                string command = Console.ReadLine();
                List<Box> boxes = new List<Box>();

                decimal pricePerBox = 0;
                while (command != "end")
                {
                    string[] splitParams = command
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string serialNumber = splitParams[0];
                    string itemName = splitParams[1];
                    int itemQuantity = int.Parse(splitParams[2]);
                    decimal itemPrice = decimal.Parse(splitParams[3]);
                    Box box = new Box()
                    {
                        SerialNumber = serialNumber,
                        Item = new Item()
                        {
                            ItemName = itemName,
                            ItemPrice = itemPrice
                        },
                        ItemQuantity = itemQuantity
                    };

                    boxes.Add(box);

                    command = Console.ReadLine();
                }
                List<Box> orderedBoxes = boxes
                    .OrderByDescending(b => b.PricePerBox)
                    .ToList();

                foreach (Box box in orderedBoxes)
                {
                    Console.WriteLine($"{box.SerialNumber}");
                    Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.ItemPrice:f2}: {box.ItemQuantity}");
                    Console.WriteLine($"-- ${box.PricePerBox:f2}");
                }
                
            }

            
        }
    }
}