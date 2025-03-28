using System;

[Serializable]
public class Settings
{
	public const float FX_UNIT_ATK_RATIO = 0.5f;

	public const float FX_UNIT_SKILL_RATIO = 0.7f;

	public float bgmVolume;

	public float fxVolume;

	public bool bgmOn;

	public bool fxOn;

	public string newLocale;
}
