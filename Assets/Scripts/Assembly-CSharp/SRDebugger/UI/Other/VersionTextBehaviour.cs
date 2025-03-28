using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class VersionTextBehaviour : SRMonoBehaviourEx
	{
		public string Format;

		[RequiredField]
		public Text Text;

		protected override void Start()
		{
		}
	}
}
