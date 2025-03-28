using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SRDebugger.Internal;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Other;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IPinnedUIService))]
	public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService
	{
		private readonly List<OptionsControlBase> _controlList;

		private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects;

		private bool _queueRefresh;

		private PinnedUIRoot _uiRoot;

		public DockConsoleController DockConsoleController => null;

		public bool IsProfilerPinned
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<OptionDefinition, bool> OptionPinStateChanged
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

		public void Pin(OptionDefinition obj, int order = -1)
		{
		}

		public void Unpin(OptionDefinition obj)
		{
		}

		private void OnPinnedStateChanged(OptionDefinition option, bool isPinned)
		{
		}

		public void UnpinAll()
		{
		}

		public bool HasPinned(OptionDefinition option)
		{
			return false;
		}

		protected override void Awake()
		{
		}

		private void Load()
		{
		}

		private void UpdateAnchors()
		{
		}

		protected override void Update()
		{
		}

		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
		}

		private void OptionsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		private void OnDebugPanelVisibilityChanged(bool isVisible)
		{
		}

		private void Refresh()
		{
		}
	}
}
