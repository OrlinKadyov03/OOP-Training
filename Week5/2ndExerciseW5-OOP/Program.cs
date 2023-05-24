using System.Threading.Tasks;

namespace _2ndExerciseW5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Employee class with properties
            //Name: string, Age: int, virtual Salary: decimal.
            // Create a Secretary class with a list of String Messages.
            // The salary of the secretary is fixed at 1000.
            // Create a Manager class with a list of string tasks.
            // The manager's salary is calculated according
            // to the following formula: 2000 + (20 * Number of tasks).
            //Create appropriate constructors for the classes.
            //Employee is the main class and the others inherit from it.


            Console.WriteLine("Enter number of secretary");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Secretary Name");
                string secrataryName = Console.ReadLine();

                Console.WriteLine("Enter Secretary Age");
                int secrataryAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Secretary Salary");
                decimal secratarySalary = decimal.Parse(Console.ReadLine());

                Secretary secretary = new Secretary(secrataryName, secrataryAge)
                { };
                secretary.messages.Add("Message One");
                secretary.messages.Add("Message Two");
              
                Console.WriteLine($" Secretary Name - {secretary.Name}");
                Console.WriteLine($" Secretary Age - {secretary.Salary}");
                Console.WriteLine($"Messages----");


                foreach (string mess in secretary.messages)
                {
                    Console.WriteLine($"{mess}");
                }          
            }
   
            Console.WriteLine("Enter Number of Managers");
            int nTwo = int.Parse(Console.ReadLine());

            for (int i = 0; i < nTwo; i++)
            {
                Console.WriteLine("Enter Manager Name");
                string managerName = Console.ReadLine();

                Console.WriteLine("Enter Manager Age");
                int managerAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Manager Salary");
                decimal managerSalary = decimal.Parse(Console.ReadLine());
                Manager manager = new Manager(managerName, managerAge)
                { };

                manager.Tasks.Add("Task One");
                manager.Tasks.Add("Task Two");

                Console.WriteLine($" Manager Name - {manager.Name}");
                Console.WriteLine($" Manager Age - {manager.Age}");
                Console.WriteLine("Messages----");

                foreach (string tasks in manager.Tasks)
                {
                    Console.WriteLine($"{tasks}");
                }

            }


        }
    }
}