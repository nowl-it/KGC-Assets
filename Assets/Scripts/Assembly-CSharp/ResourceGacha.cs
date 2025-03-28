using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceGacha : ResourceBase<ResourceGacha>
{
	public enum Type
	{
		WelcomeGacha = 0,
		UnitGacha = 1,
		ArtifactGacha = 2,
		NewUnitGacha = 3,
		CustomUnitGacha = 4,
		TreasureGacha = 5,
		CustomTreasureGacha = 6
	}

	public class Result
	{
		public ResourceShopItem.Type type;

		public string typeForDesc;

		public float rate;

		public int rank;

		public int min;

		public int max;

		public int total;
	}

	public class Pickup
	{
		public ResourceShopItem.Type type;

		public int id;

		public float rate;

		public int customPoolSize;

		public int poolId;

		public ResourceTreasure.Rarity rarity;

		public float illustOffsetX;

		public float illustOffsetY;

		public float illustScaleX;

		public float illustScaleY;
	}

	public class FixedArtifact
	{
		public ResourceArtifact.FromType fromType;

		public ResourceArtifact.Level level;

		public float rate;

		public int id;
	}

	public class FixedTreasure
	{
		public int poolId;

		public ResourceTreasure.Rarity rarity;

		public float rate;

		public int id;
	}

	public class FixedTreasurePool
	{
		public ResourceTreasure.Rarity rarity;

		public int[] ppol;
	}

	public class Image
	{
		public string image;

		public Color color;

		public float x;

		public float y;

		public float scaleX;

		public float scaleY;

		public bool mask;
	}

	public class GachaCeil
	{
		public string ceilKey;

		public string target;

		public int ceilCount;

		public int poolId;
	}

	private string _desc;

	private string _resultTableDesc;

	public Type type;

	public string gachaIcon;

	public int keyItem;

	public string stackIcon;

	public string tagImage;

	public bool visible;

	public int gachaBoxIndex;

	private string _levelLimit;

	public float allExpToUnitExpItemRate;

	public int additionalUnitSoulMaxLimit;

	public bool useStack;

	public bool isPermanent;

	public bool exceptPickupOwnUnit;

	public bool exceptPickupDefaultUnit;

	public bool exceptPickupWelcomeUnit;

	public int sortingOrder;

	public int minVersion;

	public int parent;

	public List<int> children;

	public List<int> welcomeUnitList;

	public bool showTimeLeft;

	public int newUserOpenDuringDay;

	private DateTime _startDate;

	private DateTime _endDate;

	public string backgroundPrefab;

	public Color backgroundPrefabGachaNameTextColor;

	public Color backgroundPrefabGachaNameTextOutlineColor;

	public List<Result> results;

	public List<Pickup> pickups;

	public List<FixedArtifact> fixedArtifacts;

	public List<FixedTreasure> fixedTreasures;

	public int fixedTreasureGachaCount;

	public List<FixedTreasurePool> fixedTreasurePool;

	public List<Image> images;

	public List<GachaCeil> gachaCeils;

	public bool enableCeilSelect;

	public string desc => null;

	public string resultTableDesc => null;

	public int levelLimit => 0;

	public DateTime startDate => default(DateTime);

	public DateTime endDate => default(DateTime);

	public string GetTypeName()
	{
		return null;
	}

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
