using System.Runtime.Intrinsics.X86;

namespace _9thW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Cocktail class.
            //To create an object of the Cocktail class
            //we can only say how many milliliters of whiskey
            //to have or how many milliliters of whiskey
            //and cola to have or how many whiskey,
            //cola and ice to have. (All three values ​​are int).
            //Use this to avoid repeating code. As a final result,
            //you should be able to do the following:
            //Cocktail c = new Cocktail(10);
            //Cocktail c1 = new Cocktail(10,20);
            //Cocktail c2 = new Cocktail(10, 20, 30);

            Cocktail c = new Cocktail(10);
            Cocktail c1 = new Cocktail(10, 20);
            Cocktail c2 = new Cocktail(10, 20, 30);

            Console.WriteLine(c.MlWhiskey);
            Console.WriteLine(string.Join(",",c1.MlWhiskey,c1.MlWhiskeyCola));
            Console.WriteLine(string.Join(",",c2.MlWhiskey,c2.MlWhiskeyCola,c2.MlWhiskeyColaIce));

    }
    }
}