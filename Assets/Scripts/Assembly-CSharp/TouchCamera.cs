using System.Collections.Generic;
using UnityEngine;

public class TouchCamera : MonoBehaviour
{
	private Camera _camera;

	private Transform _cameraTransform;

	private Vector3 _cameraPos;

	private Vector3 _touchPos;

	[SerializeField]
	private float _cameraSize;

	[SerializeField]
	private float _cameraMinSize;

	[SerializeField]
	private float _cameraMaxSize;

	private bool _moveMode;

	[SerializeField]
	private bool _touchable;

	[SerializeField]
	private bool _wheelZoomEnabled;

	[SerializeField]
	private bool _enableX;

	[SerializeField]
	private bool _enableY;

	private Vector2 _goalPos;

	private List<TouchListener> _listeners;

	public float toSize => 0f;

	public float size => 0f;

	public void Start()
	{
	}

	public void ChangeSize()
	{
	}

	public void Update()
	{
	}

	public void AddListener(TouchListener l)
	{
	}

	private void OnTouchBegan(int touchId, Vector3 pt, bool broadcast = true)
	{
	}

	private void OnTouchMoved(int touchId, Vector3 pt)
	{
	}

	private void OnTouchEnded(int touchId, Vector3 pt)
	{
	}

	private void SetPosition(Vector2 pos)
	{
	}

	public void SetSize(float size)
	{
	}

	public void SetTouchable(bool enabled)
	{
	}
}
