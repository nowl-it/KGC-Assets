using System;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class TutorialStep : MonoBehaviour, TouchListener
{
	public enum TriggerType
	{
		Click = 0,
		Delay = 1,
		CameraMove = 2,
		Condition = 3
	}

	[ComponentConnect]
	public Button focus;

	public Button target;

	public ClickableObject clickableObject;

	public Button nextButton;

	[CanBeNull]
	public Text text;

	public TextFitter descTextFitter;

	public Border descTextBorder;

	private Action _callback;

	[CanBeNull]
	public Action afterCallback;

	private int _count;

	private float _time;

	private Func<bool> _check;

	private Tween _focusTween;

	public TriggerType triggerType { get; private set; }

	private void OnDisable()
	{
	}

	public void SetClick(Action callback, int count = 1, bool setFocusPos = false, bool focusAfter = false, bool setFocusSize = false)
	{
	}

	public void OnClick()
	{
	}

	public void SetDelay(float time, Action callback)
	{
	}

	private void OnEnable()
	{
	}

	public void SetCameraMove(Action callback)
	{
	}

	public void OnTouch(TouchPhase phase, Vector2 pt, int touchId = 0)
	{
	}

	public void SetCondition(Func<bool> check, Action callback)
	{
	}

	private void Update()
	{
	}

	private Vector3 GetFocusLocalPosition(Transform objTransform, [CanBeNull] Canvas objCanvas)
	{
		return default(Vector3);
	}

	public Vector3 GetTargetPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetClickableObjectPosition()
	{
		return default(Vector3);
	}

	public void SetFocusPosition(Vector2 offset = default(Vector2))
	{
	}

	public void SetFocusSizeDelta(Vector2 offset = default(Vector2))
	{
	}
}
