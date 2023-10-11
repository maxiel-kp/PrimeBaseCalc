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
