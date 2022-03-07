/* Given a string, write a method that returns its length. Do not use library methods!
 * https://csharpexercises.com/strings/exercise/length-of-string
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static int GetStringLength(string value) {
            int length = 0;
            foreach (var letter in value) {
                length++;
            }
            return length;
        }

        static void Main(string[] args) {
            string word = String.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter a word to test if it is a palindrome: ");
                word = Console.ReadLine();
                Console.WriteLine($"The length of the word \"{word}\" is: {GetStringLength(word)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
