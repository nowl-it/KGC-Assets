using UnityEngine;

public class ColosseumOpenEventMissionPanel : MissionPanel
{
	[SerializeField]
	private ColosseumOpenEventPanel _eventPanel;

	[SerializeField]
	private GetMoneyEffect _pointGetEffect;

	public GetMoneyEffect pointGetEffect => null;

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

	protected override void BeforeShow()
	{
	}

	public void ReloadEventPanel()
	{
	}

	public static bool IsEventAvailable()
	{
		return false;
	}

	public void HandleGetMissionPoint(int curPoint)
	{
	}
}
