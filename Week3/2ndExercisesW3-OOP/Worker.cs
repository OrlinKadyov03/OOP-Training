using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExercisesW3_OOP
{
    public class Worker
    {
        public void FixBenchesInPark(Park park)
        {
            park.benches.Where(bn => bn.isBroken).ToList().ForEach(bn => bn.isBroken = false);
            return;
            
        }
    }
}
