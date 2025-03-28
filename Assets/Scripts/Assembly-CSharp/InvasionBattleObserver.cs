using System;
using System.Collections.Generic;

public abstract class InvasionBattleObserver : BaseBattleObserver
{
	public bool?[] gimmickCompleted;

	protected Dictionary<int, List<IDisposable>> _stageObservers;

	protected BattleManager _battle;

	public override string Serialize()
	{
		return null;
	}

	public override void Deserialize(string data)
	{
	}

	public override void Dispose()
	{
	}

	public abstract void SetGimmickCompleted(int idx, bool? value);

	public abstract List<ResourceUnit.Potential> GetGimmickPotentials(int unitId);
}
