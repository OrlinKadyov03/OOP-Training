namespace _7thExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Student class with Name and Grade properties.
            //Create a list of students then sort the students by success.

            List<Student> students = new List<Student>();

            Student st = new Student { Grade = 4 };
            Student stTwo = new Student { Grade = 6 };
            Student stThree = new Student { Grade = 3 };

            students.Add(st);
            students.Add(stTwo);
            students.Add(stThree);

            var sortBySuccess = from stu in students orderby stu.Grade descending select stu;

            foreach (var s in sortBySuccess)
            {
                Console.WriteLine(s.Grade);
            }
        }
    }
}