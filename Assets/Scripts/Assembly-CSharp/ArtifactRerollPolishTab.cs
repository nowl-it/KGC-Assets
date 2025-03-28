using Awesomepiece.Model;
using UnityEngine;

public class ArtifactRerollPolishTab : ArtifactCraftTabBase
{
	private enum Tab
	{
		Reroll = 0,
		Polish = 1
	}

	[SerializeField]
	private ArtifactCraftTabBase[] _artifactTab;

	[SerializeField]
	private TabManager _tabManager;

	public ArtifactModel lastSelectedArtifact;

	private Tab _currentTab;

	public override void Init()
	{
	}

	private void OnClickTab(int idx)
	{
	}

	public override void OnClickArtifact(DraggableArtifactCard artifactCard)
	{
	}

	public override void ReloadCost()
	{
	}

	public override void ReloadActionButtonInteractable()
	{
	}

	public override void OnClickSlot(ArtifactCraftSlot slot)
	{
	}

	public override void Clear()
	{
	}

	public static string GaugeValueFormat(int value)
	{
		return null;
	}

	public void OpenTab(string tabName)
	{
	}
}
