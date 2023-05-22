using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace _5thW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a student class with first and last name.
            //Create a University class with the required name and country properties.
            //In the University class, we might have a List<Student>
            //Create a new university and add some students to it.
            //Then display the information for all students on the console.

            University uniPU = new University() {Name = "PU",Country = "Bulgaria" };
            Student stu = new Student() {FirstName = "Orlin",LastName = "Kadiov" };
            Student stuTwo = new Student() { FirstName = "Ivo", LastName = "Pavlov" };
            Student stuThree = new Student() { FirstName = "Tosho", LastName = "Jelev" };
            uniPU.Students.Add(stu);
            uniPU.Students.Add(stuTwo);
            uniPU.Students.Add(stuThree);

            foreach (var stud in uniPU.Students)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName}");
            }
          
            
            
        }
    }
}