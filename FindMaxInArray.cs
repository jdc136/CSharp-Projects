/* Another example of a test is to ask the candidate to write a function that finds the maximum value in an array of integers.
 * https://www.roberthalf.com/blog/evaluating-job-candidates/find-top-programmers-with-these-3-technical-interview-questions
*/

using System;

namespace ProgrammingExercises {

    class Program {

        // Considerations
        // First - where to get the integer array? Probably best to randomly populate one
        // Second - Finding the maximum value... this would seem to require some kind of sorting algorithm

        public static int FindMaxInArray(int[] anArray) {
            int max = 0;
            foreach (var num in anArray) {                
                if (num > max) {
                    max = num;
                }
            }
            return max;
        }

        static void Main(string[] args) {
            int min = 0;
            int max = 100;
            int[] randArr = new int[10];
            Random randNum = new Random();

            for (int i = 0; i < randArr.Length; i++) {
                randArr[i] = randNum.Next(min, max);
            }

            foreach (var num in randArr) {
                Console.WriteLine($"Element is {num}");
            }

            Console.WriteLine($"\nThe maximum value in the array is: {FindMaxInArray(randArr)}");
        }
    }
}
