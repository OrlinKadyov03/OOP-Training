using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndW2_Exercise
{
    public class Car
    {
        //HorsePowers: int
        //Cylinders: int
        //Fuel: string,
        //Consumption: double readonly (only get)
        //The Consumption property is formed by the formula:
        //HorsePowers / (10 - Cylinders) / 6

        public int HorsePowers { get; set; }
        public int Cylinders { get; set; }
        public string Fuel { get; set; }
        public double Consumption { get => HorsePowers / (10 - Cylinders) / 6; }
    }
}
