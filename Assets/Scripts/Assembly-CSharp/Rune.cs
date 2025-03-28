using System.Collections.Generic;

public class Rune : Item
{
	public List<string> subDesc;

	public Rune()
	{
	}

	public Rune(BattleManager battle)
	{
	}

	public Rune(BattleManager battle, int id)
	{
	}

	public Rune(BattleManager battle, ResourceItem item)
	{
	}

	public override void TierUp(Item mergedWith, BattleManager battleManager, bool isMeleeUnit = false)
	{
	}

	public override bool CanMergeWith(Item other)
	{
		return false;
	}

	public override int GetValueInt(string key, int @default = -1)
	{
		return 0;
	}

	public override float GetValueFloat(string key, float @default = -1f)
	{
		return 0f;
	}

	public override string GetValueText(string key, string @default = null)
	{
		return null;
	}

	public override bool GetValueBool(string key, bool @default = false)
	{
		return false;
	}

	protected override string GetValue(string key)
	{
		return null;
	}

	public override List<(string, string)> GetAllValues()
	{
		return null;
	}

	public override bool HasValue(string key)
	{
		return false;
	}

	public override string GetDesc()
	{
		return null;
	}

	public override string GetFullDesc()
	{
		return null;
	}

	public override string GetRepresentativeValue()
	{
		return null;
	}

	public void GetSubDescWithItemIndex()
	{
	}
}
