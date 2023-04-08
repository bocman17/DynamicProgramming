using DynamicProgramming;
using DynamicProgramming.Memoization;
using DynamicProgramming.Tabulation;
using System.Diagnostics;

Stopwatch watchFibMemo = Stopwatch.StartNew();
Console.WriteLine(Fibonacci_Memo.FibMemo(50)); // 12586269025
watchFibMemo.Stop();
Console.WriteLine("Time elapsed: {0}", watchFibMemo.ElapsedTicks);

Console.WriteLine("*************** Fibonacci ***************");
Stopwatch watchFibTab = Stopwatch.StartNew();
Console.WriteLine(Fibonacci_Tabulation.FibTab(50));
watchFibTab.Stop();
Console.WriteLine("Time elapsed: {0}", watchFibTab.ElapsedTicks);

Console.WriteLine("*************** Grid Traveler ***************");
Stopwatch watchGridTravMemo = Stopwatch.StartNew();
Console.WriteLine("\n" + GridTraveler_Memo.GridTravMemo(18, 18)); // 2333606220
watchGridTravMemo.Stop();
Console.WriteLine("Time elapsed: {0}", watchGridTravMemo.ElapsedTicks);

Stopwatch watchGridTravTab = Stopwatch.StartNew();
Console.WriteLine("\n" + GridTraveler_Tabulation.GridTravTab(18, 18)); // 2333606220
watchGridTravTab.Stop();
Console.WriteLine("Time elapsed: {0}", watchGridTravTab.ElapsedTicks);

Console.WriteLine("*************** Can Sum ***************");
Stopwatch watchCanSum = Stopwatch.StartNew();
Console.WriteLine(Sum_Memo.CanSumMemo(300, new int[] { 7, 14 }));
watchCanSum.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchCanSum.ElapsedTicks);

Stopwatch watchCanSumTab = Stopwatch.StartNew();
Console.WriteLine(Sum_Tabulation.CanSumTab(300, new int[] { 7, 14 }));
watchCanSumTab.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchCanSumTab.ElapsedTicks);


//var result = Sum.HowSum(7, new int[] { 2, 3}); // [3,2,2]
//var result = Sum.HowSum(7, new int[] { 5, 3, 4, 7 }); // [4,3]
//var result = Sum.HowSum(7, new int[] { 2, 4 }); // null
//var result = Sum.HowSum(8, new int[] { 2, 3, 5 }); // [2,2,2,2]

Console.WriteLine("*************** How Sum ***************");
Stopwatch watchHowSum = Stopwatch.StartNew();
var result = Sum_Memo.HowSumMemo(300, new int[] { 7, 14 }); // null
watchHowSum.Stop();

if (result is not null)
{
    Console.WriteLine("[" + string.Join(",", result) + "]");
}
else
{
    Console.WriteLine("result is null");
}

Console.WriteLine("Time elapsed: {0}\n", watchHowSum.ElapsedTicks);

Stopwatch watchHowSumTab = Stopwatch.StartNew();
var resultTab = Sum_Tabulation.HowSumTab(300, new int[] { 7, 14 }); // null
//var resultTab = Sum_Tabulation.HowSumTab(8, new int[] { 2, 3, 5 }); // [2,2,2,2]

watchHowSumTab.Stop();

if (resultTab is not null)
{
    Console.WriteLine("[" + string.Join(",", resultTab) + "]");
}
else
{
    Console.WriteLine("result is null");
}

Console.WriteLine("Time elapsed: {0}\n", watchHowSumTab.ElapsedTicks);

Console.WriteLine("********************BEST SUM******************");
//var resultBestSum = Sum.BestSum(7, new int[] { 5, 3, 4, 7 }); //[7]
//if (resultBestSum is not null)
//{
//    Console.WriteLine("\n[" + string.Join(",", resultBestSum) + "]");
//}
//else
//{
//    Console.WriteLine("result is null");
//}

//resultBestSum = Sum.BestSum(8, new int[] { 2, 3, 5 }); //[3,5]
//if (resultBestSum is not null)
//{
//    Console.WriteLine("[" + string.Join(",", resultBestSum) + "]");
//}
//else
//{
//    Console.WriteLine("result is null");
//}

//resultBestSum = Sum.BestSum(8, new int[] { 1, 4, 5 }); // [4,4]
//if (resultBestSum is not null)
//{
//    Console.WriteLine("[" + string.Join(",", resultBestSum) + "]");
//}
//else
//{
//    Console.WriteLine("result is null");
//}

Stopwatch watchBestSum = Stopwatch.StartNew();
var resultBestSum = Sum_Memo.BestSumMemo(100, new int[] { 1, 2, 5, 25 }); // [25, 25, 25, 25]
if (resultBestSum is not null)
{
    Console.WriteLine("[" + string.Join(",", resultBestSum) + "]");
}
else
{
    Console.WriteLine("result is null");
}
watchBestSum.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchBestSum.ElapsedTicks);

Stopwatch watchBestSumTab = Stopwatch.StartNew();
var resultBestSumTab = Sum_Tabulation.BestSumTab(8, new int[] { 1, 4,5 }); // [25, 25, 25, 25]
if (resultBestSumTab is not null)
{
    Console.WriteLine("[" + string.Join(",", resultBestSumTab) + "]");
}
else
{
    Console.WriteLine("result is null");
}
watchBestSumTab.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchBestSumTab.ElapsedTicks);

Console.WriteLine("*************** Can Construct ***************");

Console.WriteLine(Construct_Memo.CanConstructMemo("abcdef",
    new string[] { "ab", "abc", "cd", "def", "abcd" })); //true

