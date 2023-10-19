//============================================================================================================= 
//HW1 Code 
//Group B Problem 3 

using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 800000; // number of random numbers to generate
        double[] numbers;
        Stopwatch timer = new Stopwatch();

        // Generate random numbers
        numbers = GenRandomDoubles(n);

        // Measure time to Square with Multiplication
        timer.Start();
        ComputeSquareViaMultiplication(numbers, n);
        timer.Stop();
        Console.WriteLine("Squaring with Multiplication");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        float multTicks = (float)timer.ElapsedTicks;

        // Measure time to square with Math.Pow
        timer.Restart();
        ComputeSquareViaMathPow(numbers, n);
        timer.Stop();
        Console.WriteLine("Squaring with Math.Pow");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        float powTicks = (float)timer.ElapsedTicks;

        // Measure time to square with Math.Sqrt
        timer.Restart();
        ComputeSquareRootViaMathSqrt(numbers, n);
        timer.Stop();
        Console.WriteLine("Squaring with Math.Sqrt");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        float sqrtTicks = (float)timer.ElapsedTicks;

        Console.WriteLine("Multiplication vs. Math.Pow: " + multTicks / powTicks);
        Console.WriteLine("Multiplication vs. Math.Sqrt: " + multTicks / sqrtTicks);
    }

    static double[] GenRandomDoubles(int count)
    {
        Random rand = new Random();
        double[] numbers = new double[count];
        for (int i = 0; i < count; ++i)
        {
            numbers[i] = 10000.0 * rand.NextDouble();
        }
        return numbers;
    }

    static void ComputeSquareViaMultiplication(double[] numbers, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            numbers[i] = numbers[i] * numbers[i];
        }
    }

    static void ComputeSquareViaMathPow(double[] numbers, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            numbers[i] = Math.Pow(numbers[i], 2);
        }
    }

    static void ComputeSquareRootViaMathSqrt(double[] numbers, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            numbers[i] = Math.Sqrt(numbers[i]);
        }
    }
}