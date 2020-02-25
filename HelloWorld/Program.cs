using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            var numOfVowels = 0;
            var lastIsVowel = false;

            foreach (var animal in animals)
            {
                foreach (var letter in animal)
                {
                    bool foundVowel = false;
                    foreach (char vowel in vowels)
                    {
                        if (vowel == letter && lastIsVowel)
                        {
                            foundVowel = true;
                            lastIsVowel = true;
                            break;
                        }
                        else if (vowel == letter && !lastIsVowel)
                        {
                            numOfVowels++;
                            foundVowel = true;
                            lastIsVowel = true;
                            break;
                        }
                    }

                    if (!foundVowel)
                        lastIsVowel = false;
                }
                // for each animal check whether it has more than one syllable (vowel check with exceptions)
                var notMonoSyllabic = false;
                
                if (notMonoSyllabic)
                {
                    Console.WriteLine(animal);
                }
            }

            Console.ReadKey();
        }
    }
}
