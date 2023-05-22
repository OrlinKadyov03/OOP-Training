namespace _3rdExercise
{
    internal class Program
    {

        //The user enters five numbers in a list.
        //The program displays the sum of the numbers.
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> nums = new List<int>() ;
            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("The sum is {0}",sum);
        }
    }
}