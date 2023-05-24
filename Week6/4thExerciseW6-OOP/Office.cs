using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _4thExerciseW6_OOP
{
    public class Office : Industry
    {
        public override string CompanyName { get;set; }

        public override double Quadrature()
        {
            return SquareFootage;
        }
        public int EmployeeCount { get; set; }
    }
}
