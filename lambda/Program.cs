using System;
using System.Collections.Generic;

namespace LambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of tuples containing names and ages
            List<(string Name, int Age)> people = new List<(string, int)>()
            {
                ("Matthew", 25),
                ("Ama", 18),
                ("Teneil", 17),
                ("John", 35),
                ("Doe", 29)
            };

            // Display the original list
            Console.WriteLine("Original List:");
            DisplayList(people);

            // Filter people older than 25 using a lambda expression
            List<(string Name, int Age)> filteredList = people.FindAll(person => person.Age > 25);

            // Display the filtered list
            Console.WriteLine("\nPeople older than 25:");
            DisplayList(filteredList);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Helper method to display the list
        static void DisplayList(List<(string Name, int Age)> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine($"{person.Name}: {person.Age}");
            }
        }
    }
}
