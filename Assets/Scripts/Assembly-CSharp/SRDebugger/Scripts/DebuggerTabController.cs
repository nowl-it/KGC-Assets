using SRDebugger.UI.Other;
using SRF;

namespace SRDebugger.Scripts
{
	public class DebuggerTabController : SRMonoBehaviourEx
	{
		private SRTab _aboutTabInstance;

		private DefaultTabs? _activeTab;

		private bool _hasStarted;

		public SRTab AboutTab;

		[RequiredField]
		public SRTabController TabController;

		public DefaultTabs? ActiveTab => null;

		protected override void Start()
		{
		}

		public bool OpenTab(DefaultTabs tab)
		{
			return false;
		}

		public void ShowAboutTab()
		{
		}
	}
}
