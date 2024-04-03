using Domain.Enums;
using Domain.Models;

namespace Services
{
    public class ApplicationServices
    {
        private UserServices _userServices;
        private ComputerServices _computerServices;
        private User _user;
        private Computer _computer;
        

        public ApplicationServices()
        {
            _userServices = new UserServices();
            _computerServices = new ComputerServices();
            _user = new User();
            _computer = new Computer();
        }
        public void DetermineWinner(User user, Computer computer)
        {
            user.AmountOfGames++;
            Options userChoice = _userServices.UserChosenPlayOption(user);
            Options? computerChoice = _computerServices.ComputerChosenPlayOption(computer);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == Options.Rock && computerChoice == Options.Scissors) ||
                     (userChoice == Options.Paper && computerChoice == Options.Rock) ||
                     (userChoice == Options.Scissors && computerChoice == Options.Paper))
            {
                Console.WriteLine($"User {user.Firstname} {user.LastName} is the winner!");
                user.IncrementUserWins();
               
            }
            else
            {
                Console.WriteLine($"Computer {computer.Name} is the winner");
                computer.IncrementComputerWins();
                user.IncrementUserLoss();
              

            }
        }



    }
}


