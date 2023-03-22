/*  StringCharExamples
 *  
 *  To demonstrate various methods you can use to manipulate strings and chars
 *  
 *  Revision History:
 *  Tony Theo.... 2023.03.22: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCharExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringsAndChars();

            Console.ReadKey();
        }

        static void StringsAndChars()
        {
            string testString = "@ony Theo";
            char letter;

            //1. Display a string one letter at a time

            for (int i = 0; i < testString.Length; i++) 
            {
                Console.WriteLine($"{i}: {testString[i]}");
            }

            //2. Display only the letter 'T' in a string

            Console.Write("Please enter a letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < testString.Length; i++)
            {
                if (testString[i] == letter)
                {
                    Console.WriteLine($"{i}: {testString[i]}");
                }
                else
                {
                    Console.WriteLine($"{i}: ");
                }
            }

            //3. Convert strings and chars to upper or lowercase

            Console.WriteLine();

            Console.WriteLine(testString.ToUpper());
            Console.WriteLine(testString);

            testString = testString.ToUpper();
            Console.WriteLine(testString);

            testString = testString.ToLower();
            Console.WriteLine(testString);

            letter = char.ToUpper(letter);
            Console.WriteLine(letter);

            letter = char.ToLower(letter);
            Console.WriteLine(letter);

            //4. Determine what 'type' a character is

            if (char.IsLetter(testString[0]))
            {
                Console.WriteLine($"{testString[0]} is a letter");
            }
            else
            {
                Console.WriteLine($"{testString[0]} is not a letter");
            }

            if (char.IsNumber(testString[0]))
            {
                Console.WriteLine($"{testString[0]} is a number");
            }
            else
            {
                Console.WriteLine($"{testString[0]} is not a number");
            }

            if (char.IsPunctuation(testString[0]))
            {
                Console.WriteLine($"{testString[0]} is punctuation");
            }
            else
            {
                Console.WriteLine($"{testString[0]} is not punctuation");
            }
        }

    }
}
