using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2_FASE4
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

            List<char> surname = new List<char>();

            surname.Add('M');
            surname.Add('u');
            surname.Add('ñ');
            surname.Add('i');
            surname.Add('z');

            List<char> space = new List<char>();
            space.Add(' ');

            List<char> fullName = name.Concat(space).Concat(surname).ToList();

            foreach (char letter in fullName)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
