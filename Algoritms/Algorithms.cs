using System;

namespace Algoritms
{
    public class Algorithms
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

            for (int i = text.Length - 1; i >= 0; i--)
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
            int[] result = new int[2] { plus, minus };
            return result;
        }

        public void MakeSentence(string[] words)
        {
            string result = null;
            result += char.ToUpper(words[0][0]) + words[0].Substring(1);
            for (int i = 1; i < words.Length; i++)
            {
                result += $" {words[i]}";
            }
            result += ".";
            Console.WriteLine(result);
        }
        public int[] BubbleSort(int[] numbers)
        {
            //int helping;
            int n = numbers.Length;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        //helping = numbers[j-1];
                        //numbers[j-1] = numbers[j];
                        //numbers[j] = helping;

                        (numbers[j - 1], numbers[j]) = (numbers[j], numbers[j - 1]);
                    }
                }
            }
            return numbers;
        }
        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
        public int Mult(int x, int y)
        {
            if (x == 1)
            {
                return y;
            }
            return y + Mult(x - 1, y);
        }

        public int[] UpperCase(string text)
        {
            int[] temporaryIndexesOfUpperCases = new int[text.Length];
            int j = 0;
            for (var i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text, i))
                {
                    temporaryIndexesOfUpperCases[j++] = i;
                }
            }
            int[] indexesOfUpperCases = new int[j];
            int k = 0;  
            foreach (var index in temporaryIndexesOfUpperCases)
            {
                indexesOfUpperCases[k] = temporaryIndexesOfUpperCases[k++];
            }

            return indexesOfUpperCases;
        }

        public void BMIcalculator(double weight, double height)
        {
            double bmi = Math.Round(weight / (height * height), 2);
            //double bmi = weight / (height * height);
            string interpretation = "";
            if (bmi < 16)
            {
                interpretation = "wygłodzenie";
            }
            else if (16 <= bmi && bmi < 17)
            {
                interpretation = "wychudzenie";
            }
            else if (17 <= bmi && bmi < 18.5)
            {
                interpretation = "niedowaga";
            }
            else if (18.5 <= bmi && bmi < 25)
            {
                interpretation = "waga prawidłowa";
            }
            else if (25 <= bmi && bmi < 30)
            {
                interpretation = "nadwaga";
            }
            else if (30 <= bmi && bmi < 35)
            {
                interpretation = "otyłość I stpnia";
            }
            else if (35 <= bmi && bmi < 40)
            {
                interpretation = "otyłość II stpnia";
            }
            else
            {
                interpretation = "otyłość III stpnia";
            }


            Console.WriteLine($"BMI {bmi} - {interpretation}");

        }
        public void ToBinary(int number)
        {
            string numberStr = Convert.ToString(number, 2);
            int zero = 0;
            int one = 0;
            for (int i = 0; i < numberStr.Length; i++)
            {
                if (numberStr[i] == '0')
                {
                    zero++;
                }
                else
                {
                    one++;
                }
            }
            Console.WriteLine($"{number} -> {numberStr}\nliczba 0: {zero}\nliczba 1: {one}");
        }
    }
}
