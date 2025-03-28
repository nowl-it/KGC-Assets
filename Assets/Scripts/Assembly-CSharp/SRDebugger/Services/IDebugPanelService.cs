using System;

namespace SRDebugger.Services
{
	public interface IDebugPanelService
	{
		bool IsLoaded { get; }

		bool IsVisible { get; set; }

		DefaultTabs? ActiveTab { get; }

		event Action<IDebugPanelService, bool> VisibilityChanged;

		void Unload();

		void OpenTab(DefaultTabs tab);
	}
}
