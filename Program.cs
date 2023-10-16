//============================================================================================================= 
//HW1 Code 
using System; 
using System.Diagnostics;
class Program
{
    static void Main()
    {
        int n = 800000; // number of random numbers to generate
        double[] doubleNumbers;
        float[] floatNumbers;

        // Generate random numbers for doubles
        doubleNumbers = GenRandomDoubles(n);

        // Convert doubles to floats
        floatNumbers = ConvertDoublesToFloats(doubleNumbers);

        Stopwatch timer = new Stopwatch();

        // Measure time to add doubles
        timer.Start();
        double doubleSum = AddDoubles(doubleNumbers);
        timer.Stop();
        Console.WriteLine("Addition of Doubles");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        float doubleAddTicks = (float)timer.ElapsedTicks;

        // Measure time to add floats
        timer.Restart();
        float floatSum = AddFloats(floatNumbers);
        timer.Stop();
        Console.WriteLine("Addition of Floats");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        float floatAddTicks = (float)timer.ElapsedTicks;

        Console.WriteLine("Ratio (Doubles/Floats) = " + doubleAddTicks / floatAddTicks);
    }

    static double[] GenRandomDoubles(int count)
    {
        Random rand = new Random();
        double[] nums = new double[count];
        for (int i = 0; i < count; ++i)
        {
            nums[i] = 10000.0 * rand.NextDouble();
        }
        return nums;
    }

    static float[] ConvertDoublesToFloats(double[] doubles)
    {
        float[] floats = new float[doubles.Length];
        for (int i = 0; i < doubles.Length; ++i)
        {
            floats[i] = (float)doubles[i];
        }
        return floats;
    }

    static double AddDoubles(double[] nums)
    {
        double sum = 0.0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        return sum;
    }

    static float AddFloats(float[] nums)
    {
        float sum = 0.0f;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        return sum;
    }
}