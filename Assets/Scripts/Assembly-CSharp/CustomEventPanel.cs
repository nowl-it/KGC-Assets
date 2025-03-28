using System;
using Awesomepiece.Model;

public abstract class CustomEventPanel : PopupPanel
{
	public virtual void Show(CustomEventData data)
	{
	}

	[Obsolete]
	public override void Show()
	{
	}
}
