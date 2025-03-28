using System.Collections.Generic;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class SpawnManager
{
	public BattleManager battleManager;

	public void InitStage(ObscuredInt devilEffectCount, DevilPanel.Condition devilCond)
	{
	}

	public void GenSpawnData(Dictionary<int, List<ResourceStage.Spawn>> data, int team, int addLevel, Dictionary<int, List<int>> usedPos)
	{
	}

	public void BatchValueSumEnemies(int valueSum, int addLevel, ResourceStage resStage, List<ResourceUnit> enemyPool, Dictionary<int, List<int>> usedPos, List<(int, int)> defaultGen, bool batchSameLine, bool batchWithEmpty)
	{
	}

	public GameUnit BatchAIUnit(int id, Vector2Int pos, int level, int team = 2, int boss = 0, List<int> equips = null, bool reBatch = false, int cardLevel = 1, int[] buildingLevels = null, int skin = 0, List<ArtifactModel> artifacts = null, int poolIdx = -1, int potentialSlot = -1, bool equipExcept4TierOption = false, int potentialTier = 0, bool loaded = false, TreasureModel treasure = null, List<AccessoryModel> accessories = null, bool skipAnimation = false)
	{
		return null;
	}

	public GameUnit SpawnUnit(Vector2 pos, int id, int team, int level = 1, int cardLevel = 1, int[] buildingLevels = null, int skin = 0, List<ArtifactModel> artifacts = null, int poolIdx = -1, int potentialSlot = -1, int potentialTier = 0, GameUnit parent = null, TreasureModel treasure = null, List<AccessoryModel> accessories = null)
	{
		return null;
	}

	public void HandleSpawnInfoList(List<ResourceStage.Spawn> spawnInfoList, int team, GameUnit target = null)
	{
	}

	public GameUnit SummonUnit(GameUnit from, int id, GameUnit parent = null, int team = -1)
	{
		return null;
	}

	public GameUnit SummonUnit(Vector2Int tilePos, int id, int level, int team, GameUnit from, int skin = 0, int cardLevel = 1, int[] buildingLevels = null, List<ArtifactModel> artifacts = null, int poolIdx = -1, bool delay = false, int potentialSlot = -1, int potentialTier = 0, TreasureModel treasure = null, List<AccessoryModel> accessories = null)
	{
		return null;
	}

	public GameUnit SummonInvisibleMimicUnit(GameUnit gameUnit, Vector2Int tilePos, int team, GameUnit parent, int statPer = 100)
	{
		return null;
	}
}
