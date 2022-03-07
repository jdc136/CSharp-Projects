/* Given two strings, write a method that returns one string made of two strings. First letter of new string is first letter of first string, second letter of new string is first letter of second string and so on.
 * https://csharpexercises.com/strings/exercise/mix-two-strings
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static string MixTwoStrings(string valueOne, string valueTwo) {
            string mixedString = string.Empty;
            int length = Math.Max(valueOne.Length, valueTwo.Length);

            for (int i = 0; i < length; i++) {
                //Console.WriteLine($"Length: {length}, Index: {i}, Word One: {valueOne.Length}, Word Two: {valueTwo.Length}");
                if (i <= valueOne.Length - 1) {
                    mixedString += valueOne[i];
                }
                if (i <= valueTwo.Length - 1) {
                    mixedString += valueTwo[i];
                }
            }
            return mixedString;
        }

        static void Main(string[] args) {
            string wordOne = String.Empty;
            string wordTwo = String.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter first word: ");
                wordOne = Console.ReadLine();
                Console.Write("Enter second word: ");
                wordTwo = Console.ReadLine();

                Console.WriteLine($"The words \"{wordOne}\" and \"{wordTwo}\" combine to make: {MixTwoStrings(wordOne, wordTwo)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
