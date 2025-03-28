using UnityEngine;
using UnityEngine.UI;

public static class TextSizeUtility
{
	private static TextGenerator _textGenerator;

	private static Canvas _targetCanvas;

	private static Text _targetText;

	public static void SetTextGenTarget(Canvas canvas, Text text)
	{
	}

	public static float GetTextWidth(string text, Canvas canvas, Text targetText)
	{
		return 0f;
	}

	public static float GetTextHeight(string text, float areaWidth = -1f)
	{
		return 0f;
	}

	private static float GetPixelsPerUnit(Canvas canvas, Text targetText)
	{
		return 0f;
	}

	public static TextGenerationSettings GetGenerationSettings(Vector2 extents, Text targetText, float ppu)
	{
		return default(TextGenerationSettings);
	}
}