Console.WriteLine("tabulation " + Construct_Tabulation.CanConstructTab("abcdef",
    new string[] { "ab", "abc", "cd", "def", "abcd" })); //true

Console.WriteLine(Construct_Memo.CanConstructMemo("skateboard",
    new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); //false

Console.WriteLine("tabulation " + Construct_Tabulation.CanConstructTab("skateboard",
    new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); //false

Console.WriteLine(Construct_Memo.CanConstructMemo("enterapotentpot",
    new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); //true

Console.WriteLine("tabulation " + Construct_Tabulation.CanConstructTab("enterapotentpot",
    new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); //true

Stopwatch watchCanConstruct = Stopwatch.StartNew();
Console.WriteLine(Construct_Memo.CanConstructMemo("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
    new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); //false
watchCanConstruct.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchCanConstruct.ElapsedTicks);

Stopwatch watchCanConstructTab = Stopwatch.StartNew();
Console.WriteLine("tabulation " + Construct_Tabulation.CanConstructTab("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
    new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); //false
watchCanConstructTab.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchCanConstructTab.ElapsedTicks);

Console.WriteLine("*************** Count Construct ***************");

Console.WriteLine(Construct_Memo.CountConstructMemo("purple",
    new string[] { "purp", "p", "ur", "le", "purpl" })); // 2

Console.WriteLine("Tabulation " + Construct_Tabulation.CountConstructTab("purple",
    new string[] { "purp", "p", "ur", "le", "purpl" })); // 2

Console.WriteLine(Construct_Memo.CountConstructMemo("abcdef",
    new string[] { "ab", "abc", "cd", "def", "abcd" })); // 1

Console.WriteLine("Tabulation " + Construct_Tabulation.CountConstructTab("abcdef",
    new string[] { "ab", "abc", "cd", "def", "abcd" })); // 1

Console.WriteLine(Construct_Memo.CountConstructMemo("skateboard",
    new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // 0

Console.WriteLine("Tabulation " + Construct_Tabulation.CountConstructTab("skateboard",
    new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // 0

Console.WriteLine(Construct_Memo.CountConstructMemo("enterapotentpot",
    new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); // 4

Console.WriteLine("Tabulation " + Construct_Tabulation.CountConstructTab("enterapotentpot",
    new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); // 4

Stopwatch watchCountConstruct = Stopwatch.StartNew();
Console.WriteLine(Construct_Memo.CountConstructMemo("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
    new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); // 0
watchCanConstruct.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchCountConstruct.ElapsedTicks);

Stopwatch watchCountConstructTab = Stopwatch.StartNew();
Console.WriteLine("Tabulation " + Construct_Tabulation.CountConstructTab("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
    new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); // 0
watchCountConstructTab.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchCountConstructTab.ElapsedTicks);

Console.WriteLine("*************** All Construct ***************");

Console.WriteLine();
var allConstructResult = Construct_Memo.AllConstructMemo("purple",
    new string[] { "purp", "p", "ur", "le", "purpl" });

foreach (List<string> way in allConstructResult)
{
    Console.WriteLine("[" + string.Join(",", way) + "]"); // [["purp","le"],["p","ur","p","le"]]
}

List<List<string>> allConstructResultTab = Construct_Tabulation.AllConstructTab("purple",
    new string[] { "purp", "p", "ur", "le", "purpl" });

foreach (List<string> way in allConstructResultTab)
{
    Console.WriteLine("[ " + string.Join(", ", way) + " ]");
}

allConstructResult = Construct_Memo.AllConstructMemo("abcdef",
    new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" });

Console.WriteLine();
foreach (List<string> way in allConstructResult)
{
    Console.WriteLine("[" + string.Join(",", way) + "]"); // [
                                                          // ["ab", "cd", "ef"],
                                                          // ["ab","c","def"],
                                                          // ["abc", "def"],
                                                          // ["abcd", "ef"]
                                                          // ]
}

allConstructResultTab = Construct_Tabulation.AllConstructTab("abcdef",
    new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" });

Console.WriteLine();
if (allConstructResultTab is not null && allConstructResultTab.Count > 0)
{
    foreach (var item in allConstructResultTab)
    {
        Console.WriteLine("Tabulation [" + string.Join(",", item) + "]");
    }
}
else Console.WriteLine("[]");

allConstructResult = Construct_Memo.AllConstructMemo("skateboard",
    new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });

Console.WriteLine();
foreach (List<string> way in allConstructResult)
{
    Console.WriteLine("[" + string.Join(",", way) + "]"); // []
}

allConstructResultTab = Construct_Tabulation.AllConstructTab("skateboard",
    new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });

Console.WriteLine();
if (allConstructResultTab is not null && allConstructResultTab.Count > 0)
{
    foreach (var item in allConstructResultTab)
    {
        Console.WriteLine("Tabulation [" + string.Join(",", item) + "]");
    }
}
else Console.WriteLine("Tabulation []");

allConstructResult = Construct_Memo.AllConstructMemo("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaz",
    new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });

Console.WriteLine();
Stopwatch watchAllConstruct = Stopwatch.StartNew();
foreach (List<string> way in allConstructResult)
{
    Console.WriteLine("[" + string.Join(",", way) + "]"); // []
}
watchAllConstruct.Stop();
Console.WriteLine("Time elapsed: {0}\n", watchAllConstruct.ElapsedTicks);

allConstructResultTab = Construct_Tabulation.AllConstructTab("aaaaaaaaaaaz",
    new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });

Console.WriteLine();
if (allConstructResultTab is not null && allConstructResultTab.Count > 0)
{
    foreach (var item in allConstructResultTab)
    {
        Console.WriteLine("Tabulation [" + string.Join(",", item) + "]"); // []
    }
}
else Console.WriteLine("Tabulation []");

