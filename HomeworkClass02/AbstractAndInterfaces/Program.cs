using Domain.Models;

Console.WriteLine("============== Teacher John =================\n");
Teacher John = new Teacher(1, "John", "johnDoe123", new List<string> { "Math", "Art", "Chemistry" });
John.PrintUser();
John.PrintSubjects();
Console.WriteLine("\n\n");

Console.WriteLine("========== Teacher Anna ===================\n");
Teacher Anna = new Teacher(2, "Anna", "Anna456", new List<string> { "Science", "Geography", "Historty" });
Anna.PrintUser();
Anna.PrintSubjects();
Console.WriteLine("\n\n");


Console.WriteLine("============ Student Ricky =====================\n");
Student Ricky = new Student(23, "Ricky", "Rickson098", new List<int> { 4, 3, 5, 2, 3 });
Ricky.PrintUser();
Ricky.PrintGrades();
Console.WriteLine("\n\n");


Console.WriteLine("=========== Student Sarah =================\n");
Student Sarah = new Student(45, "Sarah", "Sarah333", new List<int> { 5, 5, 4, 5, 4 });
Sarah.PrintUser();
Sarah.PrintGrades();

Console.ReadLine();

