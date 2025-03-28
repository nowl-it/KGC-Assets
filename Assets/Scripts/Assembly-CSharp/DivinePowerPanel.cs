using System;
using UnityEngine;
using UnityEngine.UI;

public class DivinePowerPanel : MonoBehaviour, IComponentConnector
{
	[ComponentConnect]
	public Border ribbon;

	[ComponentConnect]
	public Text condText;

	[ComponentConnect]
	public CanvasGroup tweenGroup1;

	[ComponentConnect]
	public CanvasGroup selectionsBox;

	[ComponentConnect]
	public CanvasGroup buttons;

	[ComponentConnect]
	public Button confirmButton;

	public Setter[] selections;

	private Action<bool> _callback;

	private int _selectedIdx;

	public void Show(Action<bool> callback)
	{
	}

	public void Close()
	{
	}

	public void OnSelect(int idx)
	{
	}

	[OnClick("ConfirmButton", false)]
	public void OnClickConfirm()
	{
	}
}
