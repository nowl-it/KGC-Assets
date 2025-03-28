using System.Collections.Generic;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(KeyboardShortcutListenerService))]
	public class KeyboardShortcutListenerService : SRServiceBase<KeyboardShortcutListenerService>
	{
		private List<Settings.KeyboardShortcut> _shortcuts;

		protected override void Awake()
		{
		}

		private void ToggleTab(DefaultTabs t)
		{
		}

		private void ExecuteShortcut(Settings.KeyboardShortcut shortcut)
		{
		}

		protected override void Update()
		{
		}
	}
}
