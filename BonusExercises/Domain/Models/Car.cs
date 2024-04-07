namespace Domain.Models
{
    public class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving!");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and i drive on 4 wheels :)");
        }
        
    }
}
