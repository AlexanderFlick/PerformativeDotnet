using BenchmarkDotNet.Running;
using System;

namespace PerformativeDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParserBenchmark>();
        }
    }
}
