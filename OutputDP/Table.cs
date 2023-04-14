using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputDP
{
    public static class Table
    {
        public static void MakeTable(string Title, string[] ProblemName, int[] input, Func<int, long>[] methods)
        {
            Title = Title.ToUpper();
            const int Width = 20;
            int ScreenWidth = Console.WindowWidth;
            int leftMargin = (ScreenWidth / 2) - (Width / 2);
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(Title);

            var data = new List<(string[], int[], Func<int, long>[])>()
            {
                (ProblemName, input, methods)
            };
            Console.SetCursorPosition(leftMargin / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0, -20}", "Type");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0, -20}", "Input");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0, -20}", "Result");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0, -20}", "Elapsed Ticks");
            Console.ResetColor();
            Console.SetCursorPosition(leftMargin / 2, Console.CursorTop);
            Console.WriteLine(new string('-', 74));

            long[] elapsedTicks = new long[methods.Length];
            long[] results = new long[methods.Length];
            for (int i = 0; i < elapsedTicks.Length; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var result = methods[i](input[i]);
                sw.Stop();
                elapsedTicks[i] = sw.ElapsedTicks;
                results[i] = result;
            }

            foreach (var row in data)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.SetCursorPosition(leftMargin / 2, Console.CursorTop);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0,-20}", row.Item1[i]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,-20}", row.Item2[i]);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("{0,-20:N0}", results[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0,-20:N0}", elapsedTicks[i]);
                    Console.ResetColor();
                }
            }
        }

        public static void MakeTable(string Title, string[] ProblemName, (int, int)[] input, Func<int,int, long>[] methods)
        {
            Title = Title.ToUpper();
            const int Width = 20;
            int ScreenWidth = Console.WindowWidth;
            int leftMargin = (ScreenWidth / 2) - (Width / 2);
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(Title);

            var data = new List<(string[], (int, int)[], Func<int, int,long>[])>()
            {
                (ProblemName, input, methods)
            };
            Console.SetCursorPosition(leftMargin / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0, -20}", "Type");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0, -20}", "Input");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0, -20}", "Result");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0, -20}", "Elapsed Ticks");
            Console.ResetColor();
            Console.SetCursorPosition(leftMargin / 2, Console.CursorTop);
            Console.WriteLine(new string('-', 74));

            long[] elapsedTicks = new long[methods.Length];
            long[] results = new long[methods.Length];
            for (int i = 0; i < elapsedTicks.Length; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var result = methods[i](input[i].Item1, input[i].Item2);
                sw.Stop();
                elapsedTicks[i] = sw.ElapsedTicks;
                results[i] = result;
            }

            foreach (var row in data)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.SetCursorPosition(leftMargin / 2, Console.CursorTop);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0,-20}", row.Item1[i]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,-20}", row.Item2[i].Item1 + ", " + row.Item2[i].Item2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("{0,-20:N0}", results[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0,-20:N0}", elapsedTicks[i]);
                    Console.ResetColor();
                }
            }
        }
    }
}
