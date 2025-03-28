using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeRoom : MonoBehaviour
{
	[Serializable]
	public struct SaveData
	{
		public ResourceRogueLikeRoom.Type type;

		public Vector2Int gridPos;

		public bool isCleared;

		public bool isEntered;

		public bool canShowBattleRoomSecondReward;

		public List<ResourceRogueLikeRoom.Spawn> savedSpawns;

		public int savedTrialEventTrigger;
	}

	public RogueLikeLevelGenerator generator;

	private Vector2Int _gridPos;

	private ResourceRogueLikeRoom.Type _type;

	public ConditionalImage roomImage;

	public Image checkMark;

	public Image fogOfWar;

	public bool canShowBattleRoomSecondReward;

	public bool isEntered;

	public bool isCleared;

	public int savedTrialEventTrigger;

	public List<ResourceRogueLikeRoom.Spawn> savedSpawns;

	private int _eventRoomExceptionHandleCount;

	public Vector2Int gridPos => default(Vector2Int);

	public ResourceRogueLikeRoom.Type type => default(ResourceRogueLikeRoom.Type);

	public void Init(Vector2Int gridPos, ResourceRogueLikeRoom.Type type)
	{
	}

	public void ExitRoom()
	{
	}

	public void EnterRoom()
	{
	}

	public void ActiveCheckMark()
	{
	}

	public void OnClick()
	{
	}

	public bool IsNeighbor(RogueLikeRoom target)
	{
		return false;
	}

	public void SetFogOfWar(bool set)
	{
	}

	public SaveData ToSaveData()
	{
		return default(SaveData);
	}
}
