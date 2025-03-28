using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
public class UICirclePosition : MonoBehaviour
{
	public RectTransform circleFrom;

	public float distance;

	public float angle;

	public Vector2 offset;

	private RectTransform _rectTransform;

	private float _lastAngle;

	private float _lastDistance;

	private Vector2 _lastOffset;

	public void Awake()
	{
	}

	private void UpdatePosition()
	{
	}

	public void SetDistance(float distance)
	{
	}

	public void SetAngle(float angle)
	{
	}

	public void SetOffset(Vector2 offset)
	{
	}
}
