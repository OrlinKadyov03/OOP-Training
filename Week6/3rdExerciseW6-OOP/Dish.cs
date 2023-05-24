using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW6_OOP
{

    public enum DishType
    {
        MainDish,
        Appetizer,
        Dessert
    }

   public class Dish
    {
        public string Name { get; set; }
        public virtual double Calories { get; set; }
        public DishType Type { get; set; }

    }
}
