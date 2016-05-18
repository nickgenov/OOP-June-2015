using System;

namespace BitArray
{
    public class BitArrayMain
    {
        static void Main()
        {
            var bitArray = new BitArray(8);

            bitArray[7] = 1;
            Console.WriteLine(bitArray); //128

            bitArray = new BitArray(100000);

            bitArray[99999] = 1;
            Console.WriteLine(bitArray); //something huge
        }
    }
}