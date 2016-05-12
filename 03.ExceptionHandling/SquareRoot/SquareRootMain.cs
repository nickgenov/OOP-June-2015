using System;

namespace SquareRoot
{
    public class SquareRootMain
    {
        static void Main()
        {
            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);

                double squareRoot = Math.Sqrt((double) number);
                Console.WriteLine("The square root of {0} is {1:F2}", number, squareRoot);
            }
            catch (FormatException fe)
            {
                PrintExceptionMessage(fe);
            }
            catch (OverflowException fe)
            {
                PrintExceptionMessage(fe);
            }
            finally
            {
                PrintGoodBye();
            }
        }

        private static void PrintExceptionMessage(Exception fe)
        {
            string output = string.Format("Invalid number{0}Exception message: {1}{2}StackTrace: {3}", Environment.NewLine,
                fe.Message,
                Environment.NewLine, fe.StackTrace);

            Console.WriteLine(output);
        }

        private static void PrintGoodBye()
        {
            Console.WriteLine("Good bye!");
        }
    }
}