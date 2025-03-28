using UnityEngine;

public class ClickableObject : MonoBehaviour
{
	[SerializeField]
	protected Collider2D[] _colliders;

	[SerializeField]
	private float _pressedSized;

	private Canvas _parentCanvas;

	public Canvas parentCanvas => null;

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Awake()
	{
	}

	public bool CheckClick(Vector3 worldMousePos)
	{
		return false;
	}

	public virtual void OnPress(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	public virtual void OnClick(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	public void RestoreScale()
	{
	}

	protected void UpdateZ()
	{
	}
}
