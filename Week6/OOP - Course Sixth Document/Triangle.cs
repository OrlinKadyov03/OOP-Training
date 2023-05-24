using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Course_Sixth_Document
{
    public class Triangle : Shape
    {

        public double Base { get; set; }

        public double Height { get; set; }


        public override double Area()
        {
           return 0.5 + Base * Height;
        }

        public Triangle(double basee, double height)
        {
            this.Base = basee;
            this.Height = height;
        }
    }
}
