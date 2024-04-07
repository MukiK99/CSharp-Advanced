using Domain.Models;
Console.WriteLine("================ Single Value ==================\n");
int firstNumber = 10;
string sentence = "Hello my friend";
bool isSunny = true;
PrintInConsole<int> printInt = new PrintInConsole<int>();
printInt.Print(firstNumber);
PrintInConsole<string> printString = new PrintInConsole<string>();
printString.Print(sentence);
PrintInConsole<bool> printBoolean = new PrintInConsole<bool>();
printBoolean.Print(isSunny);

Console.WriteLine("\n==================== List ========================\n");
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<string> strings = new List<string>() { "A", "B", "C", "D", "E" };
List<bool> booleans = new List<bool>() { true, false, false, true };
printInt.PrintCollection(numbers);
printString.PrintCollection(strings);
printBoolean.PrintCollection(booleans);


















Console.ReadLine();