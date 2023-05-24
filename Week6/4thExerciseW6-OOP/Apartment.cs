using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExerciseW6_OOP
{
    public class Apartment : Living
    {


        public override int PersonsCount { get; set; }

        public override double Quadrature()
        {
            return SquareFootage + TerraceArea;
        }
        public double TerraceArea { get; set; }
    }
}
