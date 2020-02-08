using System;

namespace Reverser
{
    public  class StringReverser
    {
        //The class to reverse our string
        public static string ReverseString(string myString)
        {
            string reversedString = "";
            int increment = 1;
            //looping through the string backward and concatinating it into a new string
            while (increment < myString.Length + 1)
            {
                reversedString += myString[myString.Length - increment];
                increment++;
            }
            return reversedString;
        }

    }
}
