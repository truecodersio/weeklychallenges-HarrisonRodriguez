using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var num = 0;
            for(var x = 0; x < numbers.Length; x++)
			{
                if (numbers[x] % 2 == 0)
                {
                    num += numbers[x];


                }
                if (numbers[x] % 2 != 0)
                { 
                    num -= numbers[x];
                }
			        
                
			}

            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int Shortest = 0;
            if (str1.Length > Shortest)
            {
                Shortest = str1.Length;

                if (str2.Length < Shortest)
                {
                    Shortest = str2.Length;
                }
                if (str3.Length < Shortest)
                {
                    Shortest = str3.Length;
                }
                if (str4.Length < Shortest)
                {
                    Shortest = str4.Length;
                }
                
            }
            return Shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int SmallestNum = Int32.MinValue;
            if (number1 > SmallestNum)
            {
                SmallestNum = number1;

                if (number2 < SmallestNum)
                {
                    SmallestNum = number2;
                }
                if (number3 < SmallestNum)
                {
                    SmallestNum = number3;
                }
                if (number4 < SmallestNum)
                {
                    SmallestNum = number4;
                }
            }
            return SmallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool result = false;
            if (sideLength1 + sideLength2 > sideLength3)
            {


                if (sideLength1 + sideLength3 > sideLength2)
                {
                    

                    if (sideLength2 + sideLength3 > sideLength1)
                    {
                        return result = true;
                    }
                }
            }
            return result;
        }   

        public bool IsStringANumber(string input)
        {
            double x = 0;
            bool result = false;
            result = Double.TryParse(input, out x);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            bool value = false;

            int nu1 = objs.Count(s => s == null);
            int not = objs.Count(s => s != null);
            if (nu1 > not)
            {
                value = true;
            }

            return value;
        }

        public double AverageEvens(int[] numbers)
        {
            double EvenNumbers = 0;
            double Count = 0;
            double Average = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Count++;
                    EvenNumbers += numbers[i];
                    Average = EvenNumbers / Count;
                }
            }
            return Average;
        }


        public int Factorial(int number)
        {
            int i;
            int fact = 1;
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return fact;
            

        }
    }
}
