/* Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) does not exist!
 * https://csharpexercises.com/basics/exercise/celsius-to-fahrenheit
 */

using System;

namespace ProgrammingExercises {

    class Program {

        public const float MIN_TEMP_CELSIUS = -271.15f;

        public static string CtoF(double temp) {
            temp = ConvertCtoF(temp);
            return $"T = {temp}F";
        }

        // (0 C x (9/5)) + 32 = 32 F
        public static double ConvertCtoF(double temp) {            
            return Math.Round(((temp * (9 / 5.0f)) + 32), 2);
        }

        public static string ReadString(string prompt) {
            string result;
            do {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");
            return result;
        }

        public static float ReadFloat(string prompt) {
            float result;
            do {
                string floatString = ReadString(prompt);
                if (float.TryParse(floatString, out result) && result < MIN_TEMP_CELSIUS) {
                    Console.WriteLine("Temperature below absolute zero!");
                    continue;
                }
                if (float.TryParse(floatString, out result) && result >= MIN_TEMP_CELSIUS) {
                    break;
                }
                Console.WriteLine("Invalid input. Try again...");
            } while (true);
            return result;
        }

        static void Main(string[] args) {            
            double inputTemp;
            string prompt = $"Please enter the degree in Celsius, (must be above {MIN_TEMP_CELSIUS}): ";
            char input = 'Y';

            while (char.ToUpper(input) == 'Y') {
                inputTemp = ReadFloat(prompt);
                Console.WriteLine(CtoF(inputTemp));

                Console.Write("Do you want to enter another temperature (Y/N)? ");
                input = Console.ReadLine()[0];

            }
        }
    }
}
