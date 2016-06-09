using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, String> morseAlpha = new Dictionary<char, String>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };
            
            Console.WriteLine("Input for translation:");
            String userInput = Console.ReadLine();
            userInput = userInput.ToUpper();
            for (int x = 0; x < userInput.Length; x++)
            {
                if (x > 0)
                {
                    Console.Write('/');
                }
                char i = userInput[x];
                if (morseAlpha.ContainsKey(i))
                {
                    Console.Write(morseAlpha[i]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(false);
        }
    }
}
