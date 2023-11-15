```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i5-4440S CPU 2.80GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
| Method    | Mean      | Error     | StdDev    | Median    |
|---------- |----------:|----------:|----------:|----------:|
| TestAny   | 4.1946 ns | 0.1240 ns | 0.1568 ns | 4.1896 ns |
| TestCount | 0.0349 ns | 0.0288 ns | 0.0457 ns | 0.0022 ns |
