using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceSkin : ResourceBase<ResourceSkin>
{
	public class ReplaceEffect
	{
		public string type;

		public List<int> targets;

		public string replaceSkillArrowPrefab;

		public Arrow.Type replaceSkillArrowType;

		public int arcHeight;

		public int arcHeightRandom;

		public List<(string key, ResourceSkill.Effect effect)> effects;

		public ReplaceEffect Copy()
		{
			return null;
		}
	}

	public class TransformInfo
	{
		public Vector2 transformSpriteOffset;

		public Vector2 transformPrefabOffset;

		public float transformHeight;

		public float transformHeightOffset;

		public string replaceSkillTransformPrefab;

		public string transformAtkSound;

		public string transformShotSound;

		public string transformSpriteName;

		public TransformInfo()
		{
		}

		public TransformInfo(XmlNode n, float defaultHeight, float defaultHeightOffset, XmlNode inherit = null)
		{
		}
	}

	public struct Value
	{
		public string key;

		public string value;
	}

	public int unit;

	private string _prefab;

	public string spriteName;

	public string uiSpriteName;

	public string illustName;

	public bool spriteInSheet;

	public float spriteOffsetX;

	public float spriteOffsetY;

	public float prefabOffsetX;

	public float prefabOffsetY;

	public float prefabPreviewScaleX;

	public float prefabPreviewScaleY;

	public float height;

	public float heightOffset;

	public float heightWhenBuff;

	public float heightWhenFullStack;

	private string _nameFormat;

	public string desc;

	public int cashPrice;

	public int skinTokenPrice;

	public List<ReplaceEffect> replaceUnitEffects;

	public List<ReplaceEffect> replaceSkillEffects;

	public string replaceUnitArrowPrefab;

	public bool showDefaultEffectIfReplacementNotExists;

	public string atkSound;

	public string shotSound;

	public string atkStartSound;

	public TransformInfo transformInfo;

	public Dictionary<int, TransformInfo> transformInfos;

	public Dictionary<int, List<string>> skillSounds;

	public Dictionary<int, List<string>> skillHitSounds;

	public Dictionary<int, List<string>> skillCastEndSounds;

	public Dictionary<int, List<string>> useSkillSounds;

	public Dictionary<int, List<string>> skillSoundPerAttacks;

	public Dictionary<int, (string, float)> tileTickSounds;

	public float illustOffsetX;

	public float illustOffsetY;

	public float illustScale;

	public Color gradationColor;

	public float gachaIllustOffsetX;

	public float gachaIllustOffsetY;

	public float gachaBackIllustOffsetX;

	public float gachaBackIllustOffsetY;

	public Color gachaGradationColor;

	public Color gachaExplosionColor;

	public bool canBuy;

	public bool showAnimationOnBuy;

	public Localizer.Locale[] bannedLanguages;

	public int godSkinIndex;

	public int minVersion;

	public List<string> infoTags;

	public int effectLevel;

	public int actionLevel;

	public int soundLevel;

	public List<Color> chromaColors;

	public List<int> shakeCameraSkill;

	public Dictionary<string, Value> values;

	private Sprite _sprite;

	private Sprite _uiSprite;

	private Sprite _transformSprite;

	private Sprite _illustSprite;

	public XmlNode xmlNode;

	public int inheritFrom;

	public static int GOD_SKIN_INDEX_MAX;

	public string maxLevelEffectPrefabName;

	public Vector2 maxLevelEffectPanelOffset;

	public float maxLevelEffectPanelScale;

	public bool isPassSkin;

	public Vector2 transformSpriteOffset => default(Vector2);

	public Vector2 transformPrefabOffset => default(Vector2);

	public float transformHeight => 0f;

	public float transformHeightOffset => 0f;

	public string replaceSkillTransformPrefab => null;

	public string transformAtkSound => null;

	public string transformShotSound => null;

	public string transformSpriteName => null;

	public string prefab => null;

	public new string name => null;

	public Sprite sprite => null;

	public Sprite uiSprite => null;

	public Sprite transformSprite => null;

	public Sprite illustSprite => null;

	public bool hasAvatar => false;

	public bool isChromaSkin => false;

	public bool isDummyForDefault => false;

	public int rootId => 0;

	public override void Init(XmlNode n)
	{
	}

	public void SetTransformInfo(int unitId)
	{
	}

	public int GetValueInt(string key, int @default = -1)
	{
		return 0;
	}

	public float GetValueFloat(string key, float @default = -1f)
	{
		return 0f;
	}

	public string GetValueText(string key, string @default = null)
	{
		return null;
	}

	public bool GetValueBool(string key, bool @default = false)
	{
		return false;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public static Color GetInfoTagColor(string value, int index = -1)
	{
		return default(Color);
	}

	public static void Load()
	{
	}

	public bool IsLanguageBanned()
	{
		return false;
	}

	public static List<ResourceSkin> GetDefaultChromaSkins(int unitId)
	{
		return null;
	}

	public static List<ResourceSkin> GetAllValidSkinsExceptChroma(int unitId)
	{
		return null;
	}

	public List<ResourceSkin> GetChromaSkins()
	{
		return null;
	}

	public string GetOriginPrefab()
	{
		return null;
	}

	public static string GetEffectDisablePrefsKey(int id)
	{
		return null;
	}

	public static bool IsEffectEnabled(int id)
	{
		return false;
	}

	public static string GetPrefabName(ResourceSkin resSkin, string defaultPrefab)
	{
		return null;
	}
}
