using UnityEngine;

public struct DamageShootData
{
	public enum Type
	{
		PhysicalDamage = 0,
		MagicDamage = 1,
		SpecialDamage = 2,
		Heal = 3,
		Mana = 4,
		Shield = 5,
		ManaBurn = 6,
		Consume = 7,
		Drain = 8,
		RemoveShield = 9,
		None = 10
	}

	public int value;

	public Type type;

	public const int Miss = -1;

	public const int Block = -2;

	public const int MagicBlock = -3;

	public const int PhysicalBlock = -4;

	public Vector2 offset;

	public bool isCritical;
}
