class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(GetValue());

		Task<int> GetValue()
		{
			return Task.FromResult(1);
		}

	}

}
