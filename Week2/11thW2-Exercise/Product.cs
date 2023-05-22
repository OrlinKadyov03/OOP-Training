using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11thW2_Exercise
{
    public class Product 
    {
        public string Name { get; set; }
        public string Availability { get; set; }
        public int Price { get; set; }

        public Product(string name,string availability,int price)
        {
            this.Name = name;
            this.Availability = availability;
            this.Price = price;
        }
    }
}
