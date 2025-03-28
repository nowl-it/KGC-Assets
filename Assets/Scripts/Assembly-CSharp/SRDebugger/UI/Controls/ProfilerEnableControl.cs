using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerEnableControl : SRMonoBehaviourEx
	{
		private bool _previousState;

		[RequiredField]
		public Text ButtonText;

		[RequiredField]
		public Button EnableButton;

		[RequiredField]
		public Text Text;

		protected override void Start()
		{
		}

		protected void UpdateLabels()
		{
		}

		protected override void Update()
		{
		}

		public void ToggleProfiler()
		{
		}
	}
}
