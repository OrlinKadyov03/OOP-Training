namespace _5thExerciseW3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Flower class with Water: int and Name:
            //string properties, also creating an appropriate constructor.
            //Then create a Gardener class with a WaterFlower(Flower f) method.
            //The purpose of the method is to increase the Water property of the given flower.
            //The user enters N number of flowers with a name and water,
            //then the gardener goes through and waters all the flowers.


            int n = int.Parse(Console.ReadLine());
            Flower[] flowers = new Flower[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                int water = int.Parse(Console.ReadLine());

                flowers[i] = new Flower(name, water);
            }

            Gardener gardener = new Gardener();

            foreach (Flower flower in flowers)
            {
                gardener.WaterFlower(flower);
            }

            Console.WriteLine("Flower watering complete.");
            Console.WriteLine("Update flower information.");

            foreach (Flower flowerOne in flowers)
            {
                Console.WriteLine($"{flowerOne.Name} {flowerOne.Water}");
            }
        }
    }
}