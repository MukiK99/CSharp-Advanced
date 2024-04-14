﻿using Cars.Domain.Entities;

namespace Cars.Domain.Helpers
{
    public static class ListHelper
    {
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine("Printing List...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n");
        }

        public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
        {

            Console.WriteLine($"Printing {list[0].GetType().Name}s...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n");
        }
    }
}
