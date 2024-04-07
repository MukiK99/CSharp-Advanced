using Domain.Interfaces;

namespace Domain.Models;

public class PrintInConsole<T> : IPrintInConsole<T>
{
    public  void Print(T item)
    {
        Console.WriteLine(item);
    }

    public void PrintCollection(List<T> items)
    {
        foreach(T item in items)
        {
            Console.WriteLine($"{item}");
        }
        Console.WriteLine();

    }
}
