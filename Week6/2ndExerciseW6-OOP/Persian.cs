using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExerciseW6_OOP
{
    public class Persian : Cat
    {
        public Persian(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Persian cat is moving.");
        }

       public void Jump()
        {
            Console.WriteLine("Persian cat jumping.");
        }
    }
}
