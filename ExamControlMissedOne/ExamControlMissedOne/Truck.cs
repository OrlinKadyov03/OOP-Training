using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamControlMissedOne
{
    public class Truck : Vehicle
    {
        public double CargoWeight { get; set; }
        public Truck(double weight, double cargoWeight) : base(weight)
        {
            this.CargoWeight = cargoWeight;
        }
        public override double CalculateTotalWeight()
        {
            return Weight + CargoWeight;
        }
    }
}
