using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace GenericsTestMaximum
{
    internal class Program
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program for Generics Test Maximum of Three number");
            Console.WriteLine("Enter Three Numbers : 50,90,10");
            Console.WriteLine(MaximumIntegerNumber(50, 90, 10));

        }
    }
}