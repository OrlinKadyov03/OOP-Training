using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thW2_Exercise
{
    public class Apartment
    {
        public int Quadrature { get; set; }

        public int PricePerSquareMeter { get; set; }

        public int Price { get=> PricePerSquareMeter * Quadrature; }

        public Apartment(int quadrature,int pricePerSquareMeter)
        {
            this.Quadrature = quadrature;
            this.PricePerSquareMeter = pricePerSquareMeter;
        }
    }
}
