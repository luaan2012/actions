using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Span;

class Program
{

    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchy>();
    }

    
}

[MemoryDiagnoser]
public class Benchy
{
    private static readonly string _dataAsText = "08 07 2021";

    [Benchmark]
    public (int day, int month, int year) DateWithStringAndSubstring()
    {
        var dayAsText = _dataAsText.Substring(0, 2);
        var monthAsText = _dataAsText.Substring(3, 2);
        var yearAsText = _dataAsText.Substring(6);
        var day = int.Parse(dayAsText);
        var month = int.Parse(monthAsText);
        var year = int.Parse(yearAsText);

        return (day, month, year);
    }
    
    [Benchmark]
    public (int day, int month, int year) DateWithStrinAdnSpan()
    {
        ReadOnlySpan<char> dateAsSpan = _dataAsText;

        var dayAsText = dateAsSpan.Slice(0, 2);
        var monthAsText = dateAsSpan.Slice(3, 2);
        var yearAsText = dateAsSpan.Slice(6);
        var day = int.Parse(dayAsText);
        var month = int.Parse(monthAsText);
        var year = int.Parse(yearAsText);

        return (day, month, year);
    }
}