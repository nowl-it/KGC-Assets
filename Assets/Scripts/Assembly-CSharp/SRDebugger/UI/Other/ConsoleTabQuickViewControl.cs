using SRDebugger.Services;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class ConsoleTabQuickViewControl : SRMonoBehaviourEx
	{
		private const int Max = 1000;

		private static readonly string MaxString;

		private int _prevErrorCount;

		private int _prevInfoCount;

		private int _prevWarningCount;

		[Import]
		public IConsoleService ConsoleService;

		[RequiredField]
		public Text ErrorCountText;

		[RequiredField]
		public Text InfoCountText;

		[RequiredField]
		public Text WarningCountText;

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		private static bool HasChanged(int newCount, ref int oldCount, int max)
		{
			return false;
		}
	}
}
