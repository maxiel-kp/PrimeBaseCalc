class Program
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
}

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
