namespace _8thExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Product class with Name and Price.
            //Create a list of products and then sort
            //the list first by name and then by price. OrderBy().ThenBy()

            List<Product> products = new List<Product>();

            Product p = new Product() { Name = "Glass", Price = 4 };
            Product pTwo = new Product() { Name = "Bag", Price = 2.20 };
            Product pThree = new Product() { Name = "TV", Price = 130 };

            products.Add(p);
            products.Add(pTwo);
            products.Add(pThree);

            var order = products.OrderBy(x => x.Name).ThenBy(x => x.Price);

            foreach (var y in products)
            {
                Console.WriteLine($"{y.Name} {y.Price}");
            }
        }
    }
}