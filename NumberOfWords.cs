/* Given a string, write a method that counts its number of words. Assume there are no leading and trailing whitespaces and there is only single whitespace between two consecutive words.
 * https://csharpexercises.com/strings/exercise/number-of-words#
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static int GetNumberOfWords(string value) {
            int numberOfWords = 1;
            if (value == "") {
                numberOfWords = 0;
            }
            for (int i = 0; i < value.Length; i++) {

                if (char.IsWhiteSpace(value[i])) {
                    numberOfWords++;
                }
            }
            return numberOfWords;
        }

        static void Main(string[] args) {
            string sentence = String.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter sentence: ");
                sentence = Console.ReadLine();

                Console.WriteLine($"The sentence \"{sentence}\" has {GetNumberOfWords(sentence)} words");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
