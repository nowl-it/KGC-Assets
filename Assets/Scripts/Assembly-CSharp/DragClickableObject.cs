using UnityEngine;

public class DragClickableObject : ClickableObject
{
	private bool _canBeDragged;

	private Vector2 _pressedPosition;

	protected bool _isDragging;

	protected virtual void Update()
	{
	}

	public virtual void OnBeginDrag()
	{
	}

	public virtual void OnDrag(Vector3 worldPosition)
	{
	}

	public virtual void OnEndDrag()
	{
	}

	public override void OnPress(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	public override void OnClick(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}
}
