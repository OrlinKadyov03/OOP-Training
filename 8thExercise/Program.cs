namespace _8thExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a Square class with a side field.
            // Write a method that returns the perimeter of the square.

            Square square = new Square()
            {
                side = int.Parse(Console.ReadLine())
                
            };
            Console.WriteLine(square.SquareP(square.side));
        }
    }
}