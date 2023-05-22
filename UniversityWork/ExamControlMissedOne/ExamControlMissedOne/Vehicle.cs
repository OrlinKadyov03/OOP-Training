using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamControlMissedOne
{
    public abstract class Vehicle
    {
        public double Weight { get; set; }

        public Vehicle(double weight)
        {
            this.Weight = weight;
        }

        public abstract double CalculateTotalWeight();
    }
}
