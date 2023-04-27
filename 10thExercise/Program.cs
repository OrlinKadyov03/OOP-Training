using System.IO;
using System.Net.Http.Headers;

namespace _10thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Movie class, each movie has a name, year and director.Make a program where the user enters many movies.
            //Login:
            //Alien, 1979, Ridley Scott
            //Predator, 1987, John McTiernan
            //end
            //Output:
            //Movie: Alien - Year: 1979 - Ridley Scott
            //Movie: Predator - Year: 1987 - John McTiernan

            // on every line

            //int n = int.Parse(Console.ReadLine());
            //Movie[] movies = new Movie[n];
            //for (int i = 0; i < n; i++)
            //{
            //    movies[i] = new Movie();

            //    movies[i].Name = Console.ReadLine();
            //    movies[i].Year = int.Parse(Console.ReadLine());
            //    movies[i].Director = Console.ReadLine();

            //}
            //foreach (var movie in movies)
            //{
            //    Console.WriteLine($"{movie.Name} - Year: {movie.Year} - {movie.Director}");
            //}

            // On one line,input using (,)

            int n = int.Parse(Console.ReadLine());
            Movie[] movies = new Movie[n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] values = line.Split(',');
                Movie movie = new Movie()
                {
                    Name = values[0],
                    Year = int.Parse(values[1]),
                    Director = values[2]
                };
                movies[i] = movie;
            }
            Console.WriteLine("List of movies: ");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Name} - Year: {movie.Year} - {movie.Director}");
            }


        }
    }
}