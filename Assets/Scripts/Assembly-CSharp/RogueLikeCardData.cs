using System;

[Serializable]
public class RogueLikeCardData : CardData
{
	[Serializable]
	public struct SaveData
	{
		public int unitId;

		public int exp;

		public int level;

		public int potential;

		public int potentialTier;

		public int currentSkin;
	}

	public GameUnit gameUnit;

	public RogueLikeCardData()
	{
	}

	public RogueLikeCardData(CardData cardData)
	{
	}

	public RogueLikeCardData(SaveData saveData)
	{
	}

	public SaveData ToSaveData()
	{
		return default(SaveData);
	}
}
