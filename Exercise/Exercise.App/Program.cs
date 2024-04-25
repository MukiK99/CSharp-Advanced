
using Exercise.App;
using Exercise.Domain.Models;

Db<Dog> dogDb = new Db<Dog>();
void Seed(Db<Dog> dogs)
{
    if (dogs.GetAll().Count == 0)
    {
        dogs.Insert(new Dog("Jacky", 2, "Gray"));
        dogs.Insert(new Dog("Johnny", 2, "Black"));
        dogs.Insert(new Dog("Bella", 2, "White"));
    }

}
Seed(dogDb);
Console.WriteLine("Enter dog Name");
string name = Console.ReadLine();
Console.WriteLine("Enter dog age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter dog color");
string color = Console.ReadLine();
Dog newDog = new Dog(name, age, color);
dogDb.Insert(newDog);
List<Dog> dogs = dogDb.GetAll();
Console.WriteLine("========== DOGS ==========");
if (dogs != null)
{
    foreach (Dog dog in dogs)
    {
        Console.WriteLine(dog.Info());
    }
}
else
{
    Console.WriteLine("No dogs found.");
}

Console.ReadLine();