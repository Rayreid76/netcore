using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop from 1 to 255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************");

            //for loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("*********************");

            // For loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("*********************");

            // 10 random values and output the respective word
            Random rand = new Random();
            for (int val = 0; val < 10; val++)
            {
                if (val % 5 == 0 && val % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (val % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (val % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(val);
                }
            }
            Console.WriteLine("*********************");
        }
        
    }
}
