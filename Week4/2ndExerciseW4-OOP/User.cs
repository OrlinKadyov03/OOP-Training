﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndExerciseW4_OOP
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public User(int id, string name)
        {
            this.Id = id;
            this.Name = name;    
        }
    }
}
