using System.Collections.Generic;
using Google.Protobuf.Collections;
using Protocol;

public class WorldTriggerBundle
{
	private static int _uniqueIdCounter;

	public int id;

	public BattleManager parent;

	public List<WorldTrigger> worldTriggers;

	public int resourceId;

	public string type;

	public WorldTriggerBundle(BattleManager battle, List<WorldTrigger> worldTriggers, string type, int resourceId)
	{
	}

	public void ApplyWorldTrigger(WorldTrigger.Conditions condition, bool toEnemy)
	{
	}

	public void WriteWorldTriggersToPlayerColosseumSnapshot(PlayerSnapshot snapshot)
	{
	}

	public void ReadFromPlayerColosseumSnapshot(RepeatedField<Protocol.WorldTrigger> wts)
	{
	}
}
