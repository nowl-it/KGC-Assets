using System.Collections.Generic;
using JetBrains.Annotations;

[UsedImplicitly]
public class Theme16BattleObserver : InvasionBattleObserver
{
	private List<ResourceUnit.Potential> _gimmickPotentials;

	private ResourceUnit _resBoss;

	private Dictionary<int, int> _stage5StunCounter;

	private int _stage10TargetEliteCount;

	private int _stage15TargetEliteCount;

	public override void InitObserve(BattleManager battle)
	{
	}

	private void Stage5Init()
	{
	}

	private void Stage5Observe((GameUnit from, GameUnit target, DamageInfo damageInfo) param)
	{
	}

	private void Stage5End(bool win)
	{
	}

	private void Stage10Init()
	{
	}

	private void Stage10Observe((GameUnit unit, GameUnit from) param)
	{
	}

	private void Stage10End(bool win)
	{
	}

	private void Stage15Init()
	{
	}

	private void Stage15Observe((GameUnit unit, GameUnit from) param)
	{
	}

	private void Stage15End(bool win)
	{
	}

	public override List<ResourceUnit.Potential> GetGimmickPotentials(int unitId)
	{
		return null;
	}

	public override void SetGimmickCompleted(int idx, bool? value)
	{
	}
}
