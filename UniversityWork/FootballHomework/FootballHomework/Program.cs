using FootballHomework.Models.FootballModels;
using FootballHomework.Models.PersonModels;

namespace FootballHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> footballPlayers = new List<FootballPlayer>();
            Console.WriteLine("Enter how many players will play.");
            int n = int.Parse(Console.ReadLine());
           
           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter name of the player");
                string playerName = Console.ReadLine();

                Console.WriteLine("Enter age of the player");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number of the player");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter height of the player");
                double height = double.Parse(Console.ReadLine());

                FootballPlayer fp = new FootballPlayer()
                {
                    Name = playerName,
                    Age = age,
                    Number = number,
                    Height = height
                };

                footballPlayers.Add(fp);    
       
            }
            Console.WriteLine("Enter couch: ");

            Console.WriteLine("Name ");
            string coachName = Console.ReadLine();

            Console.WriteLine("Age ");
            int coachAge = int.Parse(Console.ReadLine());

            Coach coach = new Coach()
            {
                Name = coachName,
                Age = coachAge
            };

            Team team = new Team()
            {
                Coach = coach,
                footballPlayers = footballPlayers,
                Average = footballPlayers.Average(p => p.Age)
            };

            Console.WriteLine($"Coach: {team.Coach.Name}");
            Console.WriteLine($"Average age: {team.Average}");

            Console.WriteLine("Players");
            foreach (FootballPlayer footballPlayer in team.footballPlayers)
            {
                Console.WriteLine($"Name:{footballPlayer.Name} Age:{footballPlayer.Age} Number:{footballPlayer.Number} Height:{footballPlayer.Height}");
            }
        }
    }
}