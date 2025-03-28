using SRDebugger.Internal;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IBugReportService))]
	public class BugReportApiService : SRServiceBase<IBugReportService>, IBugReportService
	{
		public const float Timeout = 12f;

		private BugReportCompleteCallback _completeCallback;

		private string _errorMessage;

		private bool _isBusy;

		private float _previousProgress;

		private BugReportProgressCallback _progressCallback;

		private BugReportApi _reportApi;

		public void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, BugReportProgressCallback progressCallback = null)
		{
		}

		protected override void Awake()
		{
		}

		private void OnProgress(float progress)
		{
		}

		private void OnComplete()
		{
		}

		protected override void Update()
		{
		}
	}
}
