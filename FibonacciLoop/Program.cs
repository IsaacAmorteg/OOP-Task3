using System;

namespace FibonacciLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a natural number: ");
            int numberInput = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            Console.Write("{0} {1}", a, b);

            for (int i = 2; i< numberInput; i++)
            {
                c = a + b;
                if (c > numberInput)
                    break;

                Console.Write(" {0}", c);

                a = b;
                b = c;
            }
        }
    }
}