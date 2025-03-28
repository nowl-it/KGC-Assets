using System;
using UnityEngine;
using UnityEngine.UI;

public class MovingText : MonoBehaviour
{
	[Serializable]
	public enum MoveDir
	{
		Left = 0,
		Right = 1,
		Up = 2,
		Down = 3
	}

	public Text text;

	private RectTransform _rectTransform;

	public float scrollSpeed;

	public MoveDir moveDir;

	private Vector2 _moveVector;

	private float _textWidth;

	private float _parentWidth;

	private Vector2 _originalPosition;

	private bool _move;

	public Text cloneText;

	private RectTransform _cloneRectTransform;

	public float distanceWithClone;

	private bool _inited;

	private void Awake()
	{
	}

	private void Init()
	{
	}

	public void OnTextChanged()
	{
	}

	private void CheckMoveCond()
	{
	}

	public void Update()
	{
	}

	private void CheckIsOutOfRange(RectTransform rt)
	{
	}
}
