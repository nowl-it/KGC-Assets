public class ClanMissionPanel : MissionPanel
{
	protected override void Init()
	{
	}

	public new static bool CheckShowCondition(int tabIdx, ResourceMission resMission, bool isConditionForClearedCountBadge)
	{
		return false;
	}

	public new static int GetTotalClearedMissionCount()
	{
		return 0;
	}

	protected override void OnReceive(MissionPanel_Base panelBase)
	{
	}

	protected override string ReloadTimeLeftUntilNextMission(int tabIdx)
	{
		return null;
	}

	protected override void BeforeShow()
	{
	}
}
