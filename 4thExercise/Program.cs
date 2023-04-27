namespace _4thExercise
{
    internal class Program

    {   //The user enters 10 numbers.
        //The program displays only the unique numbers.
        //Use HashSet.
        static void Main(string[] args)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                uniqueNumbers.Add(num);
            }
            Console.WriteLine("Unique numbers:");
            foreach (int unique in uniqueNumbers)
            {
                Console.WriteLine(unique);
            }
        }
    }
}