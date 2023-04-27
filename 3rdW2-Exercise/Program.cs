using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System;
using System.Diagnostics;

namespace _3rdW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Train class with passengerLog and passengerCount fields.
            //Add the Add(int passengers) method that adds passengers to the train.
            //Each time a passenger is added to the train, we increment the passengerCount\
            //value by the passed passengers parameter,
            //but also write the following information to the passengerLog field:
            // “{ passangers}
            // added to train\n”
            //Add a string Log property that is readonly and returns the accumulated log to date.
            //Create an object of the Train class and use the Add method several times.Then show the console logos.


            Train trains = new Train();
            trains.Add(2);
            Console.WriteLine($"Passenger count: {trains.passengerCount}");
            Console.WriteLine($"Passenger log: {trains.passengerLog}");
            trains.Add(2);
            trains.Add(2);
            Console.WriteLine($"Passenger count: {trains.passengerCount}");
            Console.WriteLine($"Passenger log: {trains.passengerLog}");



        }
    }
}