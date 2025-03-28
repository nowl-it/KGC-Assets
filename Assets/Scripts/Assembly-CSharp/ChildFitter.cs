using UnityEngine;

[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
public class ChildFitter : MonoBehaviour
{
	public bool fitX;

	public bool fitY;

	public Vector2 margin;

	[SerializeField]
	private Canvas _parentCanvas;

	private RectTransform _rectTransform;

	private void OnEnable()
	{
	}

	public void Fit()
	{
	}
}
