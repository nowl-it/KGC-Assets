using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TreasureModel : IEquatable<TreasureModel>
	{
		public int id;

		public int treasureId;

		public int accountId;

		public int level;

		public int exp;

		public int overcome;

		public int unitId;

		public int state;

		public string coolTimeEndAt;

		public string createdAt;

		public string updatedAt;

		public List<int> usedThemeList;

		public bool isEarlyAccessModeTestTreasure;

		public string usedThemeListText => null;

		public DateTime coolTimeEndAt_ => default(DateTime);

		public DateTime createdAt_ => default(DateTime);

		public DateTime updatedAt_ => default(DateTime);

		public ResourceTreasure resTreasure => null;

		public List<int> GetUsedThemeList()
		{
			return null;
		}

		public void CopyFrom(TreasureModel treasure)
		{
		}

		public int GetMaxLevel()
		{
			return 0;
		}

		public ResourceBuffData GetResBuffData()
		{
			return null;
		}

		public string GetSkillDesc()
		{
			return null;
		}

		public float GetOvercomeSlotUpgradePer(int slot)
		{
			return 0f;
		}

		public bool Equals(TreasureModel other)
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
