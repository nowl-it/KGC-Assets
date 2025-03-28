using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	[RequireComponent(typeof(RectTransform))]
	public class ProfilerGraphAxisLabel : SRMonoBehaviourEx
	{
		private float _prevFrameTime;

		private float? _queuedFrameTime;

		private float _yPosition;

		[RequiredField]
		public Text Text;

		protected override void Update()
		{
		}

		public void SetValue(float frameTime, float yPosition)
		{
		}

		private void SetValueInternal(float frameTime)
		{
		}
	}
}
