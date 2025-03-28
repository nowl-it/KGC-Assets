using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionPanel_BaseTab : MonoBehaviour
{
	[SerializeField]
	private GameObject _clearedMissionCountBadge;

	[SerializeField]
	private Text _clearedMissionCountBadgeText;

	[SerializeField]
	private Text[] _tabNameTexts;

	[SerializeField]
	private ConditionalBase[] _iconPositionConditionals;

	[SerializeField]
	private GameObject _lockedObject;

	private List<int> _connectedTabs;

	public bool isLocked { get; private set; }

	public void Init(string name, List<int> connectedTabs)
	{
	}

	public string GetTabName()
	{
		return null;
	}

	public void SetLocked(bool isLocked)
	{
	}

	public void SetClearedMissionCount(int count)
	{
	}

	public void SetConditionalPosition(bool enabled)
	{
	}

	public void WithConnectedTabs(Action<int, bool> action)
	{
	}
}
