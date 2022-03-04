/* Given a sequence of brackets, write a method that checks if it has the same number of opening and closing brackets.
 * https://csharpexercises.com/strings/exercise/check-brackets-sequence
 */

using System;

namespace ProgrammingExercises {

    class Program {

        // ( = 40, opening bracket
        // ) = 41, closing bracket
        public static bool IsEqualNumOfBrackets(string brackets) {            
            int sumOpenBracket = 0;
            int sumCloseBracket = 0;

            for (int i = 0; i < brackets.Length; i++) {                
                if ((int)brackets[i] < 40 || (int)brackets[i] > 41) {
                    return false;
                }

                if ((int)brackets[i] == 40) {
                    sumOpenBracket++;
                } else {
                    sumCloseBracket++;
                }

            } //Console.WriteLine("Open brackets: " + sumOpenBracket + ", Closing Brackets: " + sumCloseBracket);            

            if (sumOpenBracket == sumCloseBracket) {
                return true;
            } else {
                return false;
            }
        }

        static void Main(string[] args) {

            // Considerations
            // First, we want to get the input (a. declare variable to hold it, b. readLine() or similar)
            // To embellish this, we could add some control that makes sure all the characters in the string are either ')' or '('
            // Second, we want to go through that string and count each bracket, forward and backward, and if the number of them are equal then return true, else false
            // We could combine the loop that checks every character in the string is a bracket and the one that counts them, with something like if we run into a non-bracket
            // character then we jump out of the loop and return a message to the user

            string input;
            string prompt = $"Please enter any number of backward or forward round bracket characters, ')' or '(': ";
            char exit = 'Y';

            while (char.ToUpper(exit) == 'Y') {
                Console.Write(prompt);
                input = Console.ReadLine();
                
                Console.WriteLine($"Is there the same number of opening and closing brackets? {IsEqualNumOfBrackets(input)}");

                Console.WriteLine("Do you want to try again?");
                exit = Console.ReadLine()[0];
            }            
        }
    }
}
