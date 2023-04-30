using System.Diagnostics;

namespace _6thW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task for independent work with a time of 5 min:
            //Create an Apartment class that has the required Quadrature and
            //PricePerSquareMeter.Create a Price property that is readonly and returns the price of the apartment using the formula PricePerSquareMeter * Quadrature
            //With a properly created class, you should be able to create an object like this:
            //Apartment a = new Apartment(100, 500);//100 - square footage. 500 - price per meter
            //Console.WriteLine(a.Price);//Output: 50000

            Apartment a = new Apartment(100, 500);
            Console.WriteLine(a.Price);
        }
    }
}