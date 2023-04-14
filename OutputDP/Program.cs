using ConsoleTables;
using DynamicProgramming.BruteForce;
using DynamicProgramming.Memoization;
using DynamicProgramming.Tabulation;
using OutputDP;
using System.Diagnostics;

Func<int, long>[] Fibfunctions = { Fibonacci.Fib, Fibonacci_Memo.FibMemo, Fibonacci_Tabulation.FibTab };
Func<int, int, long>[] Gridfunctions = { GridTraveler.GridTrav, GridTraveler_Memo.GridTravMemo, GridTraveler_Tabulation.GridTravTab };


Table.MakeTable("Fibonacci", new string[] {"Brute Force", "Memoziation", "Tabulation"}, new int[] {30,50,50}, Fibfunctions);
Table.MakeTable("Grid Traveler", new string[] { "Brute Force", "Memoziation", "Tabulation" }, new[] { (13,13), (18,18), (18,18) }, Gridfunctions);





