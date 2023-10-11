using static System.Runtime.InteropServices.JavaScript.JSType;

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
        CustomPTag<int> t = new CustomPTag<int>("Maxiel", 42);
        //Console.WriteLine(t.Name <= t);

        var num = 5;
        Console.WriteLine(num);
        Console.WriteLine(Convert.ToString(num, 2));
        Console.WriteLine("binary");
        num = num << 1;//x2
        Console.WriteLine(Convert.ToString(num, 2));
        Console.WriteLine(num);
        //num = num +1 ;//+1
        //Console.WriteLine(Convert.ToString(num, 2));
        //Console.WriteLine(num);

    }
}

public class CustomPTag<T>
{
    //property
    public string Name { get; }
    public T Value { get; }

    //constructor
    public CustomPTag(string name, T value)
    {
        Name = name;
        Value = value;
    }

    //method
    public static string operator <=(CustomPTag<T> a, CustomPTag<T> b)
    {
        return $"<p>Hello, world.{a.Name} and {b.Value}</p>";
    }

    public static string operator <=(string a, CustomPTag<T> b)
    {
        return $"<p>Hello, world.{a} and {b.Value}</p>";
    }


    //
    public static string operator >=(CustomPTag<T> a, CustomPTag<T> b) => "";
    public static string operator >=(string a, CustomPTag<T> b) => "";
}