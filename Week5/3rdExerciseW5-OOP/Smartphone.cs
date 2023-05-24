using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _3rdExerciseW5_OOP
{
    public class Smartphone : Computer
    {
        public List<string> numbers { get; set; } = new List<string>();

        public override string ToString()
        {
            return base.ToString()+string.Join("",numbers);
        }

    }
}
