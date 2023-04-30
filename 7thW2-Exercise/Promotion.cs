using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _7thW2_Exercise
{
    public class Promotion 
    {
        // Adding Constructor
        //Taking properties
        public Promotion(ClientType clientType,int priceWithoutdiscount)
        {
            this.ClientType = clientType;
            this.priceWithoutDiscount = priceWithoutdiscount;
        }

        // Insert number of level, from ClienType class
        public ClientType ClientType { get; set; }
        // Properties that includes only the price.
        public double priceWithoutDiscount { get; set; }
        // Implementation of the logic
        public double Discount
        {         
            get
            {
                if (ClientType.Level == 1)
                {
                    return 0;
                }
                // if level == 2 , priceWithoutDiscount = priceWithoutDiscount * 0.15;
                else if (ClientType.Level == 2)
                {
                   return  priceWithoutDiscount *= 0.15;
                }
                else if (ClientType.Level == 3)
                {
                   return  priceWithoutDiscount *= 0.25;
                }
                else
                {
                    throw new InvalidOperationException("Invalid client level.");
                }
            }
        }
        // formula
        public double finalPrice { get=>priceWithoutDiscount-Discount; }

    }
}
