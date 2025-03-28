using System.Collections.Generic;
using UnityEngine;

public struct DamageInfo
{
	public enum Type
	{
		NormalPhysical = 0,
		SkillPhysical = 1,
		NormalMagic = 2,
		SkillMagic = 3,
		Special = 4,
		ExtraPhysical = 5,
		ExtraMagic = 6,
		NotADamage = 7,
		None = 8
	}

	public enum BlockedBy
	{
		None = 0,
		Miss = 1,
		SuperShield = 2,
		SuperMAtkShield = 3,
		SuperAtkShield = 4
	}

	public enum BaseAtkSkillType
	{
		None = 0,
		Knockback = 1,
		Stun = 2
	}

	public static int UniqueIdCounter;

	public int id;

	public float value;

	public float uniqueDamageCompoundMult;

	public float damagePer;

	public float damageMult;

	public float damageInc;

	public int team;

	public ResourceSkill resSkill;

	public int damageIdx;

	public Type type;

	public bool isCritical;

	public BlockedBy blockedBy;

	public float systemScaler;

	public float stunTime;

	public bool splashRoot;

	public Vector2Int splashRootPos;

	public bool isSplash;

	public bool isExecution;

	public bool isShared;

	public bool isReflected;

	public bool dontChain;

	public bool ignoreSuperShield;

	public bool ignoreAddMana;

	public float addMagicDrain;

	public bool dontShowEffect;

	public bool dontShowImpactEffect;

	public bool addBuffBlend;

	public int buffBlend;

	public int attackCount;

	public List<string> itemEffects;

	public IReadOnlyList<ResourceSkill.Effect> effects;

	public IReadOnlyList<ResourceSkill.Effect> splashRootEffects;

	public IReadOnlyList<ResourceSkill.Effect> splashTargetOnlyEffects;

	public IReadOnlyList<ResourceSkill.Effect> projectileEffects;

	public Vector2Int dir;

	public string sound;

	public bool playDefaultHitSound;

	public Vector2 damageShootOffset;

	public float damageWithShieldReduction;

	private bool _applied;

	public string damageLog;

	public List<(int, BaseAtkSkillType)> useSkillOnHit;

	public void SetOnlyEffect(ResourceSkill.Effect effect)
	{
	}

	public int GetDamage(bool apply)
	{
		return 0;
	}

	public readonly int GetDamage()
	{
		return 0;
	}

	public readonly DamageShootData ToDamageShootData()
	{
		return default(DamageShootData);
	}

	public bool ContainsHardCC(GameUnit from)
	{
		return false;
	}
}
