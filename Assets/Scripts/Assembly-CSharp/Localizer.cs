using System.Collections.Generic;
using UnityEngine;

public class Localizer
{
	public enum Locale
	{
		None = 0,
		KR = 1,
		EN_US = 2,
		ZH_CH = 3,
		ZH_TW = 4,
		JA = 5,
		DE = 6,
		ES_LA = 7,
		FR = 8,
		PT_BR = 9,
		TH = 10,
		VI = 11,
		RU = 12,
		AR = 13
	}

	private static Localizer _singleton;

	public bool preInitialized;

	public bool initialized;

	public Locale currentLocale;

	private List<ILocalizedComponent> pendings;

	public static Locale[] LOCALES;

	private Dictionary<string, string> _stringMap;

	private Dictionary<string, string> _KRStringMap;

	private Transform _canvasRoot;

	public static Localizer Instance => null;

	public Transform canvasRoot => null;

	private Localizer()
	{
	}

	public void PreInitialize(Locale locale = Locale.None)
	{
	}

	public void Initialize(Locale locale = Locale.None)
	{
	}

	private void LoadSimpleTextResources()
	{
	}

	private void ParseTextAsset(Locale locale, TextAsset text)
	{
	}

	public void AddPending(ILocalizedComponent pending)
	{
	}

	public void ChangeLocale(Locale locale)
	{
	}

	public string FindKeyByText(string key)
	{
		return null;
	}

	public string Localize(string key)
	{
		return null;
	}

	public List<string> GetAllPrefixedKey(string prefix)
	{
		return null;
	}

	public string Localize(string key, string @default)
	{
		return null;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public string LocalizeFromKorean(string korean)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void SetCanvasRoot(Transform root)
	{
	}

	public void AddText(string key, string text)
	{
	}

	public string GetKorean(string key)
	{
		return null;
	}
}
