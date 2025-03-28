using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceRogueLikeWorld : ResourceBase<ResourceRogueLikeWorld>
{
	public class Floor
	{
		public enum BossType
		{
			Altar = 0,
			WorldBoss = 1,
			FinalBoss = 2
		}

		public class RoomGenData
		{
			public ResourceRogueLikeRoom.Type roomType;

			public float ratio;

			public int depth;
		}

		public ResourceRogueLikeWorld world;

		public int enemyLevel;

		public int addEnemyValueSum;

		public List<int> fixedBattleStages;

		public int battleStagePoolStartId;

		public int battleStagePoolEndId;

		public int eliteStagePoolStartId;

		public int eliteStagePoolEndId;

		public int bossStagePoolStartId;

		public int bossStagePoolEndId;

		public int bossLevel;

		public int bossStatPer;

		public BossType bossType;

		public int numberOfRooms;

		public List<RoomGenData> roomGenDatas;

		public bool IsBattleStage(int stageID)
		{
			return false;
		}

		public bool IsEliteStage(int stageID)
		{
			return false;
		}
	}

	public string icon;

	public int nextWorld;

	public List<int> enemyThemes;

	public List<int> eliteThemes;

	public List<int> statPer;

	public List<Floor> floors;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
