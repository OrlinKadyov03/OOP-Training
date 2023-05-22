namespace ExamControlMissedOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a program, that calculates total weight of Car,Truck and Motorcycle
            //Count of all cars,trucks and motorcycles.
            //Input must be on one line,separated by ","
            //Think about of vehicle abstract class
            // Car has - double weight,PassengerCount int
            // Truck has - double weight,CargoWeight double
            // Motorcycle has - double weight,HasSideCar int (0 - no, 1 - yes)
            // 1 is for Car, 2 is for Truck and 3 is for Motorcycle
            //Input
            // 5 - number of vehicles
            // 1,1500,4
            // 2,3500,1000
            // 3,300,0
            // 1,1800,5
            // 2,4000,1200
            //Output
            // Car-TotalWeight - 3300
            // Truck-TotalWeight - 7500
            // Motorcycle-TotalWeight - 300
            // Total cars - 2 
            // Total trucks - 2
            // Total Motorcycles - 1


            double totalCarWeight = 0;
            double totalTruckWeight = 0;
            double totalMotorcycleWeight = 0;
            int carCount = 0;
            int truckCount = 0;
            int motorcycleCount = 0;

            List<Vehicle> vehicles = new List<Vehicle>();

            Console.Write("Enter the number of vehicles: ");
            int numberOfVehicles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfVehicles; i++)
            {
                Console.WriteLine("Enter the type of vehicle (1 - Car, 2 - Truck, 3 - Motorcycle): ");
                string input = Console.ReadLine();

                string[] parts = input.Split(',');
                int vehicleType = Convert.ToInt32(parts[0]);
                double weight = Convert.ToDouble(parts[1]);


                switch (vehicleType)
                {
                    case 1:
                        int passenCount = int.Parse(parts[2]);
                        Car car = new Car(weight,passenCount);
                        vehicles.Add(car);
                        carCount++;
                        totalCarWeight += car.Weight;
                        break;

                    case 2:
                        double cargoWeight = double.Parse(parts[2]);
                        Truck truck = new Truck(weight, cargoWeight);
                        vehicles.Add(truck);
                        truckCount++;
                        totalTruckWeight += truck.Weight;
                        break;

                    case 3:
                        int hasSideCar = int.Parse(parts[2]);
                        Motorcycle motor = new Motorcycle(weight, hasSideCar);
                        vehicles.Add(motor);
                        motorcycleCount++;
                        totalMotorcycleWeight += motor.Weight;
                        break;

                    default:
                        Console.WriteLine("Invalid vehicle type.");
                        break;
                }
            }


            Console.WriteLine();
            Console.WriteLine("Summary:");
            Console.WriteLine($"Total weight of all cars: {totalCarWeight}");
            Console.WriteLine($"Total weight of all trucks: {totalTruckWeight}");
            Console.WriteLine($"Total weight of all motorcycles: {totalMotorcycleWeight}");

            Console.WriteLine($"Count of all cars {carCount}");
            Console.WriteLine($"Count of all trucks {truckCount}");
            Console.WriteLine($"Count of all motorcycles {motorcycleCount}");


            }
    } 
}