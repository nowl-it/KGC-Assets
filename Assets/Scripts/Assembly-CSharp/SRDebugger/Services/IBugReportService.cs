namespace SRDebugger.Services
{
	public interface IBugReportService
	{
		void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, BugReportProgressCallback progressCallback = null);
	}
}
