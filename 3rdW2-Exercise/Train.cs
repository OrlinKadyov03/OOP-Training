using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdW2_Exercise
{
    public class Train
    {
        //Add the Add(int passengers) method that adds passengers to the train.
        //Each time a passenger is added to the train, we increment the passengerCount
        //value by the passed passengers parameter,
        //but also write the following information to the passengerLog field:
        // “{ passangers}
        // added to train\n”
        public string passengerLog;
        public int passengerCount;

        public void Add(int passengers)
        {
            passengerCount += passengers;
            passengerLog += $"{passengers} added to train\n";
        }
    }
}
