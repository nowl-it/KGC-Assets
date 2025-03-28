using UnityEngine;

public class TerritoryTycoonMissionPanel : MissionPanel
{
	[SerializeField]
	private MissionPanel_Base _missionPanelBase;

	protected override void Init()
	{
	}

	public void Show()
	{
	}

	private new static bool CheckShowCondition(int tabIdx, ResourceMission resMission, bool isConditionForClearedCountBadge)
	{
		return false;
	}

	public void ReloadClearedMissionCountBadge()
	{
	}

	private new int GetTotalClearedMissionCount()
	{
		return 0;
	}

	protected override string ReloadTimeLeftUntilNextMission(int tabIdx)
	{
		return null;
	}

	protected override void OnReceive(MissionPanel_Base panelBase)
	{
	}
}
