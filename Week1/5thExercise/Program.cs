namespace _5thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Restaurant class and a Dish class.
            //At Restaurant we have a list from Dish.
            //Each dish has an Ingredient list.
            //Each ingredient name Name.
            //Create a list of several restaurants,
            //with each restaurant having several dishes.
            //The user enters the name of an ingredient
            //and the program prints to him at which restaurant
            //and what he can eat with the given ingredient.

            
            List<Restaurant> restaurantOne = new List<Restaurant>();

            List<Dish> Dishes = new List<Dish>();

            string ingri = Console.ReadLine();


            Restaurant restaurant = new Restaurant() { Name = "Paradise"} ;
            Restaurant restaurantBig = new Restaurant() { Name = "Orlin's Restaurant" };
            Ingridient ing = new Ingridient() { Name = "Svinsko" };
            Ingridient ingTwo = new Ingridient() { Name = "Pileshko" };
            Dish dish = new Dish() {Name = "Svinsko sys zele" };
            Dish dishTwo = new Dish() { Name = "Pileshko s gybi" };


            dishTwo.ingridients.Add(ingTwo);
            dish.ingridients.Add(ing);
            restaurant.Dishes.Add(dish);
            restaurantBig.Dishes.Add(dishTwo);
            restaurantOne.Add(restaurant);
            restaurantOne.Add(restaurantBig);



            var res = restaurantOne.Where(x => x.Dishes.Any(d => d.ingridients.Any(z => z.Name.ToLower() == ingri.ToLower()))).ToList();

            foreach (var r in res)
            {
                Console.WriteLine(r.Name);
            }

        }
    }
}