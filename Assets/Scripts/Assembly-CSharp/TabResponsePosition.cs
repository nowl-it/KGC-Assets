using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class TabResponsePosition : TabResponse
{
	private RectTransform _rectTransform;

	public Vector2 selectedPosition;

	public Vector2 disabledPosition;

	public bool tween;

	public float tweenTime;

	private Tweener _tweener;

	public RectTransform rectTransform => null;

	public override void SetSelected(bool v)
	{
	}
}
