using System.Diagnostics.Metrics;
using System.IO;
using System.Security.Claims;
using System.Xml.Linq;
using System;

namespace _3rdExerciseW6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a Dish class with properties
            //Name: string, Calories: virtual double, and Type:
            //Enum(MainDish, Appetizer, Dessert). Make the classes:

            // Class Name Calories Category
            //Kebab 774 MainDish
            //Lasagne 284 MainDish
            //Soup 120 Appetizers
            //GreenSalad 10 Appetizer
            //Chocolate Explosion 1200 Dessert
            //Ice Cream 500 Dessert


            //Create a Client class with the properties IsOnDiet: bool,
            //IsEatingDesserts: bool, IsEatingMainDish: bool, IsEatingAppetizer: bool.
            //Create a Waiter class with the List<Dish> Dishes property.
            //Waiter has the method WaiterChoice(Client c): List<Dish>.
            //He receives a customer and checks whether the given customer is on a diet,
            //whether he will eat an appetizer, a main and a dessert.According to the options,
            //it selects a menu for it.If the person is on a diet,
            //take the dish with fewer calories from each category.
            //Print the waiter's choice for each customer on the screen.
            //Optional: Make the Name property automatically return the class name using GetType.

            Waiter waiter = new Waiter();

            Client client1 = new Client
            {
                IsOnDiet = true,
                IsEatingMainDish = true,
                IsEatingAppetizer = false,
                IsEatingDesserts = true
            };

            List<Dish> client1Choice = waiter.WaiterChoice(client1);

            Console.WriteLine("Waiter's choice for Client 1:");
            foreach (Dish dish in client1Choice)
            {
                Console.WriteLine($"{dish.Name} - {dish.Calories} calories");
            }

            Client client2 = new Client
            {
                IsOnDiet = true,
                IsEatingMainDish = false,
                IsEatingAppetizer = true,
                IsEatingDesserts = false
            };

            List<Dish> client2Choice = waiter.WaiterChoice(client2);

            Console.WriteLine("\nWaiter's choice for Client 2:");
            foreach (Dish dish in client2Choice)
            {
                Console.WriteLine($"{dish.Name} - {dish.Calories} calories");
            }
        }
    }
}
