using System.Collections.Generic;

public static class ExtraStatBuffTagList
{
	public static Dictionary<int, List<string>> StatTags;

	private static Dictionary<string, (BuffManager.StatType, BuffManager.StatValueType)> _statFromTag;

	public static Dictionary<string, (BuffManager.StatType statType, BuffManager.StatValueType statValueType)> StatFromTag => null;
}
