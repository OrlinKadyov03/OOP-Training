using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thExerciseW3_OOP
{
    public class Smartphone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Ram { get; set; }
        public string Processor { get; set; }

        public Smartphone(string brand,string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public Smartphone(string brand,string model,double ram)
        {
            this.Brand = brand;
            this.Model = model;
            this.Ram = ram;
        }

        public Smartphone(string brand, string model, double ram, string processor)
        {
            this.Brand = brand;
            this.Model = model;
            this.Ram = ram;
            this.Processor = processor;
        }
    }
}
