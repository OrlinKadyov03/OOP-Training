namespace _8thExerciseW3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Building class with the Quadrature property.
            //Create a City class that contains a List<Building>.
            //Create a method in the City class that finds
            //the total square footage of the buildings in the city.

            // Create buildings
            Building building1 = new Building();
            Building building2 = new Building();
            Building building3 = new Building();

            building1.Quadrature = 12;
            building2.Quadrature = 15;
            building3.Quadrature = 17;

            // Create city and add buildings to it
            City city = new City();
            city.buildings = new List<Building> { building1, building2, building3 };

            // Calculate total square footage of the buildings in the city
            double totalSquareFootage = city.TotalSquareFootage();
            Console.WriteLine("Total Square Footage: " + totalSquareFootage);


        }
    }
}