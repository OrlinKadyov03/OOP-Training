using System.Text.RegularExpressions;

namespace _9thExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Listing class with CategoryId and Name properties.
            // Use GroupBy to divide listings into categories and display all listings by category.

              List<Listing> listings = new List<Listing>()
              {
                  new Listing() {Name = "listing1",CategoryId = 1 },
                  new Listing() {Name = "listing2",CategoryId = 2 },
                  new Listing() {Name = "listing3",CategoryId = 1 },
                  new Listing() {Name = "listing4",CategoryId = 2 },
                  new Listing() {Name = "listing5",CategoryId = 3 },
                    new Listing() {Name = "listing6",CategoryId = 3 }
              };

            var divide = listings.GroupBy(l => l.CategoryId);
            foreach (var item in divide)
            {
                Console.WriteLine($"Category{item.Key}");
                foreach (var listing in item)
                {
                    Console.WriteLine(listing.Name);
                }
            }
            
   
        } 

    }
}