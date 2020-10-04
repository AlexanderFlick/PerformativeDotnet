using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PerformativeDotnet
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmark
    {
        private const string DateTime = "2020-10-10T12:00:00Z";
        private static readonly DateParser Parser = new DateParser();

        [Benchmark]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTime);
        }
    }
}
