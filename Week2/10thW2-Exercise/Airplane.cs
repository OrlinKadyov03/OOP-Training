using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10thW2_Exercise
{
    public class Airplane
    {
        public string CompanyName { get; set; }
        public Engine Engine { get; set; }
        public string Pilot { get; set; }
        public Airplane(string companyName, Engine engine, string pilot)
        {
            this.CompanyName = companyName;
            this.Engine = engine;
            this.Pilot = pilot;
        }
    }
}
