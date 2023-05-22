namespace _10thExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of strings.
            //Then convert all the words in the list
            //to upper case and skip the first 2 words.
            //Display the result on the console.
            //Login:
            //List<string> strs = new List<string>() {“this”,”is”,”sample”,”linq”,”skip”,”take”};
            //Output:
            //SAMPLE, LINQ, SKIP, TAKE

            List<string> list = new List<string>() {"this ","is ","sample ","linq ","skip ","take "};

            var skiplist = list.Skip(2).Select(x => x.ToUpper());

            foreach (var item in skiplist)
            {
                Console.Write(item);
            }


        }
    }
}