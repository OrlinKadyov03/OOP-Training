namespace _3rdExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Define an array of 10 elements.
            // The user enters the number N,
            // after which the program displays
            // how many times the number N occurs in the array.

            int[] array = new int[] { 1, 2, 2, 4, 5, 6, 7, 8, 9, 10 };

            int n = int.Parse(Console.ReadLine());

            var result = array.Where(a => a.Equals(n)).Count().ToString().ToArray();
            Console.WriteLine(string.Join("",result));
        }
    }
}