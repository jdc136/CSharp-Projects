/* Given a sequence of brackets, write a method that checks if it has the same number of opening and closing brackets.
 * https://csharpexercises.com/strings/exercise/check-brackets-sequence
 */

using System;

namespace ProgrammingExercises {

    class Program {

        // ( = 40, opening bracket
        // ) = 41, closing bracket
        public static bool IsEqualNumOfBrackets(string brackets) {

            int check = 0;

            for (int i = 0; i < brackets.Length; i++) {
                check = ((brackets[i] == '(') ? ++check : --check);
            }
            return (check == 0);
        }

        static void Main(string[] args) {

            string input;
            string prompt = $"Please enter any number of backward or forward round bracket characters, ')' or '(': ";
            char exit = 'Y';

            while (char.ToUpper(exit) == 'Y') {
                Console.Write(prompt);
                input = Console.ReadLine();
                
                Console.WriteLine($"Is there the same number of opening and closing brackets? {IsEqualNumOfBrackets(input)}");

                Console.Write("Do you want to try again? ");
                exit = Console.ReadLine()[0];
            }            
        }
    }
}
