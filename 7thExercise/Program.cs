using System.Data.Common;

namespace _7thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Cat class.
            //The cat has name, age, and color as public fields.
            //Create two objects of the Cat class.
            //Using the Cat class, write a program in
            //which the user enters information about a cat.
            //Input
            // Tom
            // 5
            // Blue
            // OutPut
            // Tom,5,Blue

            Cat catOne = new Cat() 
            { 
                name = Console.ReadLine(),
                age = int.Parse(Console.ReadLine()), 
                color = Console.ReadLine()
            };

            Console.WriteLine(string.Join(",",catOne.name,catOne.age,catOne.color));
        }
    }
}