using System.Collections.Concurrent;
using System.Diagnostics;

Console.Write("Enter the start of the range: ");
int start = Int32.Parse(Console.ReadLine());

Console.Write("Enter the end of the range: ");
int end = Int32.Parse(Console.ReadLine());

Console.Write("Enter the number of threads to use: ");
int numOfThreads = Int32.Parse(Console.ReadLine());

List<int> primes = new List<int>();
object lockObject = new object();
Stopwatch stopwatch = Stopwatch.StartNew();

Parallel.ForEach(
    Partitioner.Create(start, end + 1, (end - start) / numOfThreads),
    new ParallelOptions { MaxDegreeOfParallelism = numOfThreads },
    range =>
    {
        List<int> localPrimes = new List<int>();
        for (int i = range.Item1; i < range.Item2; i++)
        {
            if (IsPrime(i))
            {
                localPrimes.Add(i);
            }
        }

        lock (lockObject)
        {
            primes.AddRange(localPrimes);
        }
    }
);

stopwatch.Stop();

Console.WriteLine("Prime numbers in the range:");
primes.Sort();
Console.WriteLine(string.Join(", ", primes));
Console.WriteLine($"Time needed to find the prime numbers: {stopwatch.ElapsedMilliseconds} ms");
    

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;
    int boundary = (int)Math.Sqrt(number);

    for (int i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0) return false;
    }
    return true;
}