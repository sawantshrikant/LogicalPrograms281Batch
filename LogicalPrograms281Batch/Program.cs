using System;
using LogicalPrograms281Batch;
using LogicalPrograms281Batch_;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Programming Practice Problem!");
        bool flag = true;
        while (flag)
        {
            Console.Write("1. Fibonacci\n2. Perfect Number\n3. Exit\nEnter your option to execute: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fib = new FibonacciSeries();
                    Console.Write("Enter the number for Fibonacci Series: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    fib.PrintFibonacciSeries(num);
                    break;
                case 2:
                    PerfectNumber perf = new PerfectNumber();
                    Console.Write("Enter a number to check if it's a perfect number: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                   bool IsPerfect = perf.IsPerfectNumber(input);
                    if (IsPerfect)
                    {
                        Console.WriteLine(input + " is a perfect number.");
                    }
                    else
                    {
                        Console.WriteLine(input + " is not a perfect number.");
                    }
                    break;
                case 3:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
