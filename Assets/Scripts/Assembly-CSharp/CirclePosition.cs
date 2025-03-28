using UnityEngine;

[ExecuteInEditMode]
public class CirclePosition : MonoBehaviour
{
	public Transform circleFrom;

	public float distance;

	public float angle;

	public Vector2 offset;

	private Transform _transform;

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
