using Domain.Interfaces;
using Domain.Models;
using Domain;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=================== Dog Store =====================\n");
GenericPetStore<Dog> dogStore = new GenericPetStore<Dog>();
dogStore.Insert(new Dog("Sparky", 2, true, "bones"));
dogStore.Insert(new Dog("Johnny", 4, true, "beef"));
dogStore.PrintPets();
dogStore.BuyPet("Sparky");
Console.WriteLine("Dog store after buying Sparky");
dogStore.PrintPets();
dogStore.BuyPet("dasdsa");
Console.ResetColor();
Console.WriteLine("\n\n");


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("==================== Fish Store ===================\n");
GenericPetStore<Fish> fishStore = new GenericPetStore<Fish>();
fishStore.Insert(new Fish("Fishy", 1, "Silver", "20 cm"));
fishStore.Insert(new Fish("Blacky", 2, "Black", "1.2m"));
fishStore.PrintPets();
Console.ResetColor();
Console.WriteLine("\n\n");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("==================== Cat Store ===================\n");
GenericPetStore<Cat> catStore = new GenericPetStore<Cat>();
catStore.Insert(new Cat("Garfield", 4, true, 7));
catStore.Insert(new Cat("Tom", 6, false, 6));
catStore.PrintPets();
catStore.BuyPet("Tom");
Console.WriteLine("Cat store after buying Tom:\n");
catStore.PrintPets();
Console.ResetColor();
Console.WriteLine("\n\n");


Console.ReadLine();



