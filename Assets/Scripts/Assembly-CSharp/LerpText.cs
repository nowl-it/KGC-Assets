using System;
using UnityEngine;
using UnityEngine.UI;

public class LerpText : MonoBehaviour
{
	public Text valueText;

	public float speedRatio;

	public float delay;

	public bool signed;

	private long _value;

	private double _displayValue;

	private Func<long, string> _format;

	private Action<long> _valueCallback;

	private Action _maxCallback;

	private float _delayTimer;

	private Action<long> _reloadAction;

	private long _minValue;

	public void Set(int value, string format = "{0}", bool force = false)
	{
	}

	public void Set(long value, Func<long, string> format, bool force = false)
	{
	}

	public void SetMinValue(long value)
	{
	}

	public void SetReloadAction(Action<long> reloadAction)
	{
	}

	public void SetValueCallback(Action<long> callback)
	{
	}

	private void ReloadGauge()
	{
	}

	public void Update()
	{
	}
}
