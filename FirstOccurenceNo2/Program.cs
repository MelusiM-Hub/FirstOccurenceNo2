using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOccurenceNo2
{
    using System;

    namespace FirstOccurrenceWord
    {
        class Program
        {
            static void Main(string[] args)
            {
                string sentence = "THE QUICK BROWN FOX JUMPS OVER A LAZY DOG.";

                Console.WriteLine("Enter a letter:");
                char letter = Console.ReadLine()[0];
                char uppercaseLetter = char.ToUpper(letter);

                int position = sentence.IndexOf(uppercaseLetter);
                int nextSpacePosition = sentence.IndexOf(' ', position);

                string word = sentence.Substring(position + 1, nextSpacePosition - position - 1);

                Console.WriteLine($"{uppercaseLetter} first occurrence in word {word}");

                Console.ReadLine();
            }
        }
    }

}
