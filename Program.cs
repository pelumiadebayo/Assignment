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
            Console.ReadLine();

            //calling the ReverseArryOfIntegers from the ArrayReverser class
            var reversedArray = ArrayReverser.ReverseArryOfIntegers(new int[] {1,2,3,4,5,5});
            foreach (var num in reversedArray)
            {
                Console.Write(num + ",");
            }
            Console.ReadLine();
        }
    }
}
