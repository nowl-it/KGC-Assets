using Awesomepiece.Model;
using UnityEngine;

public class RogueLikeMissionItemBase : MonoBehaviour
{
	[SerializeField]
	private RogueLikeMissionItem _rogueLikeMissionItem;

	[SerializeField]
	private RogueLikeHiddenMissionItem _rogueLikeHiddenMissionItem;

	public void Set(MissionData missionData, bool check)
	{
	}

	public void Set(int count)
	{
	}
}
