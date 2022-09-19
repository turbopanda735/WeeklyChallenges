using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var length = 10;

            var strList = new List<string>() { str1, str2, str3, str4 };
            foreach (var str in strList)
            {
                if (str.Length <= length)
                {
                    length = str.Length;
                }
            }
            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var number = 10;

            var numList = new List<int>() { number1, number2, number3, number4 };
            foreach (var num in numList)
            {
                if (num <= number)
                {
                    number = num;
                }
            }
            return number;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2)
                return true;
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            var number = 0.0;
            return double.TryParse(input, out number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var empty = 0;
            var full = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    empty++;
                }
                else
                {
                    full++;
                }
            }
            if (empty > full)
            {
                return true;
            }
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            var sum = 0.0;
            var count = 0.0;
            if (numbers == null)
                return 0;
            foreach (var num in numbers)
            {
                if ((num * -1) % 2 == 0)
                {
                    sum += num;
                    count++;
                }
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count >= 1)
            {
                return sum / count;
            }
            else return 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                var factor = 1;
                for (int i = 1; i <= number; i++)
                {
                    factor *= i;
                }
                return factor;
            }
        }
    }
}
