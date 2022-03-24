using System;
using System.Linq;

namespace ProgrammingExercises {

    public class Kata {

        public static bool IsPalindrome(string value)
        {
            var returnValue = false;
            var wordArray = value.ToCharArray();
            Array.Reverse(wordArray);
            var reverseWord = new String(wordArray);
            
            if (value.ToUpper() == reverseWord.ToUpper())
            {
                returnValue = true;
            }

            return returnValue;
        }

        static void Main(string[] args)
        {
            string[] words = { "Repaper", "Jared", "Malayalam", "tacocat", "Fox", "abcdedcba" };
            var tempWord = string.Empty;

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    if (word.Length > tempWord.Length)
                    {
                        tempWord = word;
                    }
                }
            }

            Console.WriteLine($"The length of the longest palindrome is {tempWord.Length}");
            Console.WriteLine("The palindromes with this length are: ");
            foreach (var word in words)
            {
                if (word.Length == tempWord.Length)
                {
                    Console.WriteLine($"- {word}");
                }
            }

            // with lambda expression
            //words.Where(x => x.Length == tempWord.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
