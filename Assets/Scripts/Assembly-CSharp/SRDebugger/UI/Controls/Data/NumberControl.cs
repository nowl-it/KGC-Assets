using System;
using System.Collections.Generic;
using SRF;
using SRF.UI;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class NumberControl : DataBoundControl
	{
		public struct ValueRange
		{
			public double MaxValue;

			public double MinValue;
		}

		private static readonly Type[] IntegerTypes;

		private static readonly Type[] DecimalTypes;

		public static readonly Dictionary<Type, ValueRange> ValueRanges;

		private string _lastValue;

		private Type _type;

		public GameObject[] DisableOnReadOnly;

		public SRNumberButton DownNumberButton;

		[RequiredField]
		public SRNumberSpinner NumberSpinner;

		[RequiredField]
		public Text Title;

		public SRNumberButton UpNumberButton;

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

		protected static bool IsIntegerType(Type t)
		{
			return false;
		}

		protected static bool IsDecimalType(Type t)
		{
			return false;
		}

		protected double GetMaxValue(Type t)
		{
			return 0.0;
		}

		protected double GetMinValue(Type t)
		{
			return 0.0;
		}
	}
}
