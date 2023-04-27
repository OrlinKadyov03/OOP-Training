using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thW2_Exercise
{
    public class Company
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Company(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }
    }
}
