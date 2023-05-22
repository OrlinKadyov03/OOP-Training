namespace _6thExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a phone book (dictionary).
            //The user enters a name and phone number.
            //Use the ContainsKey method to check if the name "Pesho" is in the phone book.
            //If there is, show his phone number.

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("Enter name,or (to end 'e')");
                string input = Console.ReadLine();
                if (input == "e")
                {
                    break;
                }
                Console.WriteLine("Enter phone number");
                string phone = Console.ReadLine();
                phoneBook.Add(input, phone);
            }
            if (phoneBook.ContainsKey("Pesho"))
            {
                string phone = phoneBook["Pesho"];
                Console.WriteLine("Pesho's phone number is {0}", phone);
            }
            else
            {
                Console.WriteLine("There is no Pesho ");
            }
      
        }
    }
}