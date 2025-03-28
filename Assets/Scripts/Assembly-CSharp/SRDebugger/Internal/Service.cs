using SRDebugger.Services;

namespace SRDebugger.Internal
{
	public static class Service
	{
		private static IConsoleService _consoleService;

		private static IDebugPanelService _debugPanelService;

		private static IDebugTriggerService _debugTriggerService;

		private static IPinnedUIService _pinnedUiService;

		private static IDebugCameraService _debugCameraService;

		private static IOptionsService _optionsService;

		private static IDockConsoleService _dockConsoleService;

		public static IConsoleService Console => null;

		public static IDockConsoleService DockConsole => null;

		public static IDebugPanelService Panel => null;

		public static IDebugTriggerService Trigger => null;

		public static IPinnedUIService PinnedUI => null;

		public static IDebugCameraService DebugCamera => null;

		public static IOptionsService Options => null;
	}
}
