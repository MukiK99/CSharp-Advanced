namespace Domain.Models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and i have a couple of wheels :)");
        }
        public void Fly()
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}
