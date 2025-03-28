using System.Collections.Generic;
using UnityEngine;

public class UnitPool : MonoBehaviour
{
	private static bool activated;

	public List<GameUnit> pool;

	public GameUnit Rent(int unitId, int skinId)
	{
		return null;
	}

	public void Return(GameUnit unit)
	{
	}

	public bool CanRent(int unitId, int skinId)
	{
		return false;
	}

	public void DestroyAll()
	{
	}
}
