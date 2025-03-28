using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumInvadePointIndicator : MonoBehaviour
{
	[SerializeField]
	private Transform _pointsRoot;

	[SerializeField]
	private Text _overText;

	[SerializeField]
	private ColosseumInvadePoint _pointPrefab;

	private int _lastPoint;

	private readonly List<ColosseumInvadePoint> _points;

	public int lastPoint => 0;

	private void Init()
	{
	}

	public void Reload(int invadePoint, bool showEffect, bool showOverPoint = false, float baseEffectDelay = 2f)
	{
	}
}
