using System;
using System.Collections.Generic;
using UnityEngine;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AccessoryModel : IEquatable<AccessoryModel>
	{
		[Serializable]
		public class AccessoryData
		{
			public string mainStat;

			public List<SubStatKeyValues> subStats;
		}

		[Serializable]
		public class SubStatKeyValues
		{
			public string key;

			public float value;

			public SubStatKeyValues(string key, float value)
			{
			}
		}

		public int id;

		public int accountId;

		public int unitId;

		public int slot;

		public int type;

		public ResourceTreasure.Rarity rarity;

		public int level;

		public int exp;

		public int synergy;

		public int state;

		public AccessoryData data;

		public string coolTimeEndAt;

		public string createdAt;

		public string updatedAt;

		public List<int> usedThemeList;

		public bool isEarlyAccessModeTestAccessory;

		private Func<string, SubStatKeyValues, int> getScore;

		public string usedThemeListText => null;

		public DateTime createdAt_ => default(DateTime);

		public DateTime updatedAt_ => default(DateTime);

		public DateTime coolTimeEndAt_ => default(DateTime);

		public List<int> GetUsedThemeList()
		{
			return null;
		}

		public void CopyFrom(AccessoryModel accessory)
		{
		}

		public Sprite GetIcon(bool synergyActivated = false)
		{
			return null;
		}

		public string GetName()
		{
			return null;
		}

		public float GetMainStat(TreasureModel treasure = null)
		{
			return 0f;
		}

		public ResourceAccessoryConstant.AccessoryTypeInfo.AccessoryType GetAccType()
		{
			return default(ResourceAccessoryConstant.AccessoryTypeInfo.AccessoryType);
		}

		public int GetScore(string stat = "")
		{
			return 0;
		}

		public Dictionary<string, float> GetSubStatsDict()
		{
			return null;
		}

		public AccessoryModel CloneForUIDummy(int slot)
		{
			return null;
		}

		public bool Equals(AccessoryModel other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
