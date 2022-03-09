/* Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division. 
 * Remember that you can't divide any number by 0!
 * https://csharpexercises.com/basics/exercise/elementary-operations
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static void BasicArithmeticDisplay(int n1, int n2) {
            Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
            if (n2 == 0) {
                Console.WriteLine("Can't divide by zero!");
            } else {
                Console.WriteLine($"{n1} / {n2} = {Math.Round((n1 / (double)n2), 2)}");
            }            
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        }

        public static int GetNumber() {
            int num = 0;
            Console.Write("Please enter number: ");
            while (!(int.TryParse(Console.ReadLine(), out num))) {
                Console.Write("Please enter a valid integer: ");
            }
            return num;
        }
        
        static void Main(string[] args) {
            char exit = 'Y';
            Console.WriteLine("You will enter two numbers and see the basic arithmetic operations for the two numbers.");

            while (char.ToUpper(exit) == 'Y') {
                BasicArithmeticDisplay(GetNumber(), GetNumber());
                Console.Write("Would you like to try again? ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
