using Domain.Models;
using Exercise03.UI;
using Services;

UserInterface userInterface = new UserInterface();
userInterface.InitApp();

//Console.WriteLine("WELCOME TO THE APLLICATION ROCK-PAPER-SCISSORS\n\n");

//Console.WriteLine("Please enter your firstname!");
//string userFirstName = Console.ReadLine();
//Console.WriteLine("Please enter your lastname!");
//string userLastName = Console.ReadLine();
//if (string.IsNullOrWhiteSpace(userFirstName) || string.IsNullOrWhiteSpace(userLastName))
//{
//    Console.WriteLine("Please enter valid inputs!");
//    Thread.Sleep(1000);
//    return;

//}
//User loggedUser = new User(userFirstName, userLastName, 0);
//Computer lenovo = new Computer("Lenovo IdeaPad 320", 0);
//Console.WriteLine($"Welcome {loggedUser.Firstname} {loggedUser.LastName}");
//Thread.Sleep(1000);
//while (true)
//{
//    Console.Clear();

//    Console.WriteLine("\n Please choose a game option:\n 1.Play\n 2.Stats\n 3.Exit");

//    string chosenOption = Console.ReadLine();
   
//    switch (chosenOption)
//    {
//        case "1":
//            ApplicationServices applicationServices = new ApplicationServices();
//            applicationServices.DetermineWinner(loggedUser, lenovo);
//            break;
//        case "2":
            
//            Stats stats = new Stats();
//            stats.WinStats(loggedUser, lenovo);
//            stats.UserPercentages(loggedUser, lenovo);
//            break;
//        case "3":
//            return;
//        default:
//            Console.WriteLine("Please choose one of the available options!");
//            break;
//    }

//    Console.ReadLine();
//}

