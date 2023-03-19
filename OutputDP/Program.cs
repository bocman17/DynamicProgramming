using DynamicProgramming;
using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();
Console.WriteLine(Fibonacci.Fib(50));
stopwatch.Stop();
Console.WriteLine("\nTime elapsed: {0}", stopwatch.ElapsedTicks);
