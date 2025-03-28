using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMoneyEffect : MonoBehaviour
{
	public Image moneyPrefab;

	private List<RectTransform> _objs;

	private List<RectTransform> _pool;

	private Transform _target;

	private Vector3 _pos;

	private bool _targetIsCameraCanvas;

	private bool _skip;

	private Action _callback;

	private PopupManager.PopupInformation _originPopupInformation;

	private Vector2 _originPosition;

	private void OnDestroy()
	{
	}

	public void SetSpawnTarget(Transform target, Vector3 offset = default(Vector3))
	{
	}

	public void SetSkip()
	{
	}

	public void Show(int count, Action callback = null)
	{
	}

	private void Make(Vector2 pos, bool invokeCallback, bool onlyOne, bool toLocal)
	{
	}

	private void Remove(RectTransform eo)
	{
	}

	private bool ApplyByBlurActivatedState()
	{
		return false;
	}
}
