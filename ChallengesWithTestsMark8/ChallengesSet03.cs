using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Where(val => val == false).Count() == 0)
                return false;
            else return true;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            if (numbers.Where(number => number % 2 != 0).Sum() % 2 != 0)
                return true;
            else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNum = false;
            if (password.Any(char.IsUpper) == true)
                containsUpper = true;
            if (password.Any(char.IsLower) == true)
                containsLower = true;
            if (password.Any(char.IsNumber) == true)
                containsNum = true;
            if (containsUpper == true && containsLower == true && containsNum)
                return true;
            else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var oddList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                    oddList.Add(i);
            }
            return oddList.ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            return words;
        }
    }
}
