namespace _7thExerciseW3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //reate a Window class with the property Thickness: int. Create a Season class with a Name property that has a private set and a public get. Create an appropriate constructor for the Season class that accepts a string with the name of the season (summer, winter, automn, spring). In the Window class, create a method GetTermalInsulation(Season season): double.
            //The logic of the method is as follows:
            //When the season is Winter it returns 10 * thickness / 100
            //When the season is Automn it returns 7 * thickness / 100
            //When the season is Spring it returns 3 * thickness / 100
            //When the season is Summer it returns 1 * thickness / 100

            Season sOne = new Season("winter");
            Season sTwo = new Season("autumn");
            Season sThree = new Season("spring");
            Season sFour = new Season("summer");
            Window wOne = new Window(); wOne.Thickness = 2;
            Window wTwo = new Window(); wTwo.Thickness = 2;
            Window wThree = new Window(); wThree.Thickness = 2;
            Window wFour = new Window(); wFour.Thickness = 2;


            double therm = wOne.GetTermallnsulation(sOne);
            double thermTwo = wTwo.GetTermallnsulation(sTwo);
            double thermThree = wThree.GetTermallnsulation(sThree);
            double thermFour = wFour.GetTermallnsulation(sFour);

            Console.WriteLine(therm);
            Console.WriteLine(thermTwo);
            Console.WriteLine(thermThree);
            Console.WriteLine(thermFour);

        }
    }
}