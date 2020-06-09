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
            name.Add('R');
            name.Add('I');
            name.Add('O');
            name.Add('L');

            List<char> surname = new List<char>();

            surname.Add('M');
            surname.Add('U');
            surname.Add('N');
            surname.Add('I');
            surname.Add('Z');

            List<char> space = new List<char>();
            space.Add(' ');

            List<char> fullName = name.Concat(space).Concat(surname).ToList();

            foreach (char letter in fullName)
            {
                Console.Write(letter);
            }
        }
    }
}
