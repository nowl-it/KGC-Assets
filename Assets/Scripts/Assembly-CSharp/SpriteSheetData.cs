using System;
using UnityEngine;

public class SpriteSheetData : ScriptableObject
{
	[Serializable]
	public class Sheet
	{
		public string name;

		public Sprite[] sprites;
	}

	public Sheet[] sheets;

	public Sheet GetSheet(string name)
	{
		return null;
	}
}
