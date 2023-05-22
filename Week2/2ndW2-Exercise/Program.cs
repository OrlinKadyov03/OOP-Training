using System.Collections.Generic;

namespace _2ndW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Car class with properties:
            //HorsePowers: int
            //Cylinders: int
            //Fuel: string,
            //Consumption: double readonly (only get)
            //The Consumption property is formed by the formula:
            //HorsePowers / (10 - Cylinders) / 6
            //Create a List of 3 Car objects and display the cost of each one

            List<Car> cars = new List<Car>();
            cars.Add(new Car() { HorsePowers = 154,Cylinders = 6,Fuel = "Petrol"}) ;
            cars.Add(new Car() { HorsePowers = 164, Cylinders = 4, Fuel = "Diesel" });
            cars.Add(new Car() { HorsePowers = 124, Cylinders = 4, Fuel = "Petrol" });
            foreach (var car in cars)
            {
                Console.WriteLine(car.Consumption);
            }

        }
    }
}