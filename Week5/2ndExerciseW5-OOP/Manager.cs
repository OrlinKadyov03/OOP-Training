using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExerciseW5_OOP
{
    public class Manager:Employee
    {
       public List<string> Tasks { get; set; } = new List<string>();

        public Manager(string name, int age) : base(name, age)
        {
            Salary = 1000m;
            CalculateSalary();
        }

        public void CalculateSalary()
        {
            Salary = 2000m + (20m * Tasks.Count);
        }
    }
}
