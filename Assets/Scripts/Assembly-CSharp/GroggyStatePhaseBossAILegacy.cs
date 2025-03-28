using System.Collections.Generic;

public class GroggyStatePhaseBossAILegacy : GroggyStateAILegacy, IHpBarCustomizable
{
	private List<int> _phaseSkills;

	private List<int> _phaseAttackSkills;

	private List<float> _triggerHpPer;

	private List<string> _hpGaugeSprite;

	private int _currentPhase;

	private int _phaseCount;

	public List<int> phaseSkills => null;

	public List<int> phaseAttackSkills => null;

	protected int currentPhase => 0;

	protected int phaseCount => 0;

	public GroggyStatePhaseBossAILegacy(GameUnit me)
		: base(null)
	{
	}

	protected virtual bool CheckHasPhase(int phase)
	{
		return false;
	}

	protected virtual void EnterPhase(int newPhase)
	{
	}

	public override void Update(float dt)
	{
	}

	public int RemainHpForPhase(int phase)
	{
		return 0;
	}

	public int HpForPhase(int phase)
	{
		return 0;
	}

	public virtual bool SetHpBar()
	{
		return false;
	}

	public virtual void UpdateHpBar(bool reloadMax = false)
	{
	}
}
