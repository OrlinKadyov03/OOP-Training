namespace _2ndExercise
{
    internal class Program
    {  //Define a list of strings.
       //Add the names “Gosho”, “Pesho”, “Tosho”, “Gosho”.
       //Then display all the names.
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Gosho,");
            list.Add("Pesho,");
            list.Add("Tosho,");
            list.Add("Gosho");
            foreach (var item in list)
            {
                Console.Write(item);
            }

        }
    }
}