using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Course_Sixth_Document
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }

        public double Breadth { get; set; }
        public override double Area()
        {
            return Length * Breadth;
        }

        public Rectangle(double length, double breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }
    }
}
