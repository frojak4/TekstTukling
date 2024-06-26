﻿using System.Text;

namespace TekstTukling
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            string userInput = "";
            while (userInput is not "1" and not "2") {
                Console.WriteLine("Velkommen til TekstTukling!");
                Console.WriteLine("Kva vil du gjere?");
                Console.WriteLine("1. Roter tekst");
                Console.WriteLine("2. Skift ord");

                userInput = Console.ReadLine();
            }

            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("Korleis tekst vil du rotere?");
                string userInput2 = Console.ReadLine();
                Console.WriteLine($"{rotateText(userInput2)} er teksten ditt rotert!");
            } else if (userInput == "2")
            {
                Console.Clear();
                changeWord();
            }
        }

        static string rotateText(string tekst)
        {
            
            string rotatedWord = "";
            
            for (int i = tekst.Length; i > 0; i--)
            {
                rotatedWord += tekst[i - 1];
                
            }

            
            return rotatedWord;
        }

        static void changeWord()
        {
            Console.WriteLine("Korleis tekst vil du skifte?");
            string userInput = Console.ReadLine();
            
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'e')
                {
                    StringBuilder sb = new StringBuilder(userInput);
                    sb[i] = 'a';
                    userInput = sb.ToString();
                }
            }

            Console.WriteLine($"{userInput} er din nye tekst");
        }
    }
}
