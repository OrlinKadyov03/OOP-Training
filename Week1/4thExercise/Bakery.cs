using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thExercise
{
    public class Bakery
    {
        public List<Muffin> muffins { get; set; } = new List<Muffin>();
        public Bakery(List<Muffin> Muffins)
        {
            this.muffins = Muffins;
        }
        public void Order(string name,int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                muffins.Add(new Muffin { Name = name });
            }

        }
    }
}
