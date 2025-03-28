using UnityEngine;

[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
public class Padding : MonoBehaviour
{
	public RectTransform target;

	public Vector2 padding;

	public bool xPadding;

	public bool yPadding;

	public bool reverse;

	private RectTransform _rectTransform;

	public void OnRenderObject()
	{
	}

	public void Reload()
	{
	}
}
