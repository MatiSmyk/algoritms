using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class Algoritms
    {
        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz, ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz, ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz, ");
                }
                else
                {
                    Console.Write($"{i}, ");
                }
            } 
        }

        public void Swap(int x, int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"x = {x}, y = {y}");
        }

        public void Fibonacci(int n)
        {
            int x = 0;
            int y = 1;
            int i = 2;
            int z;

            while (i <= n)
            {
                z = x + y;

                Console.Write($"{z} ");

                x = y;
                y = z;
                i++;
            }
        }

        public void Reverse(string text)
        {
            char[] chars = new char[text.Length];    
            int index = 0;

            for (int i = text.Length - 1; i >= 0 ; i--)
            {
                chars[index] = text[i];
                index++;
            }
            Console.WriteLine(chars);
        }

        public string ReverseV2(string text)
        {
            char[] chars = new char[text.Length];
            int index = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                chars[index] = text[i];
                index++;
            }
            Console.WriteLine(chars);
            return new string(chars);
        }

        public void Palindrom(string text)
        {
            if (text == ReverseV2(text))
            {
                Console.WriteLine("tak");
            }
            else
            {
                Console.WriteLine("nie");
            }
        }
        public void PalindromV2(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    Console.WriteLine("nie");
                    return;
                }
            }
            Console.WriteLine("tak");
        }
        public int[] SumOfNumbers(int[] numbers)
        {
            int plus = 0;
            int minus = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] >= 0)
                {
                    plus += numbers[i];
                }
                else 
                { 
                    minus += numbers[i];
                }

            }
            int[] result = new int[2] {plus, minus};
            return result;
        }
    }
}
