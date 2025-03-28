using System.Runtime.CompilerServices;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDebugService))]
	public class SRDebugService : IDebugService
	{
		private readonly IDebugPanelService _debugPanelService;

		private readonly IDebugTriggerService _debugTrigger;

		private readonly ISystemInformationService _informationService;

		private readonly IOptionsService _optionsService;

		private readonly IPinnedUIService _pinnedUiService;

		private bool _entryCodeEnabled;

		private bool _hasAuthorised;

		private DefaultTabs? _queuedTab;

		private RectTransform _worldSpaceTransform;

		public Settings Settings => null;

		public bool IsDebugPanelVisible => false;

		public bool IsTriggerEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsProfilerDocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IDockConsoleService DockConsole => null;

		public event VisibilityChangedDelegate PanelVisibilityChanged
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

		public void AddSystemInfo(InfoEntry entry, string category = "Default")
		{
		}

		public void ShowDebugPanel(bool requireEntryCode = true)
		{
		}

		public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true)
		{
		}

		public void HideDebugPanel()
		{
		}

		public void DestroyDebugPanel()
		{
		}

		public void AddOptionContainer(object container)
		{
		}

		public void RemoveOptionContainer(object container)
		{
		}

		public void PinAllOptions(string category)
		{
		}

		public void UnpinAllOptions(string category)
		{
		}

		public void PinOption(string name)
		{
		}

		public void UnpinOption(string name)
		{
		}

		public void ClearPinnedOptions()
		{
		}

		public void ShowBugReportSheet(ActionCompleteCallback onComplete = null, bool takeScreenshot = true, string descriptionContent = null)
		{
		}

		private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		private void PromptEntryCode()
		{
		}

		public RectTransform EnableWorldSpaceMode()
		{
			return null;
		}
	}
}
