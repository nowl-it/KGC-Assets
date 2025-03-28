using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class MultiTapButton : Button
	{
		private float _lastTap;

		private int _tapCount;

		public int RequiredTapCount;

		public float ResetTime;

		public override void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
