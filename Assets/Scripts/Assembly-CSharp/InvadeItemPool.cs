using System.Collections.Generic;
using UnityEngine;

public class InvadeItemPool : MonoBehaviour
{
	private static bool activated;

	public List<InvadeItemUnit> pool;

	public InvadeItemUnit Rent(int itemId)
	{
		return null;
	}

	public void Return(InvadeItemUnit unit)
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
