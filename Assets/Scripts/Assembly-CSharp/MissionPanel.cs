using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;

public class MissionPanel : MonoBehaviour, IClosable
{
	protected List<MissionData>[] _cachedMissionDatas;

	private bool _isInitialized;

	protected string[] _tabNames;

	protected List<int>[] _connectedTabs;

	protected MissionPanel_Base.PanelType _panelType;

	protected int _panelBaseHeight;

	protected int _panelBoxBottom;

	protected Func<int, ResourceMission, bool, bool> _checkShowConditionFunc;

	protected MissionPanel_Base _basePanel;

	protected virtual void Init()
	{
	}

	public void Show(MissionPanel_Base basePanel)
	{
	}

	public static bool CheckShowCondition(int tabIdx, ResourceMission resMission, bool isConditionForClearedCountBadge)
	{
		return false;
	}

	public static int GetTotalClearedMissionCount()
	{
		return 0;
	}

	protected virtual void OnReceive(MissionPanel_Base panelBase)
	{
	}

	protected virtual void BeforeShow()
	{
	}

	protected virtual string ReloadTimeLeftUntilNextMission(int tabIdx)
	{
		return null;
	}

	private void Update()
	{
	}

	private static bool CheckNormalMissionShowCondition(ResourceMission resMission)
	{
		return false;
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
