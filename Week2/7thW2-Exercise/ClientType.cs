using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thW2_Exercise
{
    public class ClientType
    {
		private int level;
		public int Level
		{
			get { return level; }
			set { level = value; }
		}

		public ClientType(int level = 1)
		{
			this.Level = level;
		}

	}
}
