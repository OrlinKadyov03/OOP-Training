using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thW2_Exercise
{
    public class University 
    {
        [Required]
        public string Name { get; set; }
        public string Country { get; set; }

        public List<Student> Students = new List<Student>();
    }
}
