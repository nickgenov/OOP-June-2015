using System;
using System.Numerics;

namespace BitArray
{
    public class BitArray
    {
        private const int MinBitArraySize = 1;
        private const int MaxBitArraySize = 100000;

        private int[] elements;

        public BitArray(int size)
        {
            if (size < MinBitArraySize || size > MaxBitArraySize)
            {
                throw new ArgumentOutOfRangeException("Size", "BitArray size must be in the range [1...100000]");
            }
            this.elements = new int[size];
        }


        public int this[int index]
        {
            get
            {
                if (IsInvalidIndex(index))
                {
                    string message = string.Format("Array size is {0} elements. Index must be in the range [0...{1}]", this.elements.Length, this.elements.Length - 1);
                    throw new ArgumentOutOfRangeException("Index", message);
                }

                return elements[index];
            }
            set
            {
                if (IsInvalidIndex(index))
                {
                    string message = string.Format("Array size is {0} elements. Index must be in the range [0...{1}]", this.elements.Length, this.elements.Length - 1);
                    throw new ArgumentOutOfRangeException("Index", message);
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Elements in the BitArray can accept values of 0 or 1", "Element");
                }

                elements[index] = value;
            }
        }

        private bool IsInvalidIndex(int index)
        {
            int maxIndex = this.elements.Length - 1;

            if (index < 0 || index > maxIndex)
            {
                return true;
            }

            return false;
        }


        //TODO Fix method - results are wrong!
        public override string ToString()
        {
            BigInteger bitArrayValue = 0;
            double power = 0;

            for (int i = this.elements.Length - 1; i >= 0; i--)
            {
                if (this.elements[i] == 1)
                {
                    BigInteger indexValue = (BigInteger)Math.Pow(2, power);
                    bitArrayValue += indexValue;
                }
                power++;
            }

            return bitArrayValue.ToString();
        }
    }
}