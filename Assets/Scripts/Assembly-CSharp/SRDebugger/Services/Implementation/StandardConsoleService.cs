using System.Runtime.CompilerServices;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IConsoleService))]
	public class StandardConsoleService : IConsoleService
	{
		private readonly bool _collapseEnabled;

		private bool _hasCleared;

		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries;

		private CircularBuffer<ConsoleEntry> _consoleEntries;

		private readonly object _threadLock;

		public int ErrorCount { get; private set; }

		public int WarningCount { get; private set; }

		public int InfoCount { get; private set; }

		public IReadOnlyList<ConsoleEntry> Entries => null;

		public IReadOnlyList<ConsoleEntry> AllEntries => null;

		public event ConsoleUpdatedEventHandler Updated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Clear()
		{
		}

		protected void OnEntryAdded(ConsoleEntry entry)
		{
		}

		protected void OnEntryDuplicated(ConsoleEntry entry)
		{
		}

		private void OnUpdated()
		{
		}

		private void UnityLogCallback(string condition, string stackTrace, LogType type)
		{
		}

		private void AdjustCounter(LogType type, int amount)
		{
		}
	}
}
