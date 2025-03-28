public static class AwesomePrefs
{
	public static string keyPrefix;

	private static readonly string[] encryptingKeys;

	private static string ToPrefixedKey(string key)
	{
		return null;
	}

	public static float GetFloat(string key, float defaultValue = -1f, bool applyPrefix = true)
	{
		return 0f;
	}

	public static int GetInt(string key, int defaultValue = -1, bool applyPrefix = true)
	{
		return 0;
	}

	public static string GetString(string key, string defaultValue = "", bool applyPrefix = true)
	{
		return null;
	}

	public static void SetFloat(string key, float value, bool applyPrefix = true)
	{
	}

	public static void SetInt(string key, int value, bool applyPrefix = true)
	{
	}

	public static void SetString(string key, string value, bool applyPrefix = true)
	{
	}

	public static void DeleteAll()
	{
	}

	public static void DeleteKey(string key, bool applyPrefix = true)
	{
	}

	public static bool HasKey(string key, bool applyPrefix = true)
	{
		return false;
	}

	public static void Save()
	{
	}

	public static string AppendRepoPathPrefix(string key)
	{
		return null;
	}
}
