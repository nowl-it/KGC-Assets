using System.Collections.Generic;
using UnityEngine;

public class TotemUnit : MonoBehaviour
{
	public GameUnit parent;

	private bool _live;

	private List<GameUnit> _targets;

	private int _hp;

	private int _maxHp;

	private bool _applyDamageToTotemHp;

	private float _time;

	private bool _damageToAll;

	private float _damageRatio;

	protected float stunTime;

	private bool _isIndependent;

	private List<Animator> _animators;

	private List<Animator> _lineAnimators;

	private List<LineSprite> _lineSprites;

	private static readonly int SpawnTrigger;

	private static readonly int IdleTrigger;

	private static readonly int HitTrigger;

	private static readonly int DieTrigger;

	private static readonly int DisappearTrigger;

	public virtual void Init(GameUnit parent, List<GameUnit> targets, ResourceSkill resSkill, float damageRatio)
	{
	}

	public void Damage(DamageInfo damageInfo, GameUnit damagedUnit, GameUnit from)
	{
	}

	protected virtual void AfterDamaged()
	{
	}

	protected virtual bool CheckBoomCondition()
	{
		return false;
	}

	protected void Boom(BattleManager battle)
	{
	}

	protected virtual DamageInfo GetTotemDamageInfo(int originalDamage)
	{
		return default(DamageInfo);
	}

	public void Die(bool bomb)
	{
	}

	public virtual void Clear(GameUnit target)
	{
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void UpdateImpl()
	{
	}

	private void SetTrigger(string trigger)
	{
	}

	private void ResetTrigger(string trigger)
	{
	}

	private void SetFloat(string name, float v)
	{
	}

	public void HandleEvent(string eventName, Animator from)
	{
	}
}
