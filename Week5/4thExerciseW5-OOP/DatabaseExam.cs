using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExerciseW5_OOP
{
    public class DatabaseExam : Exam
    {
        public DatabaseExam(string disciplineName, int points) : base(disciplineName, points)
        {
            MinimalPoints.Add(3, 55);
            MinimalPoints.Add(4, 70);
            MinimalPoints.Add(5, 80);
            MinimalPoints.Add(6, 90);

        }


    }
}
