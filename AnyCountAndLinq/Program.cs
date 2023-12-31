﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

class Program
{
	static void Main(string[] args)
	{
		BenchmarkRunner.Run<Bench>();
	}
}

public class ToTest
{
	public List<Guid> List { get; } =
		new List<Guid>(Enumerable.Range(0, 10000).Select(x => Guid.NewGuid()));
}

public class Bench
{
	public static readonly ToTest ToTest = new ToTest();

	[Benchmark]
	public bool TestAny() => ToTest.List.Any();

	[Benchmark]
	public bool TestCount() => ToTest.List.Count > 0;
}