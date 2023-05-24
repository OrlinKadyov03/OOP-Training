using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace _5thExerciseW5_OOP
{
    internal class Program
    {
        static void Main()
        {

            //Create an Animal class with the property Name: string and Type: Enum(Predator, Herbivorous). Create the Lion, Snake, Elephant, Gazelle classes inheriting the Animal class.
            //Create in the Animal class the method Meet(Animal animal). He accepts an animal and checks that the two animals are of the same type.If it happens that there is a predator and a herbivore - the predator removes the herbivore from the list.
            //In the main program, create a method that generates you N random numbers of animals and returns a list of animals.Then create a Nature method that takes this list of animals and randomly encounters N times two by two the animals, performing the logic of the Meet method.
            Console.WriteLine("Enter how many animals you want to generate");
            int N = int.Parse(Console.ReadLine()); ;
            List<string> randomAnimals = GenerateRandomAnimals(N);
            Console.WriteLine("List of random animals:");
            foreach (string animal in randomAnimals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("Enter how many meets you want to generate");
            int M = int.Parse(Console.ReadLine());
            Nature(randomAnimals, M);
        }

        static List<string> GenerateRandomAnimals(int N)
        {
            List<string> animals = new List<string>()
        {
            "dog",
            "cat",
            "fish",
            "rabbit",
            "hamster",
            "cow",
            "horse",
            "bird",
            "lion",
            "tiger"
        };

            Random random = new Random();
            List<string> randomAnimals = new List<string>();

            for (int i = 0; i < N; i++)
            {
                int randomIndex = random.Next(0, animals.Count);
                string randomAnimal = animals[randomIndex];
                randomAnimals.Add(randomAnimal);
            }

            return randomAnimals;
        }

        static void Nature(List<string> animalList, int N)
        {
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                int index1 = random.Next(0, animalList.Count);
                int index2 = random.Next(0, animalList.Count);

                string animal1 = animalList[index1];
                string animal2 = animalList[index2];

                Meet(animal1, animal2);
            }
        }

        static void Meet(string animal1, string animal2)
        {
            Console.WriteLine("Meeting between {0} & {1}", animal1, animal2);

        }
    }
}