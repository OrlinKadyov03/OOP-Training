using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW3_OOP
{
    public class Human
    {
        public string Name { get; set; }
        public List<Vitamin> Vitamins { get; set; }

        public Human(string name)
        {
            this.Name = name;
            this.Vitamins = new List<Vitamin>();
        }

        public void AddVitamin(Vitamin vitamin)
        {
            Vitamins.Add(vitamin);
        }
    }
}
