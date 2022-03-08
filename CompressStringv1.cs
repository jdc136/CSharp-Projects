/* Given a non-empty string, write a method that returns it in compressed format.
 * https://csharpexercises.com/strings/exercise/compress-string
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public static string CompressString(string value) {
            string compressedValue = string.Empty;
            char ch = value[0];
            int count = 0;

            for (int i = 0; i < value.Length; i++) {
                if (ch == value[i]) {
                    count++;
                } if (ch != value[i]) {
                    compressedValue += ch + count.ToString();
                    count = 1;                    
                }
                ch = value[i];
            }
            compressedValue += ch + count.ToString();
            return compressedValue;
        }

        static void Main(string[] args) {
            string randomCharacters = string.Empty;
            // aaaabbcccccdaa
            // 948kro
            // $999j*#jjjfYyyy"
            // kkkktttrrrrrrrrrr
            // p555ppp7www
            char exit = 'Y';
            while (char.ToUpper(exit) == 'Y') {
                Console.Write("Enter string: ");
                randomCharacters = Console.ReadLine();

                Console.WriteLine($"The string \"{randomCharacters}\" compressed is: {CompressString(randomCharacters)}");

                Console.Write("Would you like to try again? Y/N: ");
                exit = Console.ReadLine()[0];
            }
        }
    }
}
