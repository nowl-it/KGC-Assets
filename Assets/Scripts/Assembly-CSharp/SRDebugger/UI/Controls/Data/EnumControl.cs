using System;
using SRF;
using SRF.UI;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class EnumControl : DataBoundControl
	{
		private object _lastValue;

		private string[] _names;

		private Array _values;

		[RequiredField]
		public LayoutElement ContentLayoutElement;

		public GameObject[] DisableOnReadOnly;

		[RequiredField]
		public SRSpinner Spinner;

		[RequiredField]
		public Text Title;

		[RequiredField]
		public Text Value;

		protected override void Start()
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

		private void SetIndex(int i)
		{
		}

		public void GoToNext()
		{
		}

		public void GoToPrevious()
		{
		}
	}
}
