using System;
using System.Collections.Generic;

namespace Reverser
{
    public class ArrayReverser
    {
        //The function to reverse our integers
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
            return reversedArray;
        }
    }
}
