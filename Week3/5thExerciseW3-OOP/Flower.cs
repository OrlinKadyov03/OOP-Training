using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thExerciseW3_OOP
{
    public class Flower
    {
        public string Name { get; set; }
        public int Water { get; set; }

        public Flower(string name, int water)
        {
           this.Name = name;
           this.Water = water;
        }
    }
}
