using System.Security.Cryptography.X509Certificates;

namespace OOP___Course_Fourth_Document
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define an array of 5 integer elements.
            //With Linq, cast all even elements to a new array

            int[] array = new int[] {1,2,3,4,5};
            int[] arrayTwo = array.Where(x=>x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(",",arrayTwo));
        }
    }
}