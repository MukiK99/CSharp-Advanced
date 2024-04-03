using Domain.Models;

namespace Services
{
    public class Stats
    {

        public void UserPercentages(User user, Computer computer)
        {
            if (user.AmountOfGames == 0)
            {
                Console.WriteLine($"User {user.Firstname} {user.LastName} has not played any games yet.");
                return;
            }
            else
            {
                Console.WriteLine($"User {user.Firstname} {user.LastName} has {user.UserWins} wins");
                Console.WriteLine($"Computer {computer.Name} has {computer.ComputerWins} wins");
                double userWinPercentage = ((double)user.UserWins / user.AmountOfGames) * 100;
                double userLossPercentage = ((double)user.UserLoss / user.AmountOfGames) * 100;
                Console.WriteLine($"\nThe number of games played is:{user.AmountOfGames}\n");
                Console.WriteLine($"The number of tie games is:{user.AmountOfGames - (user.UserWins + user.UserLoss)}\n");
                Console.WriteLine($"User {user.Firstname} {user.LastName} has win percentage of {userWinPercentage}%\n");
                Console.WriteLine($"User {user.Firstname} {user.LastName} has loss percentage of {userLossPercentage}%");
            }
            
        }
    }
}
