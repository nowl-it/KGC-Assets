using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceSeasonPass : ResourceBase<ResourceSeasonPass>
{
	public class RewardItem
	{
		public bool passOnly;

		public bool premiumOnly;

		public string type;

		public int id;

		public int count;

		public RewardItem(XmlNode node, bool passOnly, bool premiumOnly = false)
		{
		}
	}

	public class Reward
	{
		public int level;

		public RewardItem baseReward;

		public RewardItem passOnlyReward;

		public RewardItem premiumOnlyReward;
	}

	public class BonusReward
	{
		public int id;

		public int canBuyCount;

		public int passPlusCanBuyCount;

		public int pointCost;

		public RewardItem reward;
	}

	public enum SpecialSeasonEventType
	{
		None = 0,
		TerritoryTycoon = 1
	}

	public int maxLevel;

	public int lvUpReqPoint;

	public List<Reward> rewards;

	public List<BonusReward> bonusRewards;

	public int benefitTextCount;

	public int passPlusBenefitTextCount;

	public int shopItem;

	public int passPlusShopItem;

	public int passPlusUpgradeShopItem;

	public int passPremiumShopItem;

	public int passPremiumUpgradeFromNormalShopItem;

	public int passPremiumUpgradeFromPlusShopItem;

	public int passSkin;

	public int passUnit;

	public int passGold;

	public int passPremiumGold;

	public string skinImage;

	public float passSkinOffsetX;

	public float passSkinOffsetY;

	public float passSkinScale;

	public float transformPassSkinOffsetX;

	public float transformPassSkinOffsetY;

	public float transformPassSkinScale;

	public float eventShopTokenOffsetX;

	public float eventShopTokenOffsetY;

	public float eventShopPanelTokenScale;

	public float passButtonSkinOffsetX;

	public float passButtonSkinOffsetY;

	public bool passButtonSkinFlip;

	public float passSkinIllustOffsetX;

	public float passSkinIllustOffsetY;

	public float passSkinIllustScale;

	public string seasonalEventTitleColor;

	public string seasonalEventTitleOutlineColor;

	public SpecialSeasonEventType specialSeasonEventType;

	public override void Init(XmlNode n)
	{
	}

	public Reward GetReward(int level)
	{
		return null;
	}

	public BonusReward GetBonusReward(int bonusId)
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
