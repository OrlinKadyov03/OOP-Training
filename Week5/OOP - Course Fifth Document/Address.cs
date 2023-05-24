using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Course_Fifth_Document
{
    public class Address
    {
        public string CityName { get; set; }

        public string CountryName { get; set; }

        public string StreetName { get; set; }

        public Address(string cityName,string countryName,string streetName)
        {
            this.CityName = cityName;
            this.CountryName = countryName;
            this.StreetName = streetName;
        }
    }
}
