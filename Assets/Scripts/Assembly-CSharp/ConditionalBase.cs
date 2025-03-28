using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ConditionalBase : MonoBehaviour
{
	public enum Condition
	{
		Equal = 1,
		NotEqual = 2,
		Less = 3,
		Greater = 4,
		LessEqual = 5,
		GreaterEqual = 6
	}

	[Serializable]
	public class ValueColorPair
	{
		public Condition condition;

		public int value;

		public Color color;

		public bool applyAlpha;
	}

	[Serializable]
	public class ValueSpritePair
	{
		public Condition condition;

		public int value;

		public Sprite sprite;

		public Color color;
	}

	[Serializable]
	public class ValueBoolPair
	{
		public Condition condition;

		public int value;

		public bool result;
	}

	[Serializable]
	public class ValueStringPair
	{
		public Condition condition;

		public int value;

		public string result;
	}

	[Serializable]
	public class ValueVector2Pair
	{
		public Condition condition;

		public int value;

		[FormerlySerializedAs("position")]
		public Vector2 result;
	}

	[Serializable]
	public class ValueVector3Pair
	{
		public Condition condition;

		public int value;

		[FormerlySerializedAs("position")]
		public Vector3 result;
	}

	[Serializable]
	public class ValueAnchorsPair
	{
		public Condition condition;

		public int value;

		public Vector2 anchorMin;

		public Vector2 anchorMax;
	}

	[Serializable]
	public class ValueGrayscalePair
	{
		public Condition condition;

		public int value;

		public Color color;

		[Range(0f, 1f)]
		public float grayscale;

		public bool applyAlpha;
	}

	[Serializable]
	public class ValueUIGrayscalePair
	{
		public Condition condition;

		public int value;

		public bool apply;
	}

	protected int _value;

	public int value => 0;

	public bool Check(int v, int goal, Condition condition)
	{
		return false;
	}

	public void SetValue(int value)
	{
	}

	public virtual void Reload(int value)
	{
	}
}
