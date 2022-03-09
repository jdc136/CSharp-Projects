/* Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
 * For numbers which are multiples of both three and five print “FizzBuzz”.
 * https://imranontech.com/2007/01/24/using-fizzbuzz-to-find-developers-who-grok-coding/
 */

using System;

namespace ProgrammingExercises {

    class Program {

        static void Main(string[] args) {
            
            // Solution I come up with in about 3 minutes
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }

            // Solution I gathered from the comments
            for (int i = 1; i <= 100; i++) {
                string result = string.Empty;
                if (i % 3 == 0) {
                    result += "Fizz";
                }
                if (i % 5 == 0) {
                    result += "Buzz";
                }
                Console.WriteLine((result == "" ? i.ToString() : result));
                result = string.Empty;
            }
        }
    }
}
