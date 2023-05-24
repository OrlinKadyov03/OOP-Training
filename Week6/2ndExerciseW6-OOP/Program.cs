namespace _2ndExerciseW6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //In the Persian class, the Move method prints: “Persian cat is moving”
            // In the Persian class, the Jump method prints: “Persian cat jumping”
            //In the Sphynx class, the Move method prints: “Sphynx cat is moving”
            //In the Sphynx class, the MewMew method prints: “Mew Mew”


            Persian persian = new Persian("Roki", 2);
            Sphynx sphynx = new Sphynx("Djoni", 1);

            persian.Move();
            persian.Jump();

            sphynx.Move();
            sphynx.MewMew();
        }
    }
}