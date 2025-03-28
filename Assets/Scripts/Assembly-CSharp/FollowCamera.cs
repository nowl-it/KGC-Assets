using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowCamera : MonoBehaviour
{
	public Camera camera;

	[Header("Follow")]
	public Transform target;

	public bool followX;

	public bool followY;

	[Header("Offset")]
	public Vector2 offset;

	[Header("Bound")]
	public bool boundX;

	public bool boundY;

	public Vector2 minBounds;

	public Vector2 maxBounds;

	[Header("Smooth")]
	public bool smoothFollow;

	public float smoothPower;

	public float sizeSmoothPower;

	[Header("Size")]
	public float orthographicSize;

	private Vector2 _position;

	private Vector2 _originPosition;

	public void Awake()
	{
	}

	public void SetTarget(Transform target, bool force = true)
	{
	}

	public void ForceUpdate()
	{
	}

	private Vector2 GetGoalPosition()
	{
		return default(Vector2);
	}

	public void SetOffset(Vector2 offset)
	{
	}

	public void FixedUpdate()
	{
	}

	public void SetSize(float size, bool force = false)
	{
	}

	public void SetPosition(Vector2 pos)
	{
	}
}
