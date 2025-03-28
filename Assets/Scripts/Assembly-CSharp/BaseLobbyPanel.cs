using UnityEngine;

public class BaseLobbyPanel : MonoBehaviour
{
	[GetComponent]
	public CanvasGroup canvasGroup;

	[GetComponent]
	public RectTransform rectTransform;

	[HideInInspector]
	public bool panelActivated;

	[HideInInspector]
	public bool panelSetStarted;

	[HideInInspector]
	public bool inited;

	public virtual void Init()
	{
	}

	public void SetWidth(float width)
	{
	}

	public virtual void OnPanelEnabled()
	{
	}

	public virtual void OnPanelDisabled()
	{
	}

	public virtual void OnPanelSetStart()
	{
	}

	public virtual void OnScreenDragStart()
	{
	}

	public virtual void OnScreenDragEnd()
	{
	}
}
