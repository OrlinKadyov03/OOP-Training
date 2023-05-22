using System.Collections.Generic;

namespace _11thW2_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a Shop class,
            //each shop has a name,
            //address and a list of products.
            //The Product class has a name, availability, price.
            //In the Shop class, create a method StockPrice -
            //a method that calculates the total price of all
            //products in the given store. Create appropriate
            //constructors for each of the classes.
            //Finally, create a list of stores and add
            //products to them and display the StockPrice
            //for each of the stores.

            //Creating list of shops
            List<Shop> stores = new List<Shop>();
            //Creating products
            Product p = new Product("Tire","Available",150);
            Product pTwo = new Product("Wheel", "Not available", 120);
            //Create shop
            Shop shop = new Shop("Insa", "Bul 143");
            //Adding Products to the shop
            shop.Products.Add(p);
            shop.Products.Add(pTwo);
            //Adding shop to the stores 
            stores.Add(shop);
            //Console writing the final results;
            foreach (var s in stores)
            {
                Console.WriteLine($"{s.Name} - {s.StockPrice()}"); 
            }

 
        }
    }
}