using System.Collections.Generic;
using UnityEngine;

public class TouchCamera2 : MonoBehaviour
{
	private Camera _camera;

	private Transform _cameraTransform;

	private Vector3 _cameraPos;

	private Vector3 _touchPos;

	private Vector3 _touchWorldPos;

	private float _cameraMinY;

	private float _cameraMaxY;

	private bool _moveMode;

	[SerializeField]
	private bool _touchable;

	[SerializeField]
	private float detectingDist;

	private Vector2 _goalPos;

	private float _touchTime;

	private List<TouchListener> _listeners;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void AddListener(TouchListener l)
	{
	}

	public void RemoveListener(TouchListener l)
	{
	}

	private bool DragOther(Vector2 pt)
	{
		return false;
	}

	private void OnTouchBegan(int touchId, Vector3 pt)
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

	public void SetTouchable(bool enabled)
	{
	}
}
