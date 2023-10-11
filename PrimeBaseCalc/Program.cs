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

public class CustomNumber
{
    public decimal Decimal { get; }

    public CustomNumber(decimal value)
    {
        Decimal = value;
    }

    public static CustomNumber operator +(CustomNumber a, CustomNumber b)
    {
        return new CustomNumber(a.Decimal + b.Decimal);
    }
    public override string ToString()
    {
        return Decimal.ToString();
    }
}
