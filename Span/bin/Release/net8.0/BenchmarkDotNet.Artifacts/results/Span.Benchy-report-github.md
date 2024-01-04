```

BenchmarkDotNet v0.13.11, Windows 10 (10.0.19045.3803/22H2/2022Update)
Intel Core i5-4440S CPU 2.80GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method                     | Mean     | Error    | StdDev   | Gen0   | Allocated |
|--------------------------- |---------:|---------:|---------:|-------:|----------:|
| DateWithStringAndSubstring | 55.77 ns | 0.501 ns | 0.391 ns | 0.0305 |      96 B |
| DateWithStrinAdnSpan       | 34.39 ns | 0.715 ns | 0.669 ns |      - |         - |
