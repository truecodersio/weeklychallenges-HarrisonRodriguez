using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool contains = false;
            for (var i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    contains = true;
                }

            }

            return contains;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            bool odd = false;
            var sum = 0;
            foreach (int value in numbers)
            {
                sum += value;
            }
            if (sum % 2 != 0)
            {
                odd = true;
            }
            return odd;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
                bool contains = false; 
                if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
                {
                    contains = true;
                }
                    return contains;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            decimal Value = Decimal.Divide(dividend,divisor);

            return Value;
        }

        public int LastMinusFirst(int[] nums)
        {
            var Answer = (nums[nums.Length - 1] - nums[0]);

            return Answer;
        }

        public int[] GetOddsBelow100()
        {
            List<int> Odds = new List<int>();

            int n = 0;

            while (n < 100)
            {
                n++;

                if ( n % 2 != 0)
                {
                    Odds.Add(n);
                }
            }

            int[] Answer = Odds.ToArray();

            return Answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
