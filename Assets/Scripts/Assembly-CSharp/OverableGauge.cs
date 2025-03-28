using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class OverableGauge : MonoBehaviour
{
	public Image gauge;

	public Image addedGauge;

	public Image overedGauge;

	[SerializeField]
	private RectTransform _gaugeLayout;

	[SerializeField]
	private float _addedGaugeXOffset;

	public Color normalColor;

	public Color addedColor;

	public Color overedColor;

	private Tween _addedGaugeFlashTween;

	private Tween _overedGaugeFlashTween;

	public void Set(float currentValue, float addedValue, List<float> reqValues, int startIdx)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
