using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _8thExerciseW3_OOP
{
    public class City
    {
        public List<Building> buildings { get; set; } = new List<Building>();

        public double TotalSquareFootage()
        {
            double totalSquareFootage = 0;
            foreach (Building buildi in buildings)
            {
                totalSquareFootage += buildi.Quadrature;
            }

            return totalSquareFootage;
        }
    }
}
