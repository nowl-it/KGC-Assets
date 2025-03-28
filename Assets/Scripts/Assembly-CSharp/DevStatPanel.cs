using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevStatPanel : MonoBehaviour
{
	private class StatObj
	{
		public GameObject gameObject;

		public Text text;

		public Button button;
	}

	[SerializeField]
	private GameObject _statPrefab;

	[SerializeField]
	private RectTransform _statObjsRoot;

	[SerializeField]
	private FlexibleUIElements _statButtonElements;

	[SerializeField]
	private Tooltip _tooltip;

	private List<StatObj> _statObjects;

	private List<(string name, IntPtr valuePtr, Action onClick)> _statButtons;

	private bool _inited;

	private GameUnit _unit;

	private Action _currentStatObjClickedAction;

	private float _lastReloadTime;

	public void Show(GameUnit unit, bool resetScroll = true)
	{
	}

	private void Update()
	{
	}

	private void Reload()
	{
	}

	public void OnClickClose()
	{
	}

	private void OnClickStat(GameUnit unit, BuffManager.StatType statType, float originValue)
	{
	}

	private unsafe void SetStatLimit(float* statLimitPtr)
	{
	}

	private string GetStatSubText(GameUnit unit, BuffManager.StatType statType, float originValue)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private string GetStat(GameUnit unit, BuffManager.StatType statType)
	{
		return null;
	}
}
