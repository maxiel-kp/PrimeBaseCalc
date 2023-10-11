using System;
using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();
        decimal a = (decimal)Math.PI;
        decimal b = (decimal)Math.E;
        decimal ab57 = a * b * 5 * 7*9;
        sw.Stop();
        Console.WriteLine(ab57);
        Console.WriteLine(sw.ElapsedTicks);

        //sw.Reset();
        Stopwatch stopwatch = Stopwatch.StartNew();
        double c = Math.PI;
        double d = Math.E;
        double cd57 = c * d * 5 * 7*9;
        stopwatch.Stop();
        Console.WriteLine(cd57);
        Console.WriteLine(stopwatch.ElapsedTicks);
    }
}

/*internal class Program
{
    private static void Main(string[] args)
    {
        //var summary = BenchmarkRunner.Run<MathBenchmark>();
        //Console.WriteLine(summary);
        int limit = 100; // Change the limit as needed
        IEnumerable<int> primeSequence = PrimeCompareInt.GetPrimes(limit);
        IEnumerable<int> integerSequence = PrimeCompareInt.GetIntegers(limit);
        var commonNumbers = primeSequence.Intersect(integerSequence);

        Console.WriteLine("Prime Numbers: " + string.Join(", ", primeSequence));
        Console.WriteLine("Integer Numbers: " + string.Join(", ", integerSequence));

        Console.WriteLine("Common Numbers: " + string.Join(", ", commonNumbers));

    }
}*/

public class PrimeCompareInt
{
    public static IEnumerable<int> GetPrimes(int n)
    {
        if (n < 2) yield break;

        List<int> primes = new List<int> { 2 };
        yield return 2;

        for (int i = 3; i <= n; i += 2)
        {
            if (primes.All(p => i % p != 0))
            {
                primes.Add(i);
                yield return i;
            }
        }
    }

    public static IEnumerable<int> GetIntegers(int n)
    {
        return Enumerable.Range(1, n);
    }
}
