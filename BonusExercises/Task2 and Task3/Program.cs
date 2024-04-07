using Domain.Models;

Console.WriteLine("================ Task 2 ====================\n");
Car car = new Car(); // Vo README-to se instancirani objekti od klasata Vehicle, no taka nema da mozham posle da gi pristapam metodite koi se napishani vo samite klasi koi nasleduvaat od Vehicle!
MotorBike motorBike = new MotorBike();
Boat boat = new Boat();
Airplane plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

Console.WriteLine("\n================ Task 3 ====================\n");
car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();




Console.ReadLine(); 