using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW6_OOP
{
    public class Waiter
    {
        public List<Dish> Dishes { get; set; }
        public Waiter()
        {
            Dishes = new List<Dish>()
            {
                new Kebab(),
                new Lasange(),
                new IceCream(),
                new GreenSalad(),
                new ChocolateExplosion(),
                new Soup()
            };
            
        }
        public List<Dish> WaiterChoice(Client client)
        {
            List<Dish> chosenDishes = new List<Dish>();

            List<Dish> availableDishes = new List<Dish>(Dishes);

            foreach (Dish dish in availableDishes)
            {
                if (client.IsOnDiet && dish.Calories < MinimalCalories(dish.Type))
                {
                    chosenDishes.Add(dish);
                    Dishes.Remove(dish);
                }
                else if (client.IsEatingMainDish && dish.Type == DishType.MainDish)
                {
                    chosenDishes.Add(dish);
                    Dishes.Remove(dish);
                }
                else if (client.IsEatingAppetizer && dish.Type == DishType.Appetizer)
                {
                    chosenDishes.Add(dish);
                    Dishes.Remove(dish);
                }
                else if (client.IsEatingDesserts && dish.Type == DishType.Dessert)
                {
                    chosenDishes.Add(dish);
                    Dishes.Remove(dish);
                }
            }

            return chosenDishes;
        }
        public double MinimalCalories(DishType type)
        {
            double min = double.MaxValue;
            foreach (Dish dish in Dishes)
            {
                if (dish.Type == type && dish.Calories < min)
                {
                    min = dish.Calories;
                }
            }

            return min;
        }


    }
}
