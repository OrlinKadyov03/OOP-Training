using System.Net.NetworkInformation;
using System.Reflection;

namespace _11thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Engine class.
            //Each engine has a horsepower and model.
            //Create a Car class.
            //The car has a make, model, year and engine
            //Using the classes from the above example, create a program in which the user enters two engines, then enters 2 cars.
            // Login:
            //408, Model One
            //306, Model Two
            //Bmw,535,2012,2
            //Mercedes,Cls,2012,1

            //On Separated Lines

            //Console.WriteLine("Enter the number of engines and cars");
            //int n = int.Parse(Console.ReadLine());
            //Engine[] engine = new Engine[n];  
            //for (int i = 0; i < n; i++)
            //{
            //    engine[i] = new Engine();

            //    engine[i].HorsePower = int.Parse(Console.ReadLine());
            //    engine[i].Model = Console.ReadLine();
            //}
            //Car[] car = new Car[n];
            //for (int i = 0; i < n; i++)
            //{
            //    car[i] = new Car();

            //    car[i].Make = Console.ReadLine();
            //    car[i].Model = Console.ReadLine();
            //    car[i].Year = int.Parse(Console.ReadLine());
            //    car[i].Engine = Console.ReadLine();
            //}
            //foreach (var eng in engine)
            //{
            //    Console.WriteLine($"{eng.HorsePower}, {eng.Model}");
            //}
            //foreach (var c in car)
            //{
            //    Console.WriteLine($"{c.Make},{c.Model},{c.Year},{c.Engine}");
            //}

            // On one line,input using (,)

            Console.WriteLine("Enter the number of engines and cars");
            int n = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] values = line.Split(',');
                Engine engine = new Engine()
                {
                   HorsePower = int.Parse(values[0]),
                   Model = values[1]
                };
                engines[i] = engine;
            }
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] values = line.Split(',');
                Car car = new Car()
                {
                    Make = values[0],
                    Model = values[1],
                    Year = int.Parse(values[2]),
                    Engine = values[3]
                };
                cars[i] = car;
            }
            foreach (var eng in engines)
            {
                Console.WriteLine($"{eng.HorsePower}, {eng.Model}");
            }
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.Make},{c.Model},{c.Year},{c.Engine}");
            }

        }
    }
}