
class Program
{
	static async Task Main()
	{
		await SomeMethodThatAcceptsDelegate2(async () =>
		{
			await Task.Delay(1000);
			Console.WriteLine("Test");
		});
	}

	private static async Task SomeMethodThatAcceptsDelegate(Action content)
	{
		await Task.Delay(1);

		content();
	}
	private static async Task SomeMethodThatAcceptsDelegate2(Func<Task> content)
	{
		await Task.Delay(1);

		await content();
	}
}