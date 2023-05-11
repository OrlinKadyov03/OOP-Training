using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamControlMissedOne
{
    public class Car : Vehicle
    {

        public int PassengerCount { get; set; }
        public Car(double weight,int passengerCount) : base(weight)
        {
            this.PassengerCount = passengerCount;
        }

        public override double CalculateTotalWeight()
        {
            return Weight;
        }

    }
}
