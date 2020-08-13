using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace week2lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrimeNumbers();
            // EvenNumbers();
            // Fibonacci();
            // NumbersPyramid();
            // ThirdPower();
            // Sum();
            // Diamond();
            // ReverseString();
            // DecToBin();
            // LeastCommonMultiple();
        }

        public static void PrimeNumbers()
        {
            Console.WriteLine("Exercise 1");
            Console.WriteLine();

            List<int> primeNumbers = new List<int>();

            for (int i = 2; i <= 100; i++)
            {
                int counter = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    primeNumbers.Add(i);
                }
            }
            foreach (var number in primeNumbers)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine();

            Console.WriteLine($"W przedziale od 0 do 100 jest {primeNumbers.Count} liczb pierwszych.");
        }

        public static void EvenNumbers()
        {
            Console.WriteLine("Exercise 2");
            Console.WriteLine();

            int number = 1;
            do
            {
                if (number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
                number++;
            }
            while (number <= 1000);
        }

        public static void Fibonacci()
        {
            Console.WriteLine("Exercise 3");
            Console.WriteLine();

            int a = 0;
            int b = 1;
            Console.WriteLine("Podaj długość ciągu:");
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.Write(a + " ");
            }
        }

        public static void NumbersPyramid()
        {
            Console.WriteLine("Exercise 4");
            Console.WriteLine();

            Console.WriteLine("Podaj 'długość' piramidy:");
            int pyramidLength = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int count = 1;

            for (int i = 0; i < pyramidLength; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{count} ");
                    count++;

                    if (count > pyramidLength)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (count > pyramidLength)
                {
                    break;
                }
            }
        }

        public static void ThirdPower()
        {
            Console.WriteLine("Exercise 5");
            Console.WriteLine();

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (var item in numbers)
            {
                Console.WriteLine(Math.Pow(item, 3));
            }
        }

        public static void Sum()
        {
            Console.WriteLine("Exercise 6");
            Console.WriteLine();

            double sumSequence = 0;

            for (int i = 1; i <= 20; i++)
            {
                sumSequence += (1.0 / i);
            }

            Console.WriteLine($"Suma wynosi: {Math.Round(sumSequence, 4)}");
        }

        public static void Diamond()
        {
            Console.WriteLine("Exercise 7");
            Console.WriteLine();

            int number, i, k, count = 1;

            Console.WriteLine("Podaj ilość wierszy (połowa wysokości: ");

            number = int.Parse(Console.ReadLine());
            count = number - 1;

            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;

                for (i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            count = 1;

            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }

                count++;

                for (i = 1; i <= 2 * (number - k) - 1; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void ReverseString()
        {
            Console.WriteLine("Exercise 8");
            Console.WriteLine();

            Console.WriteLine("Wpisz ciąg znaków:");
            string text = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[text.Length - i - 1]);
            }

            Console.WriteLine();
        }

        public static void DecToBin()
        {
            Console.WriteLine("Exercise 9");
            Console.WriteLine();

            Console.WriteLine("Podaj liczbę:");
            int number = int.Parse(Console.ReadLine());

            string binary = string.Empty;

            for (int i = 0; number > 0; i++)
            {
                binary = number % 2 + binary;
                number /= 2;
            }
            Console.WriteLine($"W systemie binarnym to: {binary}");
        }

        public static void LeastCommonMultiple()
        {
            Console.WriteLine("Exercise 10");
            Console.WriteLine();

            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());

            int lcm = a;

            while (lcm % b != 0)
            {
                lcm += a;
            }

            Console.WriteLine();

            Console.WriteLine($"Najmniejsza wspólna wielokrotność liczb {a} i {b} wynosi {lcm}");
        }
    }     
}
