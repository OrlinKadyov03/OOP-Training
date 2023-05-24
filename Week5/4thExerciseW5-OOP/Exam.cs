using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExerciseW5_OOP
{
    public class Exam
    {
        public string DisciplineName { get; set; }
        public int Points { get; set; }
        public virtual Dictionary<int, int> MinimalPoints { get; set; }=new Dictionary<int, int>();

        public Exam(string disciplineName, int points)
        {
            DisciplineName = disciplineName;
            Points = points;

        }

        public virtual int FinalGrade()
        {
            int finalGrade = 2;

            foreach (var kvp in MinimalPoints)
            {
                if (Points >= kvp.Value)
                    finalGrade = kvp.Key;
                else
                    break;
            }

            return finalGrade;
        }
    }
}