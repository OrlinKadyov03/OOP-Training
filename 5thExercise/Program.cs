namespace _5thExercise
{
    internal class Program
    {

        //User enters student name and grade.
        //Student names are unique.
        //Use a Dictionary data structure to store the data.
        //Then show all students and their grades.
        static void Main(string[] args)
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();
            while (true)
            {
                Console.WriteLine("Enter student name (or 'e' to end)");
                string name = Console.ReadLine();
                if (name == "e")
                {
                    break;
                }
                Console.WriteLine("Enter student grade");
                int grade = int.Parse(Console.ReadLine());
                studentGrades.Add(name, grade);
            }
            Console.WriteLine("All students and their grades:");
            foreach (var pair in studentGrades)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}