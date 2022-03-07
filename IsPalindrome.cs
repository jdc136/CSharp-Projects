/* Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). Assume that string may consist only of lower-case letters.
 * https://csharpexercises.com/strings/exercise/is-palindrome
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static bool IsPalindrome(string value) {
            int min = 0;
            int max = value.Length - 1;

            for (int i = 0; i < value.Length / 2; i++) {
                if (char.ToUpper(value[min]) != char.ToUpper(value[max])) {
                    return false;
                } // Console.WriteLine("Min: " + value[min] + " Max: " + value[max]);
                min++;
                max--;
            }
            return true;
        }

        static void Main(string[] args) {

            string word = String.Empty;
            char exit = 'Y';

            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter a word to test if it is a palindrome: ");
                word = Console.ReadLine();
                Console.WriteLine($"The word \"{word}\" is a palindrome? {IsPalindrome(word)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
