/* Given three numbers, write a method that adds two first ones and multiplies them by a third one.
Expected input and output
AddAndMultiply(2, 4, 5) → 30 
https://csharpexercises.com/basics/exercise/add-two-numbers */

using System;

namespace ProgrammingExercises {

    class Program {

        public static string ToOrdinal(int num) {
            string extension = "th";
            int lastDigits = num % 100;
            if (lastDigits < 11 || lastDigits > 13) {
                switch (lastDigits % 10) {
                    case 1:
                        extension = "st";
                        break;
                    case 2:
                        extension = "nd";
                        break;
                    case 3:
                        extension = "rd";
                        break;
                }
            }
            return extension;
        }
        
        public static string ReadString(string prompt) {
            string result;
            do {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");
            return result;
        }

        public static int ReadInt(string prompt) {
            int result;
            do {
                string intString = ReadString(prompt);
                if (int.TryParse(intString, out result)) {
                    break;
                }
                Console.WriteLine("Invalid input. Try again...");
            } while (true);
            return result;
        }

        static void Main(string[] args) {

            // (2 + 4) * 5 = 30
            int numOfIntsToGet = 3;
            int[] userInts = new int[numOfIntsToGet];
            int answer;
            
            Console.WriteLine("Hello! Welcome to the AddAndMultiply calculator.");
            Console.WriteLine("Please enter three numbers - the first two will be added, and multiplied by the third (respecting order of operations)");

            for (int i = 0; i < numOfIntsToGet; i++) {
                userInts[i] = ReadInt($"Please enter {(i + 1) + ToOrdinal(i + 1)} number: ");
            }

            answer = (userInts[0] + userInts[1]) * userInts[2];

            Console.WriteLine($"The answer is: {answer}");
        }
    }
}
