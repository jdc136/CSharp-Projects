/* Given a number, write a method that returns its cube.
*  Expected input and output
*  TheCubeOf(2) → 8
*  TheCubeOf(-5.5) → -166.375
*  https://csharpexercises.com/basics/exercise/the-cube-of
*/

using System;

namespace ProgrammingExercises {

    class Program {

        public static void CubeNumber(double num) {
            Console.WriteLine($"The number {num} cubed equals {num * num * num}");
        }

        public static double GetNumber() {
            double num = 0;
            Console.Write("Please enter a number: ");
            while (!double.TryParse(Console.ReadLine(), out num)) {
                Console.Write("Please enter a valid number: ");
            }
            return num;
        }

        static void Main(string[] args) {
            CubeNumber(GetNumber());
        }
    }
}
