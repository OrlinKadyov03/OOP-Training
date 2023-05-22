using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course___SecondDocument
{
    public class Animal
    {
        //Create a class Animal that has the field age and the property Age: int.
        //Make a check in set
        //so that when we set years to the Animal
        //class we cannot enter a value greater than 100 and less than 0.
        // Important: The age field must be private

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age > 100 || age < 0)
                {
                    throw new ArgumentException("Value must be between 1 and 99");
                }
                age = value;
            }
        }

    }
}
