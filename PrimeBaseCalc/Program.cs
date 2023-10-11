class Program
{
    private static void Main(string[] args)
    {
        //var summary = BenchmarkRunner.Run<MathBenchmark>();
        //Console.WriteLine(summary);
        int limit = 100; // Change the limit as needed
        //IEnumerable<int> primeSequence = PrimeCompareInt.GetPrimes(limit);
        //IEnumerable<int> integerSequence = PrimeCompareInt.GetIntegers(limit);
        //var commonNumbers = primeSequence.Intersect(integerSequence);

        //Console.WriteLine("Prime Numbers: " + string.Join(", ", primeSequence));
        //Console.WriteLine("Integer Numbers: " + string.Join(", ", integerSequence));

        //Console.WriteLine("Common Numbers: " + string.Join(", ", commonNumbers));
        var t1 = new CustomNumber<string>("max");
        //var t2 = new CustomNumber<int>(10);
        var t2 = new CustomNumber<decimal>(9.87m);
        Console.WriteLine(t1 <= t2);

    }
}

public class CustomNumber<T>(T generic)
{
    public T Value { get; } = generic;

    public static string operator <=(CustomNumber<T> a, CustomNumber<T> b)
    {
        return $"<p>Hello, world.{a.Value} and {b.Value}</p>";
    }

    public static string operator <=(CustomNumber<string> a, CustomNumber<T> b)
    {
        return $"<p>Hello, world.{a.Value} and {b.Value}</p>";
    }

    //
    public static string operator >=(CustomNumber<string> a, CustomNumber<T> b) => "";
    public static string operator >=(CustomNumber<T> a, CustomNumber<T> b) => "";
}
