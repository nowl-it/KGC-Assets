using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoGauge : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public CanvasGroup canvasGroup;

	public Image gauge;

	public Image ammoGauge;

	public GameObject dividerPrefab;

	public Transform dividersTransform;

	private float _maxValue;

	private float _value;

	private Action _maxCallback;

	private float _addValuePerSecond;

	private float _addValueRatio;

	private float _valueUnit;

	private List<GameObject> _dividers;

	private float _reloadTimer;

	public float max => 0f;

	public void Awake()
	{
	}

	public void Set(int value, int maxValue)
	{
	}

	public void SetValue(int value)
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

	public bool HasAmmo()
	{
		return false;
	}

	public bool UseAmmo()
	{
		return false;
	}

	public void SetMax(float max)
	{
	}

	public void SetReloadSpeed(float speed)
	{
	}

	public void SetSpeedRatio(float ratio)
	{
	}

	public void SetDivider(int count)
	{
	}

	private void AddDivider(float x)
	{
	}
}
