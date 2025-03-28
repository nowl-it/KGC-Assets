using System.Collections.Generic;

public class AuraDuringSkillAI : MoveAttackAI
{
	private float _tick;

	private float _matkPer;

	private float _drainPer;

	private IReadOnlyList<ResourceSkill.Effect> _targetEffects;

	private IReadOnlyList<ResourceSkill.Effect> _auraEffects;

	private IReadOnlyList<ResourceSkill.Effect> _scaledAuraEffects;

	private string _initSound;

	private string _loopSound;

	private int _skillHitCountToChangeSkill;

	private int _skillHitCountToRevive;

	private float _reviveHpPer;

	private ResourceSkill _resDummyBuffToChangeSkill;

	private ResourceSkill _resAuraSkill;

	private AudioObject _auraSoundLoop;

	private float _tickCounter;

	private bool _isAuraActive;

	private bool _useAura;

	private bool _auraActiveFlag;

	private int _skillHitByMainSkillCount;

	private bool _dummyBuffAdded;

	private bool _reviveAdded;

	private const float SKILL_DELAY = 0.4f;

	private float _ccRatioPerSkillHit;

	private float _ccRatioPerSkillHitMax;

	private float _matkPerSkillHit;

	private float _matkPerSkillHitMax;

	public AuraDuringSkillAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	private float BindCCRatio()
	{
		return 0f;
	}

	private float BindMAtkPer()
	{
		return 0f;
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public override void HandleHitUnit(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	public override void Update(float dt)
	{
	}

	private void DrainAura()
	{
	}

	private void ClearAura()
	{
	}

	public override void Clear()
	{
	}
}
