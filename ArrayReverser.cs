using System;
using System.Collections.Generic;

namespace Reverser
{
    public class ArrayReverser
    {
        public static List<int> ReverseArryOfIntegers(int[] numbers)
        {
            List<int> reversedArray = new List<int>();
            int increment = 1;
            //looping through the array backward and adding it to a list
            while (increment < numbers.Length + 1)
            {
                reversedArray.Add(numbers[numbers.Length-increment]);
                increment++;
            }
            foreach (var num in reversedArray)
            {
                Console.Write(num);

            }
            Console.ReadLine();
            return reversedArray;
        }

        public static long ReverseNumber(long numberToReverse)
        {
            long reversed = 0;
            while (numberToReverse>0)
            {
                reversed = reversed * 10 + numberToReverse % 10;
                numberToReverse /= 10;
            }
            return reversed;
        }
    }
}
