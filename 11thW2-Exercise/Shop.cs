using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11thW2_Exercise
{
    public class Shop 
    {

        //In the Shop class, create a method StockPrice -
        //a method that calculates the total price of all
        //products in the given store. Create appropriate
        //constructors for each of the classes.
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public Shop(string name, string address) 
        {
            this.Name = name;
            this.Address = address;
            Products = new List<Product>();
        }
        public int StockPrice()
        {
            int totalPrice = 0;
            foreach (var p in Products)
            {
                totalPrice += p.Price;
            }
            return totalPrice;
        }


    }
}
