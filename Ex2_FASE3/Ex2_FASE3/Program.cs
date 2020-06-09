using System;
using System.Collections.Generic;

namespace Ex2_FASE3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> name = new List<char>();
            Dictionary<string, int> letterCount = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            name.Add('O');
            name.Add('r');
            name.Add('i');
            name.Add('o');
            name.Add('l');

            foreach (char letter in name)
            {
                try
                {
                    letterCount.Add(letter.ToString(), 1);
                }
                catch (ArgumentException)
                {
                    letterCount[letter.ToString()]++;
                }
            }
            foreach (KeyValuePair<string, int> letter in letterCount)
            {
                Console.WriteLine("In this name, the letter {0} appears {1} time(s).", letter.Key.ToLower(), letter.Value);
            }
        }
    }
}
