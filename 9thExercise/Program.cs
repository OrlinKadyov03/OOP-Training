namespace _9thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a TV class that has
            // make, model, screen size, price.
            // The user enters a TV from the console.
            // Input
            // Samsung
            // 5 Series
            // 40 
            // 1000
            // Output
            // Samsung,5 Series,40,1000


            TV televisor = new TV()
            {
                Make = Console.ReadLine(),
                Model = Console.ReadLine(),
                ScreenSize = Console.ReadLine(),
                Price = int.Parse( Console.ReadLine())
            };

            Console.WriteLine(string.Join(",",televisor.Make,televisor.Model,televisor.ScreenSize,televisor.Price));


        }
    }
}