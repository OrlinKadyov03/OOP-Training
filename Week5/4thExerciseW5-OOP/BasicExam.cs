using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExerciseW5_OOP
{
    public class BasicExam : Exam
    {
        public BasicExam(string disciplineName, int points) : base(disciplineName, points)
        {
            MinimalPoints.Add(3, 50);
            MinimalPoints.Add(4, 70);
            MinimalPoints.Add(5, 85);
            MinimalPoints.Add(6, 90);
        }
    }
}
