using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.WriteLine("Please type a greeting: Southern, Alien, Robot");

            var input = Console.ReadLine();

            string sentence;
            do
            {
                Console.WriteLine("Type your name. Press enter when done.");
                sentence = Console.ReadLine();
                Console.WriteLine($"Hey {sentence}");

            } while (sentence == "quit");


            if (input == "Alien")
            {
                Console.WriteLine("EE IA LAAM UIR WQLKDHJ");
            }
            else if (input == "Robot")
            {
                Console.WriteLine("Beep boop");
            }
            else
            {
                Console.WriteLine("Well howdy there young lad!");
            }

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("What is your favorite color?");

            var favColor = Console.ReadLine();

            Random rand = new Random();
            // Generate a random index less than the size of the array.  
            int index = rand.Next(animals.Length);
            // Display the result.  
            Console.WriteLine($"Would you like a {favColor} {animals[index]}");


            var letterLoop = Console.ReadLine();

            foreach(var letter in letterLoop)
            {
                for (int i = 0; i < letterLoop.Length; i++)
                {
                   
                }
            }

        }
    }
}
