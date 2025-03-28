using System;

public class RangeInfo
{
	public enum RangeType
	{
		None = 0,
		Self = 1,
		Sum = 2,
		Rect = 3,
		DiagonalRect = 4,
		Line = 5,
		Triangle = 6,
		DummyForSplashRange = 7,
		Cross = 8,
		Infinity = 9,
		DiagonalCross = 10
	}

	public enum Strategy
	{
		Near = 0,
		Far = 1,
		Random = 2,
		HighestLevel = 3,
		LowestHP = 4,
		LowestHPRatio = 5,
		HighestHP = 6,
		Custom = 7,
		HighestMAtk = 8,
		SameX = 9,
		Rear = 10
	}

	public enum RangeFrom
	{
		Target = 0,
		Dir = 1,
		Self = 2
	}

	public RangeType type;

	public Strategy strategy;

	public RangeFrom rangeFrom;

	public int x;

	public int y;

	public int sum;

	public bool useEightDir;

	public RangeInfo()
	{
	}

	public RangeInfo(RangeInfo target)
	{
	}

	public RangeInfo Rotate()
	{
		return null;
	}

	public RangeInfo Add(int value)
	{
		return null;
	}

	public bool IterateThroughTiles(int baseX, int baseY, int dirX, int dirY, Func<int, int, bool> callback, bool reverseX = false, bool reverseY = false)
	{
		return false;
	}

	public static bool IsRangeTypeUsesDir(RangeType type)
	{
		return false;
	}

	public static RangeInfo operator +(RangeInfo a, int b)
	{
		return null;
	}
}
