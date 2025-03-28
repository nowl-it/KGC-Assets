using System;
using UnityEngine;

public class ClosableObject : MonoBehaviour, IClosable
{
	private Action _callback;

	private bool _setupBlur;

	public void Show(Action callback = null, bool setupBlur = false)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
