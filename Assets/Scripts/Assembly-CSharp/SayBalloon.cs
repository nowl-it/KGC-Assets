using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SayBalloon : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[ComponentConnect]
	public RectTransform box;

	[ComponentConnect]
	public Text content;

	private Sequence _hideTimer;

	private Action _callback;

	public void Show(string text, Action callback = null)
	{
	}

	public void Hide()
	{
	}
}
