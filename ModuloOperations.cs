/* Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
 * https://csharpexercises.com/basics/exercise/modulo-operations
 */

using System;

namespace ProgrammingExercises {

    class Program {

        // ModuloOperations(8, 5, 2) → 1
        public static void GetModThreeNums(int numOne, int numTwo, int numThree) {
            Console.WriteLine($"The value of {numOne} % {numTwo} = {numOne % numTwo}, and that % {numThree} = {((numOne % numTwo) % numThree)}");
        }

        public static int GetNumber() {
            int num = 0;
            Console.Write("Please enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out num)) {
                Console.Write("Please enter a valid integer: ");
            }
            return num;
        }

        static void Main(string[] args) {
            GetModThreeNums(GetNumber(), GetNumber(), GetNumber());
        }
    }
}
