using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class InfoBlock : SRMonoBehaviourEx
	{
		[RequiredField]
		public Text Content;

		[RequiredField]
		public Text Title;
	}
}
