using System;
using System.Collections.Generic;

namespace Ex2_FASE2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> name = new List<char>();

            name.Add('O');
            name.Add('r');
            name.Add('i');
            name.Add('o');
            name.Add('l');

            bool isVowel;

            foreach (char letter in name)
            {
                isVowel = "aeiouAEIOU".IndexOf(letter) >= 0;
                if (Char.IsNumber(letter))
                {
                    Console.WriteLine("Person names don't have numbers!");
                }
                else if (isVowel)
                {
                    Console.WriteLine($"{letter} VOWEL");
                }
                else if (Char.IsLetter(letter))
                {
                    Console.WriteLine($"{letter} CONSONANT");
                }
            }
        }
    }
}
