using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ImageToggle : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[SerializeField]
	private bool _isOn;

	[SerializeField]
	private bool _disabled;

	public Image targetImage;

	public Sprite onSprite;

	public Sprite offSprite;

	private Action<bool> _callback;

	public bool isOn => false;

	public void SetCallback(Action<bool> callback)
	{
	}

	private void Reload()
	{
	}

	public void OnEnable()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void SetIsOn(bool v)
	{
	}

	public void SetDisable(bool v)
	{
	}
}
