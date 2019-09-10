using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double x = minuend;
            double y = subtrahend;

            return x - y;
        }

        public int Add(int number1, int number2)
        {
            int x = number1;
            int y = number2;

            return x + y;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number2;

            }
            else
            {
                return number1;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            long x = factor1;
            long y = factor2;

            return x * y;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return "Hello, " + nameOfPerson + "!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
