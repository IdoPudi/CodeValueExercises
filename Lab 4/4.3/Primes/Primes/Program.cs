﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;

            Console.WriteLine("Please enter number :");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number :");
            number2 = int.Parse(Console.ReadLine());

            CalcPrimes(number1, number2);

            Console.ReadKey();

        }

        //Consider a better name
        private static void CalcPrimes(int number1, int number2)
        {
            //Even with C you could have decleared this variable at the same line ;)
            int[] primeNumbers;

            primeNumbers = GetPrimeNumbers(number1,number2);

            foreach (var primeNumber in primeNumbers)
            {
                Console.WriteLine(primeNumber);
            }
        }

        private static int[] GetPrimeNumbers(int number1, int number2)
        {
            int[] numbers;
            ArrayList primeNumbers = new ArrayList();

            for (int x = number1; x < number2; x++)
            {
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    //The conveintion in C# is to start body expressions in a seperate line and with bracets "{ }", even for oneliners
                    if (isPrime == 2)
                    {
                        break;
                    }
                }
                if (isPrime != 2)
                    primeNumbers.Add(x);

                //Redundant
                isPrime = 0;
            }

            numbers = new int[primeNumbers.Count];
            primeNumbers.CopyTo(numbers);

            return numbers;
        }
    }
}
