using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

public class RogueLikeRewardFactory
{
	[Serializable]
	public class SaveData
	{
		public List<RogueLikeArtifactModel.SaveData> createdArtifacts;

		public List<Scene_Game.SaveItemData> createdItems;

		public SerializedDictionary<int, int> dismissedRunesWeightDict;
	}

	private static SaveData _saveData;

	private static List<Item> _createdItems;

	private static List<(ResourceItem resItem, int weight)>[] _runeWeightList;

	private static SerializedDictionary<int, int> _dismissedRunesWeightDict;

	public static List<RogueLikeArtifactModel> _createdArtifactModels;

	public static int GetRandomHeroOrExpItem(int tier, out bool isHero)
	{
		isHero = default(bool);
		return 0;
	}

	public static int GetRandomHero()
	{
		return 0;
	}

	public static int GetRandomHeroLevel(int addFloor = 0)
	{
		return 0;
	}

	public static int GetHeroTier(int level, bool isReward)
	{
		return 0;
	}

	public static int GetRandomEquipOrEquipLvUpItem(int tier, bool createAndCacheItem, out bool isEquip)
	{
		isEquip = default(bool);
		return 0;
	}

	public static ResourceItem GetRandomEquip(int tier, bool createAndCacheItem)
	{
		return null;
	}

	public static Item GetCreatedItem(int itemId)
	{
		return null;
	}

	public static void ClearCreatedItems()
	{
	}

	public static void AddItemToCreatedItems(Item item)
	{
	}

	public static int GetRandomRuneOrRuneLvUpItem(int tier, out bool isRune)
	{
		isRune = default(bool);
		return 0;
	}

	public static ResourceItem GetRandomRune(int tier)
	{
		return null;
	}

	public static void ClearCachedRuneWeightList()
	{
	}

	private static void CreateCachedRuneWeightListIfNull()
	{
	}

	public static void DismissRune(int id)
	{
	}

	public static void ClearDismissedRuneWeightList()
	{
	}

	public static int GetRandomArtifactOrArtifactUpgrade(int tier, out bool isArtifact)
	{
		isArtifact = default(bool);
		return 0;
	}

	public static int GetRandomArtifact(int tier)
	{
		return 0;
	}

	public static RogueLikeArtifactModel GetCreatedArtifactModel(int artifactId)
	{
		return null;
	}

	public static void ClearCreatedArtifactModels()
	{
	}

	public static int GetRandomGold(int tier)
	{
		return 0;
	}

	public static int GetRandomItem()
	{
		return 0;
	}

	public static SaveData ToSaveData()
	{
		return null;
	}

	public static void LoadFrom(SaveData saveData)
	{
	}
}
