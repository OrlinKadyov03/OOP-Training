using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _8thW2_Exercise
{
    public class CoffeeMachine
    {
        public CoffeeMachine(int numberShortCof,int numberLongCof,int numbOfTeas)
        {
            this.numberOfShortCoffes = numberShortCof;
            this.numberofLongCoffes = numberLongCof;
            this.numberOfTeas = numbOfTeas;
        }
        public int numberOfShortCoffes;
        public int numberofLongCoffes;
        public int numberOfTeas;

        public void MakeDring(string drink)
        {
            if (drink == "short-coffee")
            {
                numberOfShortCoffes--;
            }
           else if (numberOfShortCoffes <=0)
            {
                CallService();
            }
            else if (drink == "coffee")
            {
                numberofLongCoffes--;
            }
            else if (numberofLongCoffes <= 0)
            {
                CallService();
            }
            else if (numberOfTeas <= 0)
            {
                CallService();
            }
            else if (drink == "tea")
            {
                numberOfTeas--;
            }
        }

        private void CallService()
        {
            throw new ArgumentException("There is no quantity.");
        }
    }
}
