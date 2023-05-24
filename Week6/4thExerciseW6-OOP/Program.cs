using System.Diagnostics;

namespace _4thExerciseW6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The user enters the number N - the number of buildings entered in the first row,
            //then enters N number of buildings as follows.
            //1 refers to a house, 2 refers to an apartment, 3 refers to an office.
            //Example:
            //house: 1,120,2,100 type, square footage, number of inhabitants, square footage of the yard
            //apartment: 2,70,1,10 type, square footage, number of inhabitants, square footage terrace
            //office: 3,50,Company,3 type,square,company name,number of employees
            //Finally, the program outputs information about the objects,
            //such as the square footage of the house
            //is formed by the square footage of the building
            //+the yard, for the apartment the square footage of the building + the terrace.

            Console.WriteLine("Enter the number of buildings: ");
            int n = int.Parse(Console.ReadLine());

            List<House> houseSquareFootages = new List<House>();
            List<Apartment> apartmentSquareFootages = new List<Apartment>();
            List<Office> officeSquareFootages = new List<Office>();
            Console.WriteLine("- 1 for House - 2 for Apartment - 3 for Office");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Type,SquareFootage,NumberofInhabitants/For Office - Name,SquareFootage");
                string input = Console.ReadLine();
                string[] line = input.Split(',');

                int type = int.Parse(line[0]);
                if (type == 1)
                {
                    House house = new House()
                    {
                        Type = int.Parse(line[0]),
                        SquareFootage = double.Parse(line[1]),
                        NumberOfInhabitants = int.Parse(line[2]),
                        SquareFootageOfTheYard = double.Parse(line[3])
                    };

                    houseSquareFootages.Add(house);
                }
                if (type == 2)
                {
                    Apartment apartment = new Apartment()
                    {
                        Type = int.Parse(line[0]),
                        SquareFootage = double.Parse(line[1]),
                        NumberOfInhabitants = int.Parse(line[2]),
                        TerraceArea = double.Parse(line[3])
                    };
                    apartmentSquareFootages.Add(apartment);
                }
                if (type == 3)
                {
                    Office office = new Office()
                    {
                        Type = int.Parse(line[0]),
                        SquareFootage = double.Parse(line[1]),
                        CompanyName = line[2],
                        EmployeeCount = int.Parse(line[3]),
                    };
                    officeSquareFootages.Add(office);
                }
            }
            foreach (House item in houseSquareFootages)
            {
                Console.WriteLine("House Quadrature - {0}",item.Quadrature());
            }
            foreach (Apartment apartment1 in apartmentSquareFootages)
            {
                Console.WriteLine("Apartment Quadrature - {0}", apartment1.Quadrature());
            }
            foreach (Office office1 in officeSquareFootages)
            {
                Console.WriteLine("Office Quadrature - {0}",office1.Quadrature());
            }


            Console.WriteLine("Total Houses: {0}",houseSquareFootages.Count);
            Console.WriteLine("Total Apartments: {0}",apartmentSquareFootages.Count);
            Console.WriteLine("Total Offices: {0}",officeSquareFootages.Count);
        }
    }
}