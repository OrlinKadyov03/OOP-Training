using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System;

namespace _3rdExerciseW5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Computer class with the properties Brand:
            //string, Model: string, Ram: double. Create a Laptop class inheriting Computer.
            //It has the string Display property.
            //Create a class Smartphone inheriting Computer.It has an array of numbers in it.
            //The user enters information on a single line for a laptop or smartphone as follows.
            // {Brand},{Model},{Ram},{Display} - for Laptop
            // { Brand},{ Model},{ Ram},{ Tel_1},{ Tel_2}.....{ Tel_N}- for Smartphone
            //We assume that the user will always enter at least 2 numbers.
            //That's how we'll know if it's a phone or a laptop.
            //Override the ToString method so that in the Computer class it concatenates
            //the properties as follows:
            //For the Computer class: “{Brand},{ Model},{ Ram}”
            //About the Laptop class: "{Brand},{ Model},{Ram},{Display}"
            //About the Smartphone class: { Brand},{ Model},{ Ram},{ Tel_1},{ Tel_2}.....{ Tel_N}
            //We mustn't forget that we can use base!
            //All objects are added to a list of computers.Finally,
            //we display all the object data by calling the ToString() method.

            List<Computer> computers = new List<Computer>();
            computers.Add(new Laptop());
            computers.Add(new Smartphone());
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") { break; }
                string[] line = input.Split(',');

                if (line.Length == 4)
                {
                    Laptop l = new Laptop()
                    {
                        Brand = line[0],
                        Model = line[1],
                        Ram = double.Parse(line[2]),
                        Display = line[3]
                    };
                    computers.Add(l);
                }
                else
                {
                    Smartphone s = new Smartphone()
                    {
                        Brand = line[0],
                        Model = line[1],
                        Ram = double.Parse(line[2]),
                        numbers = line.Skip(3).ToList()
                    };
                    computers.Add(s);
                }
            }
            foreach (var device in computers)
            {
                Console.WriteLine(device);
            }

        }

    }
}

