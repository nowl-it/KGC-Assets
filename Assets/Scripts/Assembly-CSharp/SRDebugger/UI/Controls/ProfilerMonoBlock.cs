using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerMonoBlock : SRMonoBehaviourEx
	{
		private float _lastRefresh;

		[RequiredField]
		public Text CurrentUsedText;

		[RequiredField]
		public GameObject NotSupportedMessage;

		[RequiredField]
		public Slider Slider;

		[RequiredField]
		public Text TotalAllocatedText;

		private bool _isSupported;

		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		public void TriggerRefresh()
		{
		}

		public void TriggerCollection()
		{
		}
	}
}
