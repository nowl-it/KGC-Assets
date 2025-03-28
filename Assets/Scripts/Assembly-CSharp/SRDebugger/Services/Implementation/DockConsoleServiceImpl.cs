using SRDebugger.UI.Other;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDockConsoleService))]
	public class DockConsoleServiceImpl : IDockConsoleService
	{
		private ConsoleAlignment _alignment;

		private DockConsoleController _consoleRoot;

		private bool _didSuspendTrigger;

		private bool _isExpanded;

		private bool _isVisible;

		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ConsoleAlignment Alignment
		{
			get
			{
				return default(ConsoleAlignment);
			}
			set
			{
			}
		}

		private void Load()
		{
		}

		private void CheckTrigger()
		{
		}
	}
}
