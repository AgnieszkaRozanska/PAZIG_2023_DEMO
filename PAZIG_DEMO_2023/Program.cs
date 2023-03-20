using PAZIG_DEMO_2023.Services;
using System;

namespace PAZIG_DEMO_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            double resultAdd = operations.Add(5, 10);
            Console.WriteLine($"Result: {resultAdd}");

            double resultMultiplication = operations.Multiplication(5, 10);
            Console.WriteLine($"Result: {resultMultiplication}");
            Console.ReadLine();
        }
    }
}
