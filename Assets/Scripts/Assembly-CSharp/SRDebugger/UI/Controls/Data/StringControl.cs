using System;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class StringControl : DataBoundControl
	{
		[RequiredField]
		public InputField InputField;

		[RequiredField]
		public Text Title;

		protected override void Start()
		{
		}

		private void OnValueChanged(string newValue)
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
