namespace _2ndExerciseW4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a User class with Id and Name properties.
            //Make a list of users and add multiple users to the list.
            //The user enters an Id and if such an Id exists displays the user's name.

            List<User> users = new List<User>();
            User user = new User(12,"Petko") ;
            User userTwo = new User(2,"Dragan");

            users.Add(user);
            users.Add(userTwo);

            int inputId = int.Parse(Console.ReadLine());
            foreach (User use in users)
            {
                if (inputId == use.Id)
                {
                    Console.WriteLine(use.Name);
                }
            }
        }
    }
}