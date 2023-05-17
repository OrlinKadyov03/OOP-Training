using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thExerciseW3_OOP
{
    public class Autopark
    {
        public List<Car> cars { get; set; } = new List<Car>();

        public double TotalSum()
        {
            double sum = 0;

            foreach (Car car in cars)
            {
                sum += car.Price;
            }

            return sum;
        }
    }
}
