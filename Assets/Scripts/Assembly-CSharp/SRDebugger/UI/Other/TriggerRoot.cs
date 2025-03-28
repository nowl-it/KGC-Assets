using SRDebugger.UI.Controls;
using SRF;
using SRF.UI;
using UnityEngine;
using UnityEngine.Serialization;

namespace SRDebugger.UI.Other
{
	public class TriggerRoot : SRMonoBehaviourEx
	{
		[RequiredField]
		public Canvas Canvas;

		[RequiredField]
		public SRF.UI.LongPressButton TapHoldButton;

		[RequiredField]
		public RectTransform TriggerTransform;

		[FormerlySerializedAs("TriggerButton")]
		[RequiredField]
		public MultiTapButton TripleTapButton;
	}
}
