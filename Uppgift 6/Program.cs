using System;
using System.Collections.Generic;
namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Anna", "John", "Alice", "Bob" };
            Console.WriteLine("Original list: ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.Sort(); // Sort the names alphabetically
            Console.WriteLine("\nSorted list: ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nEnter name to search: ");
            string searchName = Console.ReadLine().ToUpper();
            while (!names.Exists(name => name.ToUpper() == searchName))
            {
                Console.WriteLine($"{searchName} is not in the list. Try again!");
                Console.Write("\nEnter name to search: ");
                searchName = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"{searchName} is in the list.");
            Console.ReadKey();
        }
    }
}
