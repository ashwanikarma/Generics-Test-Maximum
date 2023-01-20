﻿using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace GenericsTestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program for Generics Test Maximum of Three number");
            Console.WriteLine("Enter Three int Numbers : 50,90,10");
            Console.WriteLine(MaximumGenericMethod.MaximumIntegerNumber(50, 90, 10));
            Console.WriteLine("Enter Three float Numbers : 50.1,90.3,10.7");
            Console.WriteLine(MaximumGenericMethod.MaximumIntegerNumber(50.1, 90.3, 10.7));
            Console.WriteLine("Enter Three string Numbers : 50.1,90.3,10.7");
            Console.WriteLine(MaximumGenericMethod.MaximumIntegerNumber("50.1", "90.3", "10.7"));

        }
    }
}