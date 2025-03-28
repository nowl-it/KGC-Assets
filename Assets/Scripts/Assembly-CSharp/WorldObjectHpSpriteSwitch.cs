using System;
using UnityEngine;

public class WorldObjectHpSpriteSwitch : WorldObjectHp
{
	public enum Type
	{
		Value = 1,
		Ratio = 2
	}

	[Serializable]
	public class ValueSpritePair
	{
		public float value;

		public Sprite sprite;
	}

	public Type type;

	public SpriteRenderer targetRenderer;

	public ValueSpritePair[] pairs;

	public override void OnChanged(int hp, int maxHp)
	{
	}
}
