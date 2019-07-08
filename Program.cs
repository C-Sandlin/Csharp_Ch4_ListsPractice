using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            // Planets Exercises
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            Console.WriteLine($"Original List:");
            planetList.ForEach(planet => Console.WriteLine($"{planet}"));

            var newPlanets = new List<string>() { "Jupiter", "Saturn" };
            planetList.AddRange(newPlanets);
            Console.WriteLine($"Adding Jup and Sat:");
            planetList.ForEach(planet => Console.WriteLine($"{planet}"));

            var last2Planets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(last2Planets);
            Console.WriteLine($"Adding last two planets:");
            planetList.ForEach(planet => Console.WriteLine($"{planet}"));

            var VandE = new List<string>() { "Venus", "Earth" };
            planetList.InsertRange(1, VandE);
            Console.WriteLine($"Adding Venus and Earth:");
            planetList.ForEach(planet => Console.WriteLine($"{planet}"));

            planetList.Add("Pluto");
            Console.WriteLine($"Adding Pluto:");
            planetList.ForEach(planet => Console.WriteLine($"{planet}"));

            var rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine($"The rocky planets are:");
            rockyPlanets.ForEach(rockyPlanet => Console.WriteLine($"{rockyPlanet}"));

            planetList.Remove("Pluto");
            Console.WriteLine($"Deleting Pluto:");
            planetList.ForEach(planet => Console.WriteLine($"{planet}"));

            // Random Numbers Exercises

            Random random = new Random();
            var numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6)
            };

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Find(number => number == numbers[i]))
                {
                    Console.Write($"Numbers list contains {numbers[i]}");
                }
                else
                {
                    Console.Write($"Numbers list does not contain {numbers[i]}");
                }
            }

        }
    }
}
