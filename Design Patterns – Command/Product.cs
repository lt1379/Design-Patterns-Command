﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Command
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"The price for the {Name} has been increased by {amount}$.");
        }

        public bool DecreasePrice(int amount)
        {
            if (amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"The price for the {Name} has been decreased by {amount}$.");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Current price for the {Name} product iss {Price}$.";
        }
    }
}
