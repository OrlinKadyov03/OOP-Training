using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace _3rdExerciseW3_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a class Vitamin (vitamin) with the property Name: string.
            //Create a class Human that has a list of vitamins.
            //The user enters the number N and then enters N number of names in sequence,
            //then enters N rows of vitamins separated by commas.
            //The program prints each person and their vitamins.
            List<Human> humans = new List<Human>();
            List<Vitamin> vitamins = new List<Vitamin>();

            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            string[] vitaminInput = new string[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                vitaminInput[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                string name = names[i];
                Human human = new Human(name);

                string[] vitaminNames = vitaminInput[i].Split(',');

                foreach (string vitaminName in vitaminNames)
                {
                    Vitamin vitamin = new Vitamin(vitaminName);
                    human.AddVitamin(vitamin);
                    vitamins.Add(vitamin);
                }

                humans.Add(human);
            }


            foreach (Human human in humans)
            {
                Console.Write($"{human.Name} - ");
                foreach (Vitamin vitamin in human.Vitamins)
                {
                    Console.Write($"{vitamin.Name}, ");
                }
                Console.WriteLine();
            }
        }
    }
}