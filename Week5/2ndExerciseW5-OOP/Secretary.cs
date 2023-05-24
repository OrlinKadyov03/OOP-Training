using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExerciseW5_OOP
{
    public class Secretary:Employee
    {
       public List<string> messages { get; set; } = new List<string>();

        public Secretary(string name, int age) : base(name, age)
        {
            Salary = 1000m;
            this.messages = new List<string>();

        }
    }
}
