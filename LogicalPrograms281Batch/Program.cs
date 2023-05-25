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
            Console.Write("1. Fibonacci\n2. Perfect Number\n3. Prime Number\n4. Reverse A Number \n5. Exit\nEnter your option to execute: ");
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
                    PrimeNumber prime = new PrimeNumber();
                    Console.WriteLine("Enter a Number to check if it's Prime Number: ");
                    int primeinput = Convert.ToInt32(Console.ReadLine());
                    bool Isprime = prime.IsPrimeNumber(primeinput);
                    if (Isprime)
                    {
                        Console.WriteLine(primeinput +" is a Prime Number");
                    }
                    else
                    {
                        Console.WriteLine(primeinput + " is not a Prime Number");
                    }
                    break;
                case 4:
                    ReverseANumber reverse = new ReverseANumber();
                    Console.WriteLine("Enter a Number to Reverse A Number:");
                    int Reverseinput = Convert.ToInt32(Console.ReadLine());
                    int ReversedNumber = reverse.ReverseNumber(Reverseinput);
                    Console.WriteLine("Reversed Number :" + ReversedNumber);
                    break;

                case 5:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
