using UnityEngine.UI;

public static class TypeTextComponentUtility
{
	public static void TypeText(this Text label, string text, string preText = "", float speed = 0.05f, TypeTextComponent.OnComplete onComplete = null)
	{
	}

	public static bool IsSkippable(this Text label)
	{
		return false;
	}

	public static void SkipTypeText(this Text label)
	{
	}
}
