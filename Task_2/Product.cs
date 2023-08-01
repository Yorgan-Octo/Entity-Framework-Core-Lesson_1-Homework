using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }


        public Product(string name, double cost, string description, int quantity)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Quantity = quantity;

        }


    }
}
