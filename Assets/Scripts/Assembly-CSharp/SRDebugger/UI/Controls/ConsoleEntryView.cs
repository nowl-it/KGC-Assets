using SRDebugger.Services;
using SRF;
using SRF.UI;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	[RequireComponent(typeof(RectTransform))]
	public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView
	{
		public const string ConsoleBlobInfo = "Console_Info_Blob";

		public const string ConsoleBlobWarning = "Console_Warning_Blob";

		public const string ConsoleBlobError = "Console_Error_Blob";

		private int _count;

		private bool _hasCount;

		private ConsoleEntry _prevData;

		private RectTransform _rectTransform;

		[RequiredField]
		public Text Count;

		[RequiredField]
		public CanvasGroup CountContainer;

		[RequiredField]
		public StyleComponent ImageStyle;

		[RequiredField]
		public Text Message;

		[RequiredField]
		public Text StackTrace;

		public void SetDataContext(object data)
		{
		}

		protected override void Awake()
		{
		}
	}
}
