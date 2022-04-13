using System;

namespace Algoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algoritms algoritms = new Algoritms();

            //algoritms.FizzBuzz();
            //algoritms.Swap(5, 12);
            //algoritms.Fibonacci(12);
            //algoritms.Reverse("tekst do odwrócenia");
            //algoritms.Palindrom("tartak");
            //algoritms.PalindromV2("anna");
            algoritms.SumOfNumbers(new int[] { 2, -8, 11, 2, -2, -1 });

            Console.ReadKey();
        }
    }
}
