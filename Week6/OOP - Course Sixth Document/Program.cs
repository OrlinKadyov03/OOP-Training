namespace OOP___Course_Sixth_Document
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create an abstract class Shape with an abstract method double Area().
            //Make the Rectangle, Triangle,
            //Circle classes inherit from the Shape class.
            //Create appropriate class constructors.

            Rectangle rectangle = new Rectangle(4, 5);
            Triangle triangle = new Triangle(3, 6);
            Circle circle = new Circle(2);

            Console.WriteLine(rectangle.Area());
            Console.WriteLine(triangle.Area());
            Console.WriteLine(circle.Area());
        }
    }
}