using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thExercise
{
    public class Dish
    {
        public List<Ingridient> ingridients { get; set; } = new List<Ingridient>();

        public string Name { get; set; }
    }
}
