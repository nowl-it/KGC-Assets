using System.Collections.Generic;
using JetBrains.Annotations;

[UsedImplicitly]
public class Theme17BattleObserver : InvasionBattleObserver
{
	private List<ResourceUnit.Potential> _gimmickPotentials;

	private ResourceUnit _resBoss;

	private bool _stage5Flag;

	private bool _stage10Flag;

	private bool _stage15Flag;

	public override void InitObserve(BattleManager battle)
	{
	}

	private void Stage5Init()
	{
	}

	private void Stage5Observe((GameUnit unit, GameUnit from) param)
	{
	}

	private void Stage5End(bool win)
	{
	}

	private void Stage10Init()
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
