namespace _6thExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Employee class with the
            //Salary and Name properties.
            //Create a list from Employee.
            //The program displays a list of employees sorted by salary,
            //average salary, highest salary,
            //and lowest salary along with the employee's name.

            List<Employee> employees = new List<Employee>();

            Employee e = new Employee() {Salary = 10000, Name = "Pesho" };
            Employee eTwo = new Employee() { Salary = 9900, Name = "Ivan" };
            Employee eThree = new Employee() { Salary = 8549, Name = "Vesko" };
            Employee eFour = new Employee() { Salary = 11202, Name = "Shaio" };

            employees.Add(e);
            employees.Add(eTwo);
            employees.Add(eThree);
            employees.Add(eFour);

            var orderByDescSalary = from emp in employees orderby  emp.Salary descending select emp;


            var averageSalary = employees.Select(s => s.Salary).Average();

            var maxSalary = employees.Select(s => s.Salary).Max();

            var lowestSalary = employees.Select(s => s.Salary).Min();


            Console.Write("Min Salary: ");
            Console.WriteLine(string.Join("",lowestSalary," - ",e.Name));
            Console.Write("Max Salary: ");
            Console.WriteLine(string.Join("",maxSalary));
            Console.Write("Average Salary: ");
            Console.WriteLine(string.Join("",averageSalary));
            Console.WriteLine("Order By Descending ");
            foreach (var em in orderByDescSalary)
            {
                Console.WriteLine($"{em.Name} {em.Salary}");
            }
        }
    }
}