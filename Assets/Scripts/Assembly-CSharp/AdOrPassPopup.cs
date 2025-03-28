using System;

public class AdOrPassPopup : Popup
{
	public void Show(Action<bool> callback, string type = "")
	{
	}

	public void OnClickClose()
	{
	}

	public override bool Close()
	{
		return false;
	}

	private void DoShortcut()
	{
	}
}
