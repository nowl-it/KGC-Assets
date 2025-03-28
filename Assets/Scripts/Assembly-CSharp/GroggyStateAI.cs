using System.Collections.Generic;

public class GroggyStateAI : MoveAttackAI
{
	protected List<DamageInfo.Type> groggyDealType;

	protected float groggyTime;

	protected int groggyDealMeter;

	protected float groggyTimer;

	public bool isGroggy;

	protected float channelingTimer;

	public const int ChannelingTimerMultiplier = 10000;

	private ConditionalRoot _groggyBarConditionalRoot;

	public int groggyDealReq { get; protected set; }

	public GroggyStateAI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleStartBattle()
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override void HandleStartChanneling()
	{
	}

	public override void HandleEndChanneling()
	{
	}

	protected void InitGroggyDealMeter()
	{
	}

	protected void EndGroggyDealMeter()
	{
	}

	public override void HandleApplyDamage(GameUnit from, ref DamageInfo damageInfo)
	{
	}

	public virtual void AddGroggyDealMeter(float damage)
	{
	}

	protected virtual void StartGroggy()
	{
	}

	protected virtual void EndGroggy()
	{
	}
}
