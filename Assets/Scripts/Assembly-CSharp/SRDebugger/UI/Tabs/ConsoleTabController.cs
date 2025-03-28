using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Tabs
{
	public class ConsoleTabController : SRMonoBehaviourEx
	{
		private const int MaxLength = 2600;

		private Canvas _consoleCanvas;

		private bool _isDirty;

		[RequiredField]
		public ConsoleLogControl ConsoleLogControl;

		[RequiredField]
		public Toggle PinToggle;

		[RequiredField]
		public ScrollRect StackTraceScrollRect;

		[RequiredField]
		public Text StackTraceText;

		[RequiredField]
		public Toggle ToggleErrors;

		[RequiredField]
		public Text ToggleErrorsText;

		[RequiredField]
		public Toggle ToggleInfo;

		[RequiredField]
		public Text ToggleInfoText;

		[RequiredField]
		public Toggle ToggleWarnings;

		[RequiredField]
		public Text ToggleWarningsText;

		[RequiredField]
		public Toggle FilterToggle;

		[RequiredField]
		public InputField FilterField;

		[RequiredField]
		public GameObject FilterBarContainer;

		protected override void Start()
		{
		}

		private void FilterToggleValueChanged(bool isOn)
		{
		}

		private void FilterValueChanged(string filterText)
		{
		}

		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		private void PinToggleValueChanged(bool isOn)
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		private void ConsoleLogSelectedItemChanged(object item)
		{
		}

		protected override void Update()
		{
		}

		private void PopulateStackTraceArea(ConsoleEntry entry)
		{
		}

		private void Refresh()
		{
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		public void Clear()
		{
		}
	}
}
