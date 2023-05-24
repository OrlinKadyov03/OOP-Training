using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Course_Sixth_Document
{
    public class Circle : Shape
    {
        public double radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
}
