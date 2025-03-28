using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LayoutGroup))]
[ExecuteInEditMode]
public class LayoutFitter : UIFitter
{
	public Vector2 margin;

	public bool fitX;

	public bool fitY;

	private RectTransform _rectTransform;

	private LayoutGroup _layout;

	private void OnEnable()
	{
	}

	public override void Fit()
	{
	}
}
