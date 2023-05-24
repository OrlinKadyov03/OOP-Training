using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW6_OOP
{
    public class Soup : Dish
    {
        public Soup()
        {
            Name = "Soup";
            Calories = 120;
            Type = DishType.Appetizer;
        }
    }
}
