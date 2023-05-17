namespace _4thExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Smartphone class with the
            //Price property and RAM: double.
            //Add multiple objects of the class to a list.
            //The user enters a price from, to and minimum RAM.
            //The program prints all phones with the given indicators.

            List<Smartphone> smartphones = new List<Smartphone>();

            Smartphone sOne = new Smartphone() {Price = 200,RAM = 1.5 };
            Smartphone sTwo = new Smartphone() {Price = 220,RAM = 1.6 };
            Smartphone sThree = new Smartphone() {Price = 240,RAM = 1.7 };
            Smartphone sFour = new Smartphone() { Price = 300, RAM = 3 };
            Smartphone sFive = new Smartphone() { Price = 300, RAM = 2.5 };

            smartphones.Add(sOne);
            smartphones.Add(sTwo);
            smartphones.Add(sThree);
            smartphones.Add(sFour);
            smartphones.Add(sFive);

            Console.WriteLine("Price From");
            double priceFrom = double.Parse(Console.ReadLine());
            Console.WriteLine("Price To");
            double priceTo = double.Parse(Console.ReadLine());
            Console.WriteLine("Minimum Ram");
            double minimumRam = double.Parse(Console.ReadLine());

            foreach (Smartphone sm in smartphones)
            {
                if (priceFrom < sm.Price && priceTo < sm.Price || minimumRam < sm.RAM)
                {
                    Console.WriteLine("Not enough money and the ram is less that target one");
                }
                else
                {
                    Console.WriteLine($"{sm.Price} {sm.RAM}");
                }
            }
        }
    }
}