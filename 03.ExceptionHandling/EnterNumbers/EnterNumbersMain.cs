using System;

namespace EnterNumbers
{
    public class EnterNumbersMain
    {
        static void Main()
        {
            int start = 2;
            int end = 99;

            int enteredNumberCount = 0;
            int previousNumber = int.MinValue;

            Console.WriteLine("Enter integers in the range [{0}...{1}]", start, end);
            Console.WriteLine("Each number must be greater than the previous one.");

            while (true)
            {
                try
                {
                    int number = ReadNumber(start, end);
                    if (number <= previousNumber)
                    {
                        Console.WriteLine("Each number must be larger than the last and in the range [{0}...{1}]", start, end);

                        continue;
                    }
                    previousNumber = number;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                enteredNumberCount++;

                if (enteredNumberCount == 10)
                {
                    break;
                }
            }
            Console.WriteLine("Program finished!");
        }

        private static int ReadNumber(int start, int end)
        {
            Console.Write("Enter value: ");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number) == false)
            {
                throw new FormatException("Invalid number format");
            }

            number = int.Parse(input);

            if (number < start || number > end)
            {
                string message = string.Format("Number must be in the range [{0}...{1}]. Try again.", start, end);
                throw new ArgumentOutOfRangeException("Number", message);
            }

            return number;
        }
    }
}