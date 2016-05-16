using System;

namespace BitArray
{
    public class BitArrayMain
    {
        static void Main()
        {
            var bitArray = new BitArray(5);

            bitArray[3] = 1;
            Console.WriteLine(bitArray);

            bitArray[0] = 1;
            Console.WriteLine(bitArray);

            bitArray[3] = 0;
            Console.WriteLine(bitArray);

        }
    }
}