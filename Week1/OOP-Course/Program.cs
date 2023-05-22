using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace OOP_Course
{
    internal class Program
    {

        //Define a list of numbers.
        //Add the numbers 3,2,7,5,3
        //then remove the number 3 and display
        //all the numbers in the list.
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {3,2,7,5,3};
            var nums = numbers.Where(n => n != 3);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
      
        }
    }
}