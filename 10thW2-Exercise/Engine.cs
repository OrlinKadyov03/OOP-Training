using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10thW2_Exercise
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public int OilCapacity { get; set; }
        public Engine(int horsePower, int oilCapacity)
        {
            this.HorsePower = horsePower;
            this.OilCapacity = oilCapacity;
        }
    }
}
