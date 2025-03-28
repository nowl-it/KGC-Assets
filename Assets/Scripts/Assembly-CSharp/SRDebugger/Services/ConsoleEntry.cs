using UnityEngine;

namespace SRDebugger.Services
{
	public class ConsoleEntry
	{
		private const int MessagePreviewLength = 180;

		private const int StackTracePreviewLength = 120;

		private string _messagePreview;

		private string _stackTracePreview;

		public int Count;

		public LogType LogType;

		public string Message;

		public string StackTrace;

		public string MessagePreview => null;

		public string StackTracePreview => null;

		public ConsoleEntry()
		{
		}

		public ConsoleEntry(ConsoleEntry other)
		{
		}

		public bool Matches(ConsoleEntry other)
		{
			return false;
		}
	}
}
