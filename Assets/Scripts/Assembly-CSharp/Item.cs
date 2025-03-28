using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Awesomepiece.Model;
using Protocol;
using UnityEngine;
using UnityEngine.Rendering;

public class Item : IResourceValue
{
	[Serializable]
	public class Option : IResourceValue
	{
		public string key;

		public string value;

		public bool isRandomOption;

		public bool isFixedOption;

		public bool alreadyEffected;

		public int valueAdded;

		public Option()
		{
		}

		public Option(Option from)
		{
		}

		public Option(OptionForServer from)
		{
		}

		public virtual string GetDesc(Color color = default(Color), Func<float, float> advanceItemAdaptabilityFunc = null)
		{
			return null;
		}

		public bool HasEffect()
		{
			return false;
		}

		public int GetValueInt(string key, int @default = -1)
		{
			return 0;
		}

		public float GetValueFloat(string key, float @default = -1f)
		{
			return 0f;
		}

		public string GetValueText(string key, string @default = null)
		{
			return null;
		}

		public bool GetValueBool(string key, bool @default = false)
		{
			return false;
		}

		public bool HasValue(string key)
		{
			return false;
		}

		public List<(string, string)> GetAllValues()
		{
			return null;
		}
	}

	[Serializable]
	public class OptionForServer
	{
		[XmlAttribute(AttributeName = "Key")]
		public string key;

		[XmlAttribute(AttributeName = "Value")]
		public string value;

		[XmlIgnore]
		public bool isRandomOption;

		[XmlIgnore]
		public bool isFixedOption;

		[XmlIgnore]
		public bool alreadyEffected;

		[XmlIgnore]
		public bool valueAdded;

		public OptionForServer()
		{
		}

		public OptionForServer(Option option)
		{
		}
	}

	public enum GodItemFromType
	{
		None = -1,
		Boss = 0,
		Building20 = 1,
		Building25 = 2
	}

	public ResourceItem resItem;

	public List<Option> options;

	public bool matkSwapped;

	public float ratio;

	public bool artifactAdjusted;

	public bool isTemporal;

	public SerializedDictionary<string, int> customStacks;

	private int _minusGold;

	public Action<ItemUnit> onItemAdded;

	public int[] artifactAddedValues;

	public int[] buildingAddedValues;

	public GodItemFromType godItemFromType;

	public bool doubleLevelUp;

	public GameUnit owner;

	public BattleManager battle;

	public int minusGold
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Item()
	{
	}

	public Item(BattleManager battleManager)
	{
	}

	public Item(BattleManager battle, int id, bool alreadyEffected = false, bool except4TierOption = false, bool isTemporal = false, int? seed = null)
	{
	}

	public void InitializeById(BattleManager battle, int id)
	{
	}

	public void InitializeFromProto(BattleManager battle, Protocol.Item item)
	{
	}

	public Item(BattleManager battle, int id, List<Option> itemOptions, bool isTemporal = false)
	{
	}

	public Item(BattleManager battle, int id, ICollection<OptionForServer> itemOptions, bool isTemporal = false)
	{
	}

	public static Item CreateItemForArenaPreset(BattleManager battle, int id, List<Item> prevRoundItems)
	{
		return null;
	}

	public bool IsBannedOptionFromTheme(string key)
	{
		return false;
	}

	private void AddRandomOption(int index, bool alreadyEffected, bool except4TierOption, int? seed = null)
	{
	}

	public void SetRatio(float v)
	{
	}

	public void SetMAtkSwap(bool v)
	{
	}

	public void AddOrMergeValue(string key, string value, bool isRandomOption = false, bool isFixedOption = false, bool alreadyEffected = false, int valueAdded = 0)
	{
	}

	public List<OptionForServer> GetDividedValues()
	{
		return null;
	}

	public virtual void TierUp(Item mergedWith, BattleManager battleManager, bool isMeleeUnit = false)
	{
	}

	public virtual bool CanMergeWith(Item other)
	{
		return false;
	}

	public virtual bool CanTierUp()
	{
		return false;
	}

	public virtual int GetValueInt(string key, int @default = -1)
	{
		return 0;
	}

	public virtual float GetValueFloat(string key, float @default = -1f)
	{
		return 0f;
	}

	public virtual string GetValueText(string key, string @default = null)
	{
		return null;
	}

	public virtual bool GetValueBool(string key, bool @default = false)
	{
		return false;
	}

	protected virtual string GetValue(string key)
	{
		return null;
	}

	public virtual List<(string, string)> GetAllValues()
	{
		return null;
	}

	private Option GetOption(string key)
	{
		return null;
	}

	public virtual bool HasValue(string key)
	{
		return false;
	}

	private void RemoveOption(string key)
	{
	}

	private void ChangeKey(string target, string newKey)
	{
	}

	private void ChangeValue(string target, string newValue)
	{
	}

	private void ChangeKeyValue(string target, string newKey, string newValue)
	{
	}

	public virtual string GetDesc()
	{
		return null;
	}

	public virtual string GetFullDesc()
	{
		return null;
	}

	public virtual string GetRepresentativeValue()
	{
		return null;
	}

	public List<Option> GetFixedOptions()
	{
		return null;
	}

	public List<Option> GetRandomOptions()
	{
		return null;
	}

	private void ResetBuildingAddedOption()
	{
	}

	public Item AdjustOptions()
	{
		return null;
	}

	public Item AdjustOptions(List<ArtifactModel> artifacts = null, BuildingInfo[] buildingInfos = null)
	{
		return null;
	}

	public Item AdjustOptions(List<ArtifactModel> artifacts = null, int[] buildingLevels = null)
	{
		return null;
	}

	public Item AdjustArtifactOption()
	{
		return null;
	}

	public Item AdjustArtifactOption(List<ArtifactModel> artifacts)
	{
		return null;
	}

	public Item AdjustBuildingOption(BuildingInfo[] buildingInfos = null)
	{
		return null;
	}

	public Item AdjustBuildingOption(int[] buildingLevels = null)
	{
		return null;
	}

	public List<OptionForServer> OptionToServerOption()
	{
		return null;
	}

	public static List<Option> ServerOptionToOption(List<OptionForServer> optionForServers)
	{
		return null;
	}

	protected void MergeItemStacks(Item mergedWith)
	{
	}

	public Scene_Game.SaveRogueLikeItemData ToRogueLikeSaveData()
	{
		return null;
	}

	public Protocol.Item SaveProto(bool saveRandomOptionOnly = true)
	{
		return null;
	}
}
