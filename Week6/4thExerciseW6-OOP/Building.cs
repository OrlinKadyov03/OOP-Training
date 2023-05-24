using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExerciseW6_OOP
{
    public abstract class Building
    {
        public int Type { get; set; }
        public double SquareFootage { get; set; }
        public int NumberOfInhabitants { get; set; }
        public double SquareFootageOfTheYard { get; set; }
        public abstract double Quadrature();

    }
}
