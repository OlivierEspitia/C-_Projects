using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a history with white spaces, 
            and the player needs complete this spaces.
            Author: Allan Olivier Espitia Machain
            */


            // Let the user know that the program is starting:
            Console.WriteLine("The programm is starting...");

            // Give the Mad Lib a title:
            string title = "Good day!";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a adjetive: ");
            string adjetive1 = Console.ReadLine();
            Console.Write("Enter a second adjetive: ");
            string adjetive2 = Console.ReadLine();
            Console.Write("Enter a Third adjetive: ");
            string adjetive3 = Console.ReadLine();
            Console.Write("Enter a Verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun = Console.ReadLine();
            Console.Write("Enter a second noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a food: ");
            string food = Console.ReadLine();
            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero: ");
            string superHero = Console.ReadLine();
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();
            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjetive1}. 'It is going to be a {adjetive2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun}, which made all the {fruit}s very {adjetive3}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
