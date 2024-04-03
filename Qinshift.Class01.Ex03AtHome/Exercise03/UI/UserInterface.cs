using Domain.Enums;
using Domain.Models;
using Services;

namespace Exercise03.UI
{
    public class UserInterface
    {
        private ApplicationServices _applicationServices;
        private ComputerServices _computerServices;
        private UserServices _userServices;
        private Stats _stats;

        public UserInterface()
        {
            _applicationServices = new ApplicationServices();
            _computerServices = new ComputerServices();
            _userServices = new UserServices();
            _stats = new Stats();
        }

        public void InitApp()
        {
            try
            {
                Console.WriteLine("WELCOME TO THE APLLICATION ROCK-PAPER-SCISSORS\n\n");

                Console.WriteLine("Please enter your firstname!");
                string userFirstName = Console.ReadLine();
                Console.WriteLine("Please enter your lastname!");
                string userLastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userFirstName) || string.IsNullOrWhiteSpace(userLastName))
                {
                    Console.WriteLine("Please enter valid inputs!");
                    Thread.Sleep(1000);
                    return;

                }
                User loggedUser = new User(userFirstName, userLastName, 0,0);
                Computer lenovo = new Computer("Lenovo IdeaPad 320", 0);
                Console.WriteLine($"Welcome {loggedUser.Firstname} {loggedUser.LastName}");
                Thread.Sleep(1000);

                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("\n Please choose a game option:\n 1.Play\n 2.Stats\n 3.Exit");

                    string chosenOption = Console.ReadLine();

                    switch (chosenOption)
                    {
                        case "1":
                            Console.WriteLine("Play");
                            PlayInfo(loggedUser, lenovo);

                            break;
                        case "2":
                            Console.WriteLine("Stats");
                            StatsInfo(loggedUser, lenovo);

                            break;
                        case "3":
                            EndMenu();

                            return;
                        default:
                            Console.WriteLine("Please choose one of the available options!");
                            break;
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception:{ex.Message}");
            }
        }
        public void EndMenu()
        {
            Console.Clear();
            WriteInColor("Thank you for using Rock - Paper - Scissors App!", ConsoleColor.DarkCyan);
            WriteInColor("\nBye bye and have a wonderful day :)", ConsoleColor.Cyan);
            Console.ReadLine();
        }
        public void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public void StatsInfo(User user, Computer computer)
        {
            _stats.UserPercentages(user, computer);
            Console.ReadLine();
        }
        public void PlayInfo(User user, Computer computer)
        {
            _applicationServices.DetermineWinner(user, computer);
            Console.ReadLine();

        }
    }
}
