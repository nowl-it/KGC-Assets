using SRF;
using SRF.UI;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class SRTabButton : SRMonoBehaviourEx
	{
		[RequiredField]
		public Behaviour ActiveToggle;

		[RequiredField]
		public Button Button;

		[RequiredField]
		public RectTransform ExtraContentContainer;

		[RequiredField]
		public StyleComponent IconStyleComponent;

		[RequiredField]
		public Text TitleText;

		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
