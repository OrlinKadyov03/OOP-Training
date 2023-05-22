namespace _9thExerciseW3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car carTwo = new Car();


            car.Price = 12;
            carTwo.Price = 12;

            List<Car> list = new List<Car>();

            Autopark autopark = new Autopark();
            autopark.cars.Add(car);
            autopark.cars.Add(carTwo);
            
            double carSum = autopark.TotalSum();
            Console.WriteLine("TotalPrice: " + carSum);
        }
    }
}