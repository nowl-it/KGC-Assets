using System.Collections.Generic;

namespace SRDebugger.Services
{
	public class BugReport
	{
		public List<ConsoleEntry> ConsoleLog;

		public string Email;

		public byte[] ScreenshotData;

		public Dictionary<string, Dictionary<string, object>> SystemInformation;

		public string UserDescription;
	}
}
