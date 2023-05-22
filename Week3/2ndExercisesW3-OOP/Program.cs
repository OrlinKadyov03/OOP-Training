namespace _2ndExercisesW3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Bench class with the property
            //IsBroken: bool. Create a Park class
            //in which we have a List<Bench> list of benches.
            //Create a Worker class that has the
            //FixBenchesInPark(Park park) method.
            //This method fixes any Bench objects
            //that are in the Park and are broken.
            //Make a park with several benches,
            //some of which must be broken.
            //Then create a new Worker and call
            //the FixBenchesInPark method.
            //After calling this method,
            //there should be no broken benches in the park.

            Worker worker = new Worker();
            Park park = new Park();
            Bench benchOne = new Bench() { isBroken = true };
            Bench benchTwo = new Bench() ;
            Bench benchThree = new Bench() { isBroken = true };
            Bench benchFour = new Bench() { isBroken = true };
            Bench benchFive = new Bench() ;

            park.benches.Add(benchOne);
            park.benches.Add(benchTwo);
            park.benches.Add(benchThree);
            park.benches.Add(benchFour);
            park.benches.Add(benchFive);

            worker.FixBenchesInPark(park);

            var areBenchesFixed = park.benches.All(bn => !bn.isBroken);
            Console.WriteLine($"All benches fixed are: {areBenchesFixed}");


        }
    }
}