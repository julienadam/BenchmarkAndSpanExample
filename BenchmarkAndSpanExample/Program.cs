using BenchmarkDotNet.Running;
using NFluent;

namespace BenchmarkAndSpanExample
{
    public class Program
    {
        public static void Main()
        {
            // Validation des résultats
            Check.That(NameParser.GetLastName("John Smith")).IsEqualTo("Smith");
            Check.That(NameParser.GetLastNameUsingSubstring("John Smith")).IsEqualTo("Smith");

            // Exécution du benchmark
            BenchmarkRunner.Run<NameParserBenchmarks>();
        }
    }
}
