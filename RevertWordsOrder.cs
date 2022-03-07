/* Given a string, write a method that counts its number of words. Assume there are no leading and trailing whitespaces and there is only single whitespace between two consecutive words.
 * https://csharpexercises.com/strings/exercise/number-of-words#
 */

using System;

namespace ProgrammingExercises {

    class Program {

        // Proin in odio viverra, accumsan purus vel, placerat elit! --> elit placerat vel, purus accumsan viverra, odio in Proin!
        // Cras iaculis tortor justo. --> justo tortor iaculis Cras.
        // A, B. C --> C B. A,
        // John Doe. --> Doe John.
        public static string RevertWordOrder(string value) {
            char punctuation = value[value.Length - 1];
            string[] revertedValueSplit = value.Split(' ');
            string revertedValue = string.Empty;

            for (int i = revertedValueSplit.Length; i > 0; i--) {
                //Console.WriteLine($"Index: {i}, Length: {revertedValueSplit.Length}, Word: {revertedValueSplit[i - 1]}, New String: {revertedValue}");
                if (i == revertedValueSplit.Length) {
                    revertedValue += revertedValueSplit[i - 1].TrimEnd(punctuation) + " ";
                } else if (i == 1) {
                    revertedValue += revertedValueSplit[i - 1] + punctuation.ToString();
                } else {
                    revertedValue += revertedValueSplit[i - 1] + " ";
                }
            }

            //string[] strArray = value.Split(' ');
            //int len = strArray.Length;
            //for (int i = 0; i < len / 2; i++) {
            //    string temp = strArray[i];
            //    if (i == 0) {
            //        Console.WriteLine($"Index: {i}, Temp: {strArray[i]}, Result 1: {strArray[len - 1].Remove(strArray[len - 1].Length - 1)}");
            //        Console.WriteLine($"Index: {i}, Temp: {strArray[i]}, Result 2: {temp + strArray[len - 1].Substring(strArray[len - 1].Length - 1)}");
            //        strArray[i] = strArray[len - 1].Remove(strArray[len - 1].Length - 1);
            //        strArray[len - 1] = temp + strArray[len - 1].Substring(strArray[len - 1].Length - 1);

            //    } else {
            //        Console.WriteLine($"Index: {i}, Temp: {strArray[i]}, Result 3: {strArray[len - 1 - i]}");
            //        Console.WriteLine($"Index: {i}, Temp: {strArray[i]}, Result 4: {temp}");
            //        strArray[i] = strArray[len - 1 - i];
            //        strArray[len - 1 - i] = temp;
            //    }
            //}

            return revertedValue;
        }

        static void Main(string[] args) {
            string sentence = string.Empty;
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter sentence: ");
                sentence = Console.ReadLine();

                Console.WriteLine($"The sentence \"{sentence}\" has been reverted to: {RevertWordOrder(sentence)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
