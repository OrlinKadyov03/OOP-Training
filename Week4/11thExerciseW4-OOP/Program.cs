namespace _11thExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user enters 10 numbers into an array.
            // Remove duplicates using a LINQ query.

            int[] array = new int[] { 2, 2, 3, 2, 6, 7, 8, 9, 8 };

            var withoutDuplicate = array.Distinct().ToArray();

            foreach (var item in withoutDuplicate)
            {
                Console.WriteLine(item);
            }
        }
    }
}