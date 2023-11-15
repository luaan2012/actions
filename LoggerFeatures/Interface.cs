using Microsoft.Extensions.Logging;

namespace LoggerFeatures
{
	public interface ILogger
	{
		void Log(LogLevel level, string message);
	}

	public class ConsoleLogger : ILogger
	{
		public void Log(LogLevel level, string message)
		{
			Console.ForegroundColor = level switch
			{
				LogLevel.Debug => ConsoleColor.Cyan,
				LogLevel.Information => ConsoleColor.Cyan,
				LogLevel.Warning => ConsoleColor.White,
				LogLevel.Error => ConsoleColor.Red,
				_ => throw new ArgumentOutOfRangeException(nameof(level), level, null)
			};

			Console.WriteLine(message);
			Console.ResetColor();
		}		
	}

	public static class LoggerExtensions
	{
		public static void Log(this ILogger logger, Exception ex)
		{
			logger.Log(LogLevel.Error, ex.ToString());
		}
	}
}
