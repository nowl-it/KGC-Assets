using System;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	[SerializeField]
	private UIFitter[] _uiFitters;

	public Text tooltipText;

	public int duration;

	private ulong? _key;

	public void Show(string desc)
	{
	}

	public void SetOnClose(Action action)
	{
	}
}
