/* Given a string, write a method that returns array of chars (ASCII characters) sorted in descending order.
 * https://csharpexercises.com/strings/exercise/sort-characters-descending
 */

using System;

namespace ProgrammingExercises {

    class Program {

        //onomatopoeia
        public static string SortDescOrd(string value) {
            char[] valArr = value.ToCharArray();
            char ch = '\0';
            //Array.Sort(valueSortedArray);
            //Array.Reverse(valueSortedArray);

            for (int i = 1; i < value.Length; i++) {
                for (int j = 0; j < value.Length - 1; j++) {
                    //Console.WriteLine($"I: {i}, Char I: {value[i]}, J: {j}, Char J: {value[j]}, Char J + 1: {value[j + 1]}, Char: {ch}, j < (j + 1): {valArr[j] < valArr[j + 1]}");
                    if (valArr[j] < valArr[j + 1]) {
                        ch = valArr[j];
                        valArr[j] = valArr[j + 1];
                        valArr[j + 1] = ch;
                    }
                    //Console.WriteLine($"I: {i}, Char I: {value[i]}, J: {j}, Char J: {value[j]}, Char J + 1: {value[j + 1]}, Char: {ch}, j < (j + 1): {valArr[j] < valArr[j + 1]}");
                }
                Console.WriteLine();
                Console.ReadKey();
            }

            return new string(valArr);
        }

        static void Main(string[] args) {
            string randomCharacters = string.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter string: ");
                randomCharacters = Console.ReadLine();

                Console.WriteLine($"The string \"{randomCharacters}\" sorted in descending order is: {SortDescOrd(randomCharacters)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
