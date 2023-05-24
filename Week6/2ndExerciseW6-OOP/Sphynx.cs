using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExerciseW6_OOP
{
    public class Sphynx : Cat
    {
        public Sphynx(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Sphynx cat is moving");
        }

       public void MewMew()
        {
            Console.WriteLine("Mew Mew");
        }
    }
}
