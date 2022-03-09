/* Given an integer, write a method that returns its absolute value.
*  Expected input and output
*  AbsoluteValue(6832) → 6832
*  AbsoluteValue(-392) → 392
*  https://csharpexercises.com/conditional-statements/exercise/absolute-value
*/

using System;

namespace ProgrammingExercises {

    class Program {

        public static void GetAbsoluteValue(double num) {
            double oldNum = num;
            if (num < 0) {
                num = num * -1;
            }
            Console.WriteLine($"The absolute value of {oldNum} is {num}");
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
            GetAbsoluteValue(GetNumber());
        }
    }
}
