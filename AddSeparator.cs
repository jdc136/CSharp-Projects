/* Given a string and a separator, write a method that adds separator between each adjacent characters in a string.
 * https://csharpexercises.com/strings/exercise/add-separator
 */

using System;

namespace ProgrammingExercises {

    class Program {

        // AddSeparator("ABCD", "^") → "A^B^C^D^"
        public static string AddSeparator(string value, char separator) {

            string delimitedWord = String.Empty;

            for (int i = 0; i < value.Length; i++) {
                delimitedWord += String.Concat(value[i], separator);               
            }

            return delimitedWord.TrimEnd(separator);
        }

        static void Main(string[] args) {

            string word = "ABCD";
            char delimiter = '^';

            Console.WriteLine(word);
            Console.WriteLine(AddSeparator(word, delimiter));
            
        }
    }
}
