using System.Collections.Generic;

public interface IResourceValue
{
	int GetValueInt(string key, int @default = -1);

	float GetValueFloat(string key, float @default = -1f);

	string GetValueText(string key, string @default = null);

	bool GetValueBool(string key, bool @default = false);

	bool HasValue(string key);

	List<(string, string)> GetAllValues();
}
