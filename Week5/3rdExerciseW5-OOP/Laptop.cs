using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW5_OOP
{
    public class Laptop : Computer
    {
        public string Display { get; set; }

        public override string ToString()
        {
            return base.ToString() + Display;
        }


    }
}
