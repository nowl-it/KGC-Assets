using System;
using UnityEngine;

public abstract class GachaShopPanelBG : MonoBehaviour
{
	protected ResourceGacha _resGacha;

	public abstract void Set(ResourceGacha resGacha);

	public virtual void OnChangeGachaCellIdx(int index)
	{
	}

	public virtual Action GetAfterBuyGachaCallback()
	{
		return null;
	}

	public virtual void OnClickDevPickupResetButton()
	{
	}
}
