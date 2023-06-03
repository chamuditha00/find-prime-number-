using System;

namespace Q1
{
    internal class Program
    {
        // Function to check if a number is prime
        static bool Isprime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            // Check for divisibility from 2 to num - 1
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            // If no divisor found, it is prime
            return true;
        }

        // Function to count the number of divisors for a given number
        static int countDivisors(int num)
        {
            int count = 0;

            // Check for divisibility from 1 to num - 1
            for (int i = 1; i < num; ++i)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            // Return the count of divisors
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter range of number (ex: 20-30)");
            string InputRange = Console.ReadLine();
            string[] valueofRange = InputRange.Split('-');
            int start = int.Parse(valueofRange[0]);
            int end = int.Parse(valueofRange[1]);

            int maxD = 0;
            int numMaxD = 0;

            Console.WriteLine("Prime numbers in the range {0}-{1}:", start, end);

            // Iterate through the range of numbers
            for (int i = start; i < end; i++)
            {
                // Check if the number is prime and print it
                if (Isprime(i))
                {
                    Console.WriteLine("{0}", i);
                }

                // Count the divisors for the current number
                int divisors = countDivisors(i);

                // Update the maximum number of divisors and the corresponding number
                if (divisors > maxD)
                {
                    maxD = divisors;
                    numMaxD = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{2} is  the one of number that has highest number of divisors in the range {0}-{1}", start, end, numMaxD);
            Console.WriteLine("It has {0} divisors", maxD);
        }
    }
}
