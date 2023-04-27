namespace _4thW2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Company class which requires
            //that in order to create an object of
            //this class we must have a company name and a country.
            //Make an appropriate constructor of
            //the Company class to achieve this,
            //then create a new object of the Company
            //class and display it on the console.

            Company company = new Company("asdf","Bulgaria") {};
            Console.WriteLine(company.Name);
            Console.WriteLine(company.Country);
        }
    }
}