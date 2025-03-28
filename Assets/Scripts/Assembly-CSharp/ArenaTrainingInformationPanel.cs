using UnityEngine;

public class ArenaTrainingInformationPanel : PopupPanel
{
	[SerializeField]
	private UIFitter[] _uiFitters;

	[SerializeField]
	private ConditionalGroup _doNotShowThisSeasonCond;

	public override void Show()
	{
	}

	private void Reload()
	{
	}

	public void OnClickCheckBox()
	{
	}

	public override bool Close()
	{
		return false;
	}
}
