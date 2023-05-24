using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thExerciseW5_OOP
{
    public class Animal
    {
        public string Name { get; set; }

        public enum Type 
        { 
            Predator,
            Herbivorous
        }

        public void Meet(Animal animal)
        {
            if (animal.Equals(Type.Predator) && animal.Equals(Type.Herbivorous))
            {
                Console.WriteLine($"{this.Name} is a predator and {animal.Name} is herbivorous.");
                Console.WriteLine($"{this.Name} attacks {animal.Name}!");
            }
            else if (animal.Equals(Type.Herbivorous) && animal.Equals(Type.Predator))
            {
                Console.WriteLine($"{this.Name} is herbivorous and {animal.Name} is a predator.");
                Console.WriteLine($"{animal.Name} attacks {this.Name}!");
            }
            else
            {
                Console.WriteLine($"{this.Name} and {animal.Name} are of the same type or both herbivorous.");
                Console.WriteLine("They peacefully coexist.");
            }
        }
    }
}
