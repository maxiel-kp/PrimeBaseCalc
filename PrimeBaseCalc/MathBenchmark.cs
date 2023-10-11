using BenchmarkDotNet.Attributes;

public class MathBenchmark
{
    private readonly double doubleValue = 3.14159265358979323846;
    private readonly decimal decimalValue = 3.14159265358979323846M;
    readonly double doublePi = Math.PI;


    [Benchmark]
    public double DoubleComputation() => doubleValue * doubleValue;

    [Benchmark]
    public decimal DecimalComputation() => decimalValue * decimalValue;

    [Benchmark]
    public double DoublePiComputation() => doublePi * doublePi;

    [Benchmark]
    public decimal DecimalPiComputation() => (decimal)doublePi * (decimal)doublePi;
}