using static System.Net.Mime.MediaTypeNames;

namespace _4thExerciseW5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We create a class Exam with properties DesciplineName:
            //string, Points: int and virtual Dictionary<int, int> MinimalPoints
            //and method FinalGrade(): int which returns the final grade as an int.
            //MinimalPoints is a dictionary in which the key is the grade
            //and the value is the minimum points for that grade.
            //We create classes BasicExam, AlgorithmExam, DatabaseExam inheriting the class Exam.
            //Create appropriate constructors and test different classes with different points.

            Exam examOne = new BasicExam("Math",70);

            Console.WriteLine($"{examOne.DisciplineName} {examOne.Points} {examOne.FinalGrade()}");

            Exam examTwo = new AlgorithmExam("SQL", 90);

            Console.WriteLine($"{examTwo.DisciplineName} {examTwo.Points} {examTwo.FinalGrade()}");

            Exam examThree = new DatabaseExam("Physics", 90);

            Console.WriteLine($"{examThree.DisciplineName} {examThree.Points} {examThree.FinalGrade()}");
        }
    }
}