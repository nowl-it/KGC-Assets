using System;
using UnityEngine;

public class CanvasPopup : MonoBehaviour, IClosable
{
	private Action<bool> _callback;

	public Popup popup1;

	public Popup popup2;

	public void Show(string text, Popup.Type type = Popup.Type.Ok, Action<bool> callback = null)
	{
	}

	public bool Close()
	{
		return false;
	}
}
