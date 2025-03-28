using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class StarterMissionPanel_Base : MissionPanel_Base
{
	[SerializeField]
	private Text _subStepTitleText;

	[SerializeField]
	private GameObject _lockObject;

	private int _currentStep;

	private StarterMissionPanel _parent => null;

	public void OnClickMoveTab(bool right)
	{
	}

	public void MoveToTab(int idx)
	{
	}

	protected override void OnClickTab(int idx)
	{
	}

	protected override void SortMission(List<MissionData> missionDatas)
	{
	}

	public void ReloadStep(List<MissionData>[] cachedMissionDatas, string[] tabNames, List<int>[] connectedTabs, int step)
	{
	}

	private void SetLocked(bool v)
	{
	}
}
