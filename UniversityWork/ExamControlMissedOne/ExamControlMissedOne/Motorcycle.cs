using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamControlMissedOne
{
    public class Motorcycle : Vehicle 
    {
        public int HasSideCar { get; set; }
        public Motorcycle(double weight,int hassideCar) : base(weight)
        {
            this.HasSideCar = hassideCar;
        }

        public override double CalculateTotalWeight()
        {
            return Weight;

        }
    }
}
