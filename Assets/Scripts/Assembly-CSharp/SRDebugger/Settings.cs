using System;
using System.Collections.Generic;
using UnityEngine;

namespace SRDebugger
{
	public class Settings : ScriptableObject
	{
		public enum ShortcutActions
		{
			None = 0,
			OpenSystemInfoTab = 1,
			OpenConsoleTab = 2,
			OpenOptionsTab = 3,
			OpenProfilerTab = 4,
			OpenBugReporterTab = 5,
			ClosePanel = 6,
			OpenPanel = 7,
			TogglePanel = 8,
			ShowBugReportPopover = 9,
			ToggleDockedConsole = 10,
			ToggleDockedProfiler = 11
		}

		public enum TriggerBehaviours
		{
			TripleTap = 0,
			TapAndHold = 1,
			DoubleTap = 2
		}

		public enum TriggerEnableModes
		{
			Enabled = 0,
			MobileOnly = 1,
			Off = 2,
			DevelopmentBuildsOnly = 3
		}

		[Serializable]
		public sealed class KeyboardShortcut
		{
			[SerializeField]
			public ShortcutActions Action;

			[SerializeField]
			public bool Alt;

			[SerializeField]
			public bool Control;

			[SerializeField]
			public KeyCode Key;

			[SerializeField]
			public bool Shift;
		}

		private const string ResourcesPath = "/usr/Resources/SRDebugger";

		private const string ResourcesName = "Settings";

		private static Settings _instance;

		[SerializeField]
		private bool _isEnabled;

		[SerializeField]
		private bool _autoLoad;

		[SerializeField]
		private DefaultTabs _defaultTab;

		[SerializeField]
		private TriggerEnableModes _triggerEnableMode;

		[SerializeField]
		private TriggerBehaviours _triggerBehaviour;

		[SerializeField]
		private bool _enableKeyboardShortcuts;

		[SerializeField]
		private KeyboardShortcut[] _keyboardShortcuts;

		[SerializeField]
		private KeyboardShortcut[] _newKeyboardShortcuts;

		[SerializeField]
		private bool _keyboardModifierControl;

		[SerializeField]
		private bool _keyboardModifierAlt;

		[SerializeField]
		private bool _keyboardModifierShift;

		[SerializeField]
		private bool _keyboardEscapeClose;

		[SerializeField]
		private bool _enableBackgroundTransparency;

		[SerializeField]
		private bool _collapseDuplicateLogEntries;

		[SerializeField]
		private bool _richTextInConsole;

		[SerializeField]
		private bool _requireEntryCode;

		[SerializeField]
		private bool _requireEntryCodeEveryTime;

		[SerializeField]
		private int[] _entryCode;

		[SerializeField]
		private bool _useDebugCamera;

		[SerializeField]
		private int _debugLayer;

		[Range(-100f, 100f)]
		[SerializeField]
		private float _debugCameraDepth;

		[SerializeField]
		private string _apiKey;

		[SerializeField]
		private bool _enableBugReporter;

		[SerializeField]
		private DefaultTabs[] _disabledTabs;

		[SerializeField]
		private PinAlignment _profilerAlignment;

		[SerializeField]
		private PinAlignment _optionsAlignment;

		[SerializeField]
		private ConsoleAlignment _consoleAlignment;

		[SerializeField]
		private PinAlignment _triggerPosition;

		[SerializeField]
		private int _maximumConsoleEntries;

		[SerializeField]
		private bool _enableEventSystemCreation;

		[SerializeField]
		private bool _automaticShowCursor;

		public static Settings Instance => null;

		public bool IsEnabled => false;

		public bool AutoLoad => false;

		public DefaultTabs DefaultTab => default(DefaultTabs);

		public TriggerEnableModes EnableTrigger => default(TriggerEnableModes);

		public TriggerBehaviours TriggerBehaviour => default(TriggerBehaviours);

		public bool EnableKeyboardShortcuts => false;

		public IList<KeyboardShortcut> KeyboardShortcuts => null;

		public bool KeyboardEscapeClose => false;

		public bool EnableBackgroundTransparency => false;

		public bool RequireCode => false;

		public bool RequireEntryCodeEveryTime => false;

		public IList<int> EntryCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseDebugCamera => false;

		public int DebugLayer => 0;

		public float DebugCameraDepth => 0f;

		public bool CollapseDuplicateLogEntries => false;

		public bool RichTextInConsole => false;

		public string ApiKey => null;

		public bool EnableBugReporter => false;

		public IList<DefaultTabs> DisabledTabs => null;

		public PinAlignment TriggerPosition => default(PinAlignment);

		public PinAlignment ProfilerAlignment => default(PinAlignment);

		public PinAlignment OptionsAlignment => default(PinAlignment);

		public ConsoleAlignment ConsoleAlignment
		{
			get
			{
				return default(ConsoleAlignment);
			}
			set
			{
			}
		}

		public int MaximumConsoleEntries
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool EnableEventSystemGeneration
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutomaticallyShowCursor => false;

		private static KeyboardShortcut[] GetDefaultKeyboardShortcuts()
		{
			return null;
		}

		private void UpgradeKeyboardShortcuts()
		{
		}

		private static Settings GetOrCreateInstance()
		{
			return null;
		}
	}
}
