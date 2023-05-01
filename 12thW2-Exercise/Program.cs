using System.Security.AccessControl;
using System.Xml.Linq;

namespace _12thW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a MyList class that will work exactly
            //like a List class, but only for integers.
            //You must create Add and Remove methods,
            //and this element must also be accessible
            //through an Indexer of your class.
            List<int> myLists = new List<int>() {2,3,4,5};
            
            myLists.Add(6);
            myLists.Remove(1);
            myLists[0] = 1;
            myLists[4] = 7;
            foreach (var m in myLists)
            {
                Console.WriteLine(m);
            }
  
        }
    }
}