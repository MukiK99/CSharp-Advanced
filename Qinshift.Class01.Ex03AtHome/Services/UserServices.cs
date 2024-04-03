using Domain.Enums;
using Domain.Models;

namespace Services
{
    public class UserServices
    {
        public Options UserChosenPlayOption(User user)
        {
            while(true)
            {


                Console.WriteLine("Please choose one of the three options:\n 1.Rock\n 2.Paper\n 3.Scissors");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine($"User {user.Firstname} {user.LastName} choose {Options.Rock}");
                        return Options.Rock;
                    case "2":
                        Console.WriteLine($"User {user.Firstname} {user.LastName} choose {Options.Paper}");
                        return Options.Paper;
                    case "3":
                        Console.WriteLine($"User {user.Firstname} {user.LastName} choose {Options.Scissors}");
                        return Options.Scissors;
                    default:
                        Console.WriteLine("You choose invalid option");
                        break;


                }
            }
        }
    }
}
