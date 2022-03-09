/* Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.
 * https://csharpexercises.com/basics/exercise/is-result-the-same
 */

using System;

namespace ProgrammingExercises {

    class Program {

        // Considerations
        // first - do I want the user to decide what operations are being performed? 
        // second - shall the user be able to enter the two numbers as well?

        public static bool IsResultSame(int a, int b) {
            return (a == b);
        }
        
        static void Main(string[] args) {
            Console.WriteLine($"The operation 2 + 2 is equal to the operation 2 * 2: {IsResultSame(2 + 2, 2 * 2)}");
            Console.WriteLine($"The operation 9 / 3 is equal to the operation 16 - 1: {IsResultSame(9 / 3, 16 - 1)}");
        }
    }
}
