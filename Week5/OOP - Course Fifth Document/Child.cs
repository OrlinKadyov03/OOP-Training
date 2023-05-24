using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Course_Fifth_Document
{
    public class Child : Person
    {
        public Child(string name, int age, string address) : base(name, age, address)
        {

        }

        public string Play()
        {
            return $"I'm a child!";
        }
    }
}
