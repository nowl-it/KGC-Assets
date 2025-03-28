using System;
using Coffee.UIEffects;
using UnityEngine.UI;

public class HQIllustPopup : UnitIllust, IClosable
{
	public Text descText;

	public UIShadow descOutline;

	private Action _onClickCallback;

	private Action _onCloseCallback;

	public new void Set(int unitId, int skinId)
	{
	}

	public void SetOnClickCallback(Action action)
	{
	}

	public void SetOnCloseCallback(Action action)
	{
	}

	public virtual void Show()
	{
	}

	public virtual void OnClickClose()
	{
	}

	public virtual bool Close()
	{
		return false;
	}
}
