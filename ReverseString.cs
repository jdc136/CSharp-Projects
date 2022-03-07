/* Given a string, write a method that returns that string in reverse order.
 * https://csharpexercises.com/strings/exercise/string-in-reverse-order
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static string ReverseString(string value) {
            int max = value.Length - 1;
            string reversedValue = String.Empty;
            for (int i = 0; i < value.Length; i++) {
                reversedValue += value[max];
                max--;
            }
            return reversedValue;
        }

        static void Main(string[] args) {
            string word = String.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter a word to reverse it: ");
                word = Console.ReadLine();
                Console.WriteLine($"The reversal of the word \"{word}\" is: {ReverseString(word)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
