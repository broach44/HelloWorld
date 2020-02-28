using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"Type in the dialect you understand best from the following options:  {args[0]}, {args[1]}, {args[2]}");
            var userSelectedDialect = Console.ReadLine();

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            switch (userSelectedDialect.ToLower())
            {
                case "southern":
                    Console.WriteLine($"Howdy {userName}!!");
                    break;

                case "spanish":
                    Console.WriteLine($"Hola {userName}!");
                    break;

                case "english":
                    Console.WriteLine($"Hello {userName}!");
                    break;

                default:
                    Console.WriteLine($"Looks like you didn't select one of the options. No greeting for you {userName}!");
                    break;
            }

            Console.WriteLine("What is your favorite color?");
            var usersFavoriteColor = Console.ReadLine();

            

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Cat", "Dog", "Mouse" };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            var numOfVowels = 0;
            var lastIsLetterE = false;

            Random numberGenerator = new Random();
            var randomNumber = numberGenerator.Next(0, (animals.Length - 1));

            Console.WriteLine($"Would you like to have a {usersFavoriteColor} {animals[randomNumber]}?");

            foreach (var animal in animals)
            {
                var animalLength = animal.Length;
                var lastLetter = animal[animalLength - 1];
                foreach (var letter in animal)
                {
                    foreach (char vowel in vowels)
                    {
                        if (vowel == letter)
                        {
                            numOfVowels++;
                            break;
                        }
                        if (lastLetter == 'e')
                        {
                            lastIsLetterE = true;
                        }

                    }

                }
                
                if (numOfVowels >= 2 && !lastIsLetterE) 
                {
                    Console.WriteLine(animal);
                }

                numOfVowels = 0;
                
            }

            Console.ReadKey();
        }
    }
}
