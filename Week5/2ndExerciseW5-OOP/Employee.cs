using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExerciseW5_OOP
{
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual decimal Salary { get; set; }

        public Employee(string name, int age)
        {
           this. Name = name;
           this. Age = age;
        
        }
    }
}
