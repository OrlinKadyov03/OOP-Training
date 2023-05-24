using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW5_OOP
{
    public class Computer
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Ram { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Model} {Ram}";
        }




    }
}
