using System;
using System.Collections.Generic;
using System.Xml;

public class ResourcePvpEnemyPreset : ResourceBase<ResourcePvpEnemyPreset>
{
	public struct Spawn
	{
		public int x;

		public int y;

		public int unit;

		public int level;

		public int equip1;

		public int equip2;

		public int equip3;
	}

	public int theme;

	public string kingNameCont;

	public string castleNameCont;

	public int kingNamePost;

	public int castleNamePost;

	public int profileAvatar;

	public int mainBuilding;

	public int subBuilding;

	public int mainArtifact;

	public int subArtifact;

	public List<int> artifacts;

	public int[] deck;

	public List<Spawn> spawnData;

	public int cardLevelOffset;

	public int buildingLevelOffset;

	public string kingName => null;

	public string castleName => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
