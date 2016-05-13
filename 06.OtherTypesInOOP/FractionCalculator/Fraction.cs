using System;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denominator", "The denominator of a fraction cannot be zero.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            long numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            long denominator = a.Denominator * b.Denominator;

            Fraction result = new Fraction(numerator, denominator);
            return result;
        }

        public override string ToString()
        {
            double fractionValue = (double) this.Numerator / (double) this.Denominator;
            string result = string.Format("{0}", fractionValue);
            return result;
        }
    }
}