using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour
{
	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _textText;

	[SerializeField]
	private RectTransform _nextArrow;

	[SerializeField]
	private GameObject _arrowToCharacter;

	[SerializeField]
	private Border[] _borders;

	private Tween _arrowTween;

	private Action _onClick;

	public void Show(string name, string text, bool showArrowToCharacter = true)
	{
	}

	public void Hide()
	{
	}

	public void SetOnClick(Action onClick)
	{
	}

	public void OnClick()
	{
	}
}
