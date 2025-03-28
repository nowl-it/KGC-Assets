using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScrollGradationHandler : MonoBehaviour
{
	[SerializeField]
	private ScrollRect _scrollRect;

	private RectTransform _scrollRectTr;

	[SerializeField]
	private float _offset;

	[SerializeField]
	private RectTransform.Axis _axis;

	[SerializeField]
	private List<Graphic> _startGradations;

	[SerializeField]
	private List<Graphic> _endGradations;

	private void Start()
	{
	}

	private void HandleScrollValueChanged(Vector2 _)
	{
	}
}
