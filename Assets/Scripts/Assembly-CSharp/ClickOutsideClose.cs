using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ClickOutsideClose : PopupPanel
{
	private CanvasGroup _cg;

	private Tween _tween;

	private bool _activatedAtThisFrame;

	[SerializeField]
	private bool _closeOnButtonUp;

	[SerializeField]
	private bool _isPopup;

	public List<Transform> excepts;

	private Action _onClose;

	public bool tween;

	private bool _closing;

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public new void Show()
	{
	}

	public override void OnClickClose()
	{
	}

	public void SetOnClose(Action onClose)
	{
	}
}
