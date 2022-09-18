using System;
using Part6.Payment;

namespace Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            IncomeCalculator calculator = new IncomeCalculator(100, 200);
            Console.WriteLine(calculator);
        }
    }
}
