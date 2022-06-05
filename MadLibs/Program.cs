using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program does Mad Libs which is a game that with short stories and the player has to fill in the blanks
            Example:
            Roses are _______ (adjective) ____(noun) are blue ____ (noun) is _____ (adjective) And so are you!
            Author: Mohamed
            */


            // Let the user know that the program is starting:
            // Q2
            Console.WriteLine("Mad Libs game has started!");

            // Give the Mad Lib a title:
            // Q3
            string title = "A short, mad story";

            Console.WriteLine(title);
            // Define user input and variables:
            // Q5
            Console.Write("Enter a Name: ");
            string name = Console.ReadLine();

            // Q6
            Console.Write("Enter the first adjective: ");
            string adj1 = Console.ReadLine();
            Console.Write("Enter the second adjective: ");
            string adj2 = Console.ReadLine();
            Console.Write("Enter the third adjective: ");
            string adj3 = Console.ReadLine();

            // Q8
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            // Q9
            Console.Write("Enter the first noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter the second noun: ");
            string noun2 = Console.ReadLine();

            // Q10
            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a type food: ");
            string food = Console.ReadLine();
            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();
            // The template for the story:
            // Q11-Q12 insert the vars into story using $""
            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            // Q13
            Console.WriteLine(story);

        }
    }
}

/*
Enter a Name: Rob
Enter the first adjective: blue
Enter the second adjective: silly
Enter the third adjective: soft
Enter a verb: sit
Enter the first noun: cabin
Enter the second noun: toaster
Enter an animal: tiger
Enter a type food: pizza
Enter a fruit: orange
Enter a superhero: ironman
Enter a country: sweden
Enter a dessert: strawberry cheese cake
Enter a year: 2050
*/