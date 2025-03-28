using UnityEngine;

public class CommonData
{
	public enum Grid
	{
		Waiting = 0,
		Field = 1
	}

	public enum ItemType
	{
		Item = 0,
		Invade = 1,
		Ability = 2
	}

	public enum ChoiceUserSelectorType
	{
		LowestHp = 0,
		HighestGold = 1,
		HighestInvadeItemTierSum = 2,
		LowestFieldSize = 3,
		HighestAbilityExpSum = 4,
		HighestBerserkValue = 5
	}

	public class GridPosition
	{
		public Grid grid;

		public int posX;

		public int posY;

		public GridPosition(Grid grid, Vector2Int pos)
		{
		}
	}

	public class PlayerColosseumMetaData
	{
		public string userId;

		public int actionSeed;

		public int battleSeed;
	}

	public class ItemOption
	{
		public string key;

		public string value;

		public int flags;

		public ItemOption()
		{
		}

		public ItemOption(Item.Option option)
		{
		}

		public Item.Option ToOption()
		{
			return null;
		}
	}

	public class TarotParams
	{
		public int gold;

		public int invadeItemTierSum;

		public int fieldSize;

		public int abilityExpSum;
	}

	public const string ChoiceUserSelectorTypeFormat = "ColosseumTarotChoiceUserSelectorType_";

	public string key;

	public string value;

	public bool isRandomOption;

	public bool isFixedOption;

	public bool alreadyEffected;

	public bool valueAdded;
}
