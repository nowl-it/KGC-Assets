using SRF;
using SRF.Helpers;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class ActionControl : OptionsControlBase
	{
		private MethodReference _method;

		[RequiredField]
		public Button Button;

		[RequiredField]
		public Text Title;

		public MethodReference Method => null;

		protected override void Start()
		{
		}

		private void ButtonOnClick()
		{
		}

		public void SetMethod(string methodName, MethodReference method)
		{
		}
	}
}
