using UnityEngine;

[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
public class Border : UIFitter
{
	public RectTransform target;

	public Vector2 border;

	public bool update;

	public bool xBorder;

	public bool yBorder;

	[Space]
	public bool applyMinX;

	public bool applyMinY;

	public Vector2 minSize;

	[Space]
	public bool applyMaxX;

	public bool applyMaxY;

	public Vector2 maxSize;

	private RectTransform _rectTransform;

	public void OnRenderObject()
	{
	}

	public void Reload(bool forceReloadChildren = false)
	{
	}

	public override void Fit()
	{
	}
}
