using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace _7thW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Promotion class and a ClientType class.
            //The ClientType class has the property Level: int. By default,
            //this property has the value 1, which is defined in the constructor.
            //The Promotion class accepts in the constructor
            //ClientType as a required parameter and priceWithoutDiscount.
            //The Promotion class has the Discount property, which is defined by the following logic:
            //If the customer is level 1 (Level == 1), then the discount is 0
            //If the customer is level 2 the discount is 15%
            //If the customer is level 3 the discount is 25%
            //The FinalPrice property is determined by the priceWithoutDiscount and the subtracted discount
            //Create several objects of the Promotion class and test if the calculations are correct!


            ClientType clientType = new ClientType() { Level = 3};
            Promotion pOne = new Promotion(clientType,100);
            Console.WriteLine(pOne.finalPrice);

            ClientType clientTypeTwo = new ClientType() { Level = 2 };
            Promotion pOneTwo = new Promotion(clientTypeTwo, 100);
            Console.WriteLine(pOneTwo.finalPrice);

            ClientType clientTypeThree = new ClientType() { Level = 1 };
            Promotion pOneTwoThree = new Promotion(clientTypeThree, 100);
            Console.WriteLine(pOneTwoThree.finalPrice);






        }
    }
}