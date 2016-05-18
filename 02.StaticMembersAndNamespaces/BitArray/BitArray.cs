using System;
using System.Numerics;

namespace BitArray
{
    public class BitArray
    {
        private const int MinBitArraySize = 1;
        private const int MaxBitArraySize = 100000;

        private byte[] bits;

        public BitArray(int size)
        {
            if (size < MinBitArraySize || size > MaxBitArraySize)
            {
                throw new ArgumentOutOfRangeException("Size", "BitArray size must be in the range [1...100000]");
            }

            this.bits = new byte[size];
        }


        public int this[int index]
        {
            get
            {
                if (IsInvalidIndex(index))
                {
                    string message = string.Format("Array size is {0} bits. Index must be in the range [0...{1}]", this.bits.Length, this.bits.Length - 1);
                    throw new ArgumentOutOfRangeException("Index", message);
                }

                return bits[index];
            }
            set
            {
                if (IsInvalidIndex(index))
                {
                    string message = string.Format("Array size is {0} bits. Index must be in the range [0...{1}]", this.bits.Length, this.bits.Length - 1);
                    throw new ArgumentOutOfRangeException("Index", message);
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Elements in the BitArray can accept values of 0 or 1", "Element");
                }

                bits[index] = (byte)value;
            }
        }

        public override string ToString()
        {
            return ConvertBitArrayToDecimal().ToString();
        }

        private bool IsInvalidIndex(int index)
        {
            int maxIndex = this.bits.Length - 1;

            if (index < 0 || index > maxIndex)
            {
                return true;
            }

            return false;
        }

        private BigInteger ConvertBitArrayToDecimal()
        {
            BigInteger power = 0;
            BigInteger decimalNum = 0;

            for (int i = 0; i < this.bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    decimalNum += RaiseTwoToPower(power);
                }
                power++;
            }

            return decimalNum;
        }

        private BigInteger RaiseTwoToPower(BigInteger power)
        {
            BigInteger result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}