/* Given two integers, write a method that swaps them using temporary variable.
*  Expected input and output
*  SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"
*  SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"
*/

using System;

namespace ProgrammingExercises {

    class Program {

        public static void SwitchNumbers(double numOne, double numTwo) {
            double temp = numOne;
            numOne = numTwo;
            numTwo = temp;
            Console.WriteLine($"The numbers switched are:\n\tA = {numOne}, B = {numTwo}");
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
            double A = GetNumber();
            double B = GetNumber();
            Console.WriteLine($"You have entered:\n\tA = {A}, B = {B}\n");
            SwitchNumbers(A, B);
        }
    }
}
