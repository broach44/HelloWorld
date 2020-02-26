using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Cat", "Dog", "Mouse" };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            var numOfVowels = 0;
            var lastIsLetterE = false;

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
