using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW6_OOP
{
    public class IceCream : Dish
    {
        public IceCream()
        {
            Name = "IceCream";
            Calories = 500;
            Type = DishType.Dessert;
        }
    }
}
