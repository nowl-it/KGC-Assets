using System;
using System.Runtime.CompilerServices;
using SRDebugger.UI;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDebugPanelService))]
	public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService
	{
		private DebugPanelRoot _debugPanelRootObject;

		private bool _isVisible;

		private bool? _cursorWasVisible;

		private CursorLockMode? _cursorLockMode;

		public DebugPanelRoot RootObject => null;

		public bool IsLoaded => false;

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

		public DefaultTabs? ActiveTab => null;

		public event Action<IDebugPanelService, bool> VisibilityChanged
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

		public void OpenTab(DefaultTabs tab)
		{
		}

		public void Unload()
		{
		}

		private void Load()
		{
		}
	}
}
