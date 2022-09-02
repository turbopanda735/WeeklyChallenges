using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            switch (c.ToString().ToLower())
            {
                case "a":
                case "b":
                case "c":
                case "d":
                case "e":
                case "f":
                case "g":
                case "h":
                case "i":
                case "j":
                case "k":
                case "l":
                case "m":
                case "n":
                case "o":
                case "p":
                case "q":
                case "r":
                case "s":
                case "t":
                case "u":
                case "v":
                case "w":
                case "x":
                case "y":
                case "z":
                    return true;
                default: return false;
            }
        }

        public bool CharacterIsNotALetter(char c)
        {
            switch (c.ToString().ToLower())
            {
                case "a":
                case "b":
                case "c":
                case "d":
                case "e":
                case "f":
                case "g":
                case "h":
                case "i":
                case "j":
                case "k":
                case "l":
                case "m":
                case "n":
                case "o":
                case "p":
                case "q":
                case "r":
                case "s":
                case "t":
                case "u":
                case "v":
                case "w":
                case "x":
                case "y":
                case "z":
                    return false;
                default: return true;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0) return true;
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) return true;
            else return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            if (numbers.Count() == 0)
                return 0;
            else return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
                return str2.Length;
            else return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else return numbers.Where(num => num % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            if (numbers.Sum() % 2 == 0)
                return false;
            else return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                    sum++;
            }
            return sum;
        }
    }
}
