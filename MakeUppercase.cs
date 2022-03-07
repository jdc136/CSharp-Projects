/* Given a string, write a method that returns new string in which every odd letter of the word is uppercase. String may consist of one or more words.
 * https://csharpexercises.com/strings/exercise/make-uppercase
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static string MakeEveryOtherUppercase(string value) {
            char[] everyOtherUppercased = value.ToCharArray();
            for (int i = 0; i < everyOtherUppercased.Length; i++) {
                if (i % 2 == 0) {
                    everyOtherUppercased[i] = char.ToUpper(value[i]);
                }
            }
            return new string(everyOtherUppercased);
        }

        static void Main(string[] args) {
            string word = String.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter a word to make every other letter uppercase: ");
                word = Console.ReadLine();
                Console.WriteLine($"The word \"{word}\" is now: {MakeEveryOtherUppercase(word)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
