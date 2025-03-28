using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public CanvasGroup canvasGroup;

	public Text valueText;

	private LerpText valueLerpText;

	public Image gauge;

	public Image shieldGauge;

	public Image directGauge;

	public float speedRatio;

	public float delay;

	public GaugeMarker gaugeMarker;

	public bool displayRealValue;

	public Vector2 shieldGaugeOffset;

	private int _maxValue;

	private int _value;

	private float _displayValueP;

	public float displayValueDivide;

	public bool containDefaultValueToShield;

	private Action<int> _valueCallback;

	private Action _maxCallback;

	private float _delayTimer;

	private Func<int, int, string> _textFormatFunc;

	private int _shieldValue;

	private int _displayShieldValue;

	private bool _isInited;

	private float _gaugeHeight;

	private float _gaugeWidth;

	private float _directGaugeHeight;

	private float _directGaugeWidth;

	private float _shieldGaugeWidth;

	private bool _isDirty;

	private bool _forceNextReload;

	private Tween _shieldEffect;

	public Ease shieldEffectEase;

	private float _displayValue => 0f;

	public int value => 0;

	public int maxValue => 0;

	public bool isMax => false;

	public void Start()
	{
	}

	public void Awake()
	{
	}

	private void Init()
	{
	}

	public void Set(int value, int maxValue, bool force = false)
	{
	}

	public void SetValue(int value, bool force = false)
	{
	}

	public void SetShieldValue(int value, bool showEffect = false)
	{
	}

	public void SetValueCallback(Action<int> callback)
	{
	}

	public void SetMaxCallback(Action callback)
	{
	}

	private void ReloadGauge()
	{
	}

	public void Update()
	{
	}

	public void LateUpdate()
	{
	}

	public void SetTextFormatFunc(Func<int, int, string> func)
	{
	}

	public void CopyGaugeRect(Gauge from)
	{
	}

	public void SetGaugeRect(float width, float height)
	{
	}

	public List<Image> GetAllGaugeImages()
	{
		return null;
	}

	public void SetDirty(bool force)
	{
	}
}
