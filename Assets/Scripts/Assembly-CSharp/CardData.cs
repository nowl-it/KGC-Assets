using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class CardData
{
	public ObscuredInt unitId;

	public ObscuredInt level;

	public ObscuredInt exp;

	public ObscuredInt originLevel;

	public bool isLevelSynced;

	public int soul;

	public string createdAt;

	public List<int> skins;

	public ObscuredInt currentSkin;

	public ObscuredInt accountId;

	public string accountName;

	public ObscuredInt potentialTier;

	public ObscuredInt originPotentialTier;

	public int potential;

	public TreasureModel treasureModel;

	public List<AccessoryModel> accessoryModels;

	public bool isLevelSyncApplied => false;

	public DateTime createdAt_ => default(DateTime);

	public CardData Clone()
	{
		return null;
	}

	public CardData()
	{
	}

	public CardData(int unitId, int level, int exp, List<int> skins = null, int currentSkin = 0)
	{
	}

	public bool IsSupporter()
	{
		return false;
	}

	public void SetIllust(Image illust, bool useVerticalLayout = false, float customScale = 1f)
	{
	}

	public void SetIllust(Image illust, Vector3 customOffset, bool useVerticalLayout = false, float customScale = 1f)
	{
	}

	public static void SetIllustOffSet(Transform transform, ResourceUnit resUnit, ResourceSkin resSkin, Vector3 customOffset, bool useVerticalLayout = false, float customScale = 1f)
	{
	}

	public Color GetGradationColor()
	{
		return default(Color);
	}

	public int AccessorySynergyCount()
	{
		return 0;
	}
}
