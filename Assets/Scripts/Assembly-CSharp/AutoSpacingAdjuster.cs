using System;
using UnityEngine;
using UnityEngine.UI;

public class AutoSpacingAdjuster : MonoBehaviour
{
	[SerializeField]
	private HorizontalOrVerticalLayoutGroup _layoutGroup;

	[SerializeField]
	private RectTransform _layoutGroupTransform;

	[SerializeField]
	private RectTransform _elementPrefab;

	private float? _defaultSpacing;

	private int _lastElementCount;

	public Action onAdjusted;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Adjust()
	{
	}
}
