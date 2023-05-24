using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExerciseW5_OOP
{
    public class AlgorithmExam : Exam
    {
        public AlgorithmExam(string disciplineName, int points) : base(disciplineName, points)
        {
            MinimalPoints.Add(3, 60);
            MinimalPoints.Add(4, 75);
            MinimalPoints.Add(5, 90);
            MinimalPoints.Add(6, 95);
        }

    }
}
