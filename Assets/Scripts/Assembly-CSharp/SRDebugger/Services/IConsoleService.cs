namespace SRDebugger.Services
{
	public interface IConsoleService
	{
		int ErrorCount { get; }

		int WarningCount { get; }

		int InfoCount { get; }

		IReadOnlyList<ConsoleEntry> Entries { get; }

		IReadOnlyList<ConsoleEntry> AllEntries { get; }

		event ConsoleUpdatedEventHandler Updated;

		void Clear();
	}
}
