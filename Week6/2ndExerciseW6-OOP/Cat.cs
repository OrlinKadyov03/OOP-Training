using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExerciseW6_OOP
{
    public abstract class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public abstract void Move();

        public Cat(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
