namespace _10thW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create an Engine class that has the properties
            //HorsePowers, OilCapacity.
            //Create an Airplane class that has CompanyName:
            //string, Engine: engine, and Pilot:
            //string properties.To create a new Airplane we must have
            //Company Name and Engine or Engine and Pilot.


            Engine engine = new Engine(15000,150) { };
            Airplane a = new Airplane("BulgarianAir", engine, "Ivo"){};
            Console.WriteLine($" The company name is {a.CompanyName}, " +
                $"horsepowers are {a.Engine.HorsePower}," +
                $"the engine oil capacity is {a.Engine.OilCapacity}" +
                $" and the pilot name is {a.Pilot}");
        }
    }
}