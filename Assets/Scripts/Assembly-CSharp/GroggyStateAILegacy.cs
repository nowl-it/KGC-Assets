public class GroggyStateAILegacy : MoveAttackAI
{
	protected string groggyDealType;

	protected int groggyDealReq;

	protected float groggyTime;

	protected int groggyDealMeter;

	protected float _groggyTimer;

	public bool isGroggy;

	protected int typeDefPer;

	protected int phase;

	private float _channelingTimer;

	public const int CHANNELING_TIMER_MULTIPLIER = 10000;

	public bool groggyForOnlyChanneling;

	private ConditionalRoot _groggyBarConditionalRoot;

	public GroggyStateAILegacy(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleEndChanneling()
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override void HandleStartChanneling()
	{
	}

	public void InitGroggyDealMeter()
	{
	}

	public void EndGroggyDealMeter()
	{
	}

	public override void HandleDamaged(GameUnit from, DamageInfo damageInfo)
	{
	}

	public virtual void StartGroggy()
	{
	}

	public virtual void EndGroggy()
	{
	}

	public int GetCurrentGroggyMeter()
	{
		return 0;
	}

	public int GetRequiredGroggyMeter()
	{
		return 0;
	}

	public float GetChannelingTimer()
	{
		return 0f;
	}

	public virtual bool IsChanneling()
	{
		return false;
	}
}
