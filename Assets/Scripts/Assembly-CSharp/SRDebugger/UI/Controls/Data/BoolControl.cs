using System;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class BoolControl : DataBoundControl
	{
		[RequiredField]
		public Text Title;

		[RequiredField]
		public Toggle Toggle;

		protected override void Start()
		{
		}

		private void ToggleOnValueChanged(bool isOn)
		{
		}

		protected override void OnBind(string propertyName, Type t)
		{
		}

		protected override void OnValueUpdated(object newValue)
		{
		}

		public override bool CanBind(Type type, bool isReadOnly)
		{
			return false;
		}
	}
}
