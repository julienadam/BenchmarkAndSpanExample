using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using NFluent;

namespace BenchmarkAndSpanExample
{
    [RankColumn]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class NameParserBenchmarks
    {
        private const string FullName = "John Ronald Reuel Tolkien";

        [Benchmark(Baseline = true)]
        public void GetLastName()
        {
            NameParser.GetLastName(FullName);
        }

        [Benchmark]
        public void GetLastNameUsingSubstring()
        {
            NameParser.GetLastNameUsingSubstring(FullName);
        }
    }
}
