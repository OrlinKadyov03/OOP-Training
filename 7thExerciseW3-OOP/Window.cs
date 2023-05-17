using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thExerciseW3_OOP
{
    public class Window
    {
        public int Thickness { get; set; }



        public double GetTermallnsulation(Season season)
        {
            if (season.Name == "winter")
            {
                return 10 * Thickness / 100.0;
            }
            else if (season.Name == "autumn")
            {
                return  7 * Thickness / 100.0;
            }
            else if (season.Name == "spring")
            {
               return 3 * Thickness / 100.0;
            }
            else if (season.Name == "summer")
            {
                return 1 * Thickness / 100.0;
            }
            else
            {
                throw new ArgumentException("Invalid season name.");
            }

        }

    }
}
