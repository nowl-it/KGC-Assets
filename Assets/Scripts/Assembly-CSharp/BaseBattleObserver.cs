using System;

public abstract class BaseBattleObserver : IDisposable
{
	public abstract void InitObserve(BattleManager battle);

	public abstract void Dispose();

	public abstract string Serialize();

	public abstract void Deserialize(string data);
}
