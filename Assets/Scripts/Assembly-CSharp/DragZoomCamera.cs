using UnityEngine;

public class DragZoomCamera : MonoBehaviour
{
	[SerializeField]
	private Camera _camera;

	private Vector2 _mapSize;

	private float _originalCanvasScale;

	private float _canvasScale;

	private bool _isDragging;

	private Vector2 _prevMousePosition;

	private bool _dragEndedAtThisFrame;

	private float _originalCameraSize;

	private float _zoomScale;

	private float _zoomMin;

	private float _zoomMax;

	private bool _isMovingAtLookAtTargetPos;

	private float _lookAtMoveSpeed;

	private Vector2 _lookAtTargetPos;

	private void Awake()
	{
	}

	public void Init(Vector2 mapSize, float originalCamSize, float zoomMin, float zoomMax)
	{
	}

	private void Update()
	{
	}

	private void StartDrag()
	{
	}

	private void OnDragging()
	{
	}

	private Vector2 ClampPointToMapSize(Vector2 newPos)
	{
		return default(Vector2);
	}

	public void EndDrag()
	{
	}

	public void LookAt(Vector2 position, float speed)
	{
	}

	public void SetZoomScale(float scale)
	{
	}

	public float GetZoomedRatio()
	{
		return 0f;
	}
}
