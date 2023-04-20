using System;

namespace FibonacciRecurssion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a natural number: ");
            int numberInput = int.Parse(Console.ReadLine());

           Console.Write("0 1");
            FibonacciR(0, 1, numberInput); 
                      
        }
        static void FibonacciR(int a, int b, int numberInput)
        {
            int c = a + b;

            if (c > numberInput) return;

            Console.Write(" {0}", c);

            FibonacciR(b, c, numberInput);
        }
    }
}