// Determine whether some input is numerical or not
using System;
using System.Numerics;

namespace ProgrammingExercises {

    public class Kata {

        public static bool IsNumerical(string input)
        {
            bool isNumerical = false;
            if (
                BigInteger.TryParse(input, out _)
                || double.TryParse(input, out _)
                || decimal.TryParse(input, out _)
                )
            {
                isNumerical = true;
            }
            return isNumerical;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsNumerical("34")); // sbyte
            Console.WriteLine(IsNumerical("103498234709832"));
            Console.WriteLine(IsNumerical("1683546813289873541357684321387643546138123857687654687616846416464868468476846876876"));
            Console.WriteLine(IsNumerical("j3"));
            Console.WriteLine(IsNumerical("3.4")); // simple floating-point
            Console.WriteLine(IsNumerical("3.00000348982")); // floating point with more precision
            Console.WriteLine(IsNumerical("2.1m"));
            Console.WriteLine(IsNumerical("9223372036854775808"));
            Console.WriteLine(IsNumerical("1700000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000.1"));
        }
    }
}
