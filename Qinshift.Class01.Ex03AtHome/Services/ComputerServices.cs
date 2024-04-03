using Domain.Enums;
using Domain.Models;

namespace Services
{
    public class ComputerServices
    {
        public Options? ComputerChosenPlayOption(Computer computer)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine($"User {computer.Name} choose {Options.Rock}");
                    return Options.Rock;
                case 2:
                    Console.WriteLine($"User {computer.Name} choose {Options.Paper}");
                    return Options.Paper;
                case 3:
                    Console.WriteLine($"User {computer.Name} choose {Options.Scissors}");
                    return Options.Scissors;
                default:
                    Console.WriteLine("Invalid option");
                    return null;
            }
        }
    }
}
