using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the ReverseString from the StringReverser class
            var reversedString = StringReverser.ReverseString("Pelumi");
            Console.WriteLine(reversedString);

            //calling the ReverseArryOfIntegers from the ArrayReverser class
            var reversedArray = ArrayReverser.ReverseArryOfIntegers(new int[] {1,2,3,4,5,5});
            Console.WriteLine(reversedArray);

            Console.ReadLine();

            Console.WriteLine(ArrayReverser.ReverseNumber(123));
            Console.ReadLine();

            var stopWatch = new StopWatch();

        }

    }
}
