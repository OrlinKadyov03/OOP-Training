using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12thW2_Exercise
{
    public class MyList
    {
		
        private List<int> lists = new List<int>();
		// Declarating Indexer,elements

		//We can use indexer to set values to the elements, which easy and very good way!
		public int this[int index]
		{
			// get and set accessors	
       		get { return lists[ index]; }
			set { lists[index] = value; }
		}

		public void Add(int item)
		{
			lists.Add(item);
		}
		public void Remove(int item)
		{
			lists.Remove(item);
		}
	}
}
