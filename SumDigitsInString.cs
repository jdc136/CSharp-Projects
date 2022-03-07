/* Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.
 * https://csharpexercises.com/strings/exercise/sum-digits-in-string
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static int GetSumDigitsInString(string value) {
            int temp = 0;
            int sum = 0;
            for (int i = 0; i < value.Length; i++) {
                if (int.TryParse(value[i].ToString(), out temp)) {
                    sum = sum + temp;
                }
            }
            return sum;
        }

        static void Main(string[] args) {
            string word = String.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter a string to get the sum of the digits in it: ");
                word = Console.ReadLine();
                Console.WriteLine($"The sum of the digits in the string \"{word}\" is: {GetSumDigitsInString(word)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
