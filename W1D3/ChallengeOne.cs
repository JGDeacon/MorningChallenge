using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace W1D3
{
    [TestClass]
    public class ChallengeOne
    {
        string magicWord = "Supercalifragilisticexpialidocious";
        [TestMethod]
        public void PrintEveryLetter()
        {

            //Vertical list of letters in magicWord
            foreach (char letter in magicWord)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("or");
            //Horizontal list of letters in magicWord
            foreach (char letter in magicWord)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
            Console.WriteLine("Not sure which way the charecters were to go horizontally of vertically");
            Console.WriteLine();
        }
        [TestMethod]
        public void OnlyIs()
        {
            //I = not an I
            foreach (char letter in magicWord)
            {
                if (letter != 'i')
                {
                    Console.WriteLine("Not an i");
                }
                else
                {
                    Console.WriteLine(letter);
                }

            }
        }
        [TestMethod]
        public void BonusOne()
        {
            foreach (char letter in magicWord)
            {
                Console.WriteLine(letter);
            }

            //Lets count the letters in magicWord
            Console.WriteLine();
            Console.WriteLine("Bonus 1 Time!");
            Console.WriteLine($"Supercalifragilisticexpialidocious or what we in code named the magicWord is {magicWord.Length} charecters long");

            //we could also do it this way
            int letterCount = 0;
            foreach (char letter in magicWord)
            {
                letterCount++;
            }
            Console.WriteLine();
            Console.WriteLine("Using a foreach loop to count the letters we got a total of: " + letterCount);

            //One more way
            List<string> letterList = new List<string>();
            for (int i = 0; i < magicWord.Length; i++)
            {
                letterList.Add(magicWord[i].ToString());
            }
            Console.WriteLine("Creating a List and adding each letter as an index " + letterList.Count);
            Console.WriteLine();
        }
        [TestMethod]
        public void BonusTwo()
        {
            //count the lowercase l's
            int countLs = 0;
            Console.WriteLine("Bonus 2 Time");
            foreach (char letter in magicWord)
            {
                switch (letter)
                {
                    case 'i':
                        Console.WriteLine("i");
                        break;
                    case 'l':
                        Console.WriteLine("L");
                        countLs++;
                        break;
                    default:
                        Console.WriteLine("Not an i");
                        break;
                }
            }
            Console.WriteLine($"Only {countLs} lower case l's in {magicWord}.");
        }
    }
}
