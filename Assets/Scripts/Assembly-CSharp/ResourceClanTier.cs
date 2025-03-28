using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;
using JetBrains.Annotations;

public class ResourceClanTier : ResourceBase<ResourceClanTier>, IRecursiveInheritable<ResourceClanTier>
{
	public class ClanSkillData<T>
	{
		public T value;

		private Func<T, bool, string> _valueRepresenter;

		public string key;

		[UsedImplicitly]
		public int tier;

		[UsedImplicitly]
		public int nextReqLevel;

		public ClanSkillData(IRecursiveInheritable<ResourceClanTier> resource, string key, Func<IRecursiveInheritable<ResourceClanTier>, string, T> valueParser)
		{
		}

		public ClanSkillData(IRecursiveInheritable<ResourceClanTier> resource, string key, Func<IRecursiveInheritable<ResourceClanTier>, string, T> valueParser, Func<T, List<string>> valueArgsConverter)
		{
		}

		[CanBeNull]
		[UsedImplicitly]
		public string GetDesc(bool coloring)
		{
			return null;
		}
	}

	public class HeroSupportData
	{
		public int countPerRequest;

		public int dailyCountPerMember;

		public int cardExpPerRequest;

		public List<Reward> rewards;

		public static List<string> ToRepresentArgs(HeroSupportData data)
		{
			return null;
		}
	}

	public int reqPoint;

	public int level;

	[UsedImplicitly]
	public ClanSkillData<int> clanShopSale;

	[UsedImplicitly]
	public ClanSkillData<int> attendanceToken;

	[UsedImplicitly]
	public ClanSkillData<int> attendancePoint;

	[UsedImplicitly]
	public ClanSkillData<int> maxClanMember;

	[UsedImplicitly]
	public ClanSkillData<int> goldBonus;

	[UsedImplicitly]
	public ClanSkillData<HeroSupportData> heroSupport;

	public XmlNode xmlNode;

	public int inheritFrom;

	private static List<ResourceClanTier> _levelSortedData;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static ResourceClanTier GetByLevel(int levelIndex)
	{
		return null;
	}

	public static int GetMaxTier()
	{
		return 0;
	}

	public IRecursiveInheritable<ResourceClanTier> GetParentResource()
	{
		return null;
	}

	public XmlNode GetXmlNode()
	{
		return null;
	}
}
