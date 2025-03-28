using UnityEngine;
using UnityEngine.UI;

public class ArtifactMergeCraftTab : ArtifactCraftTabBase
{
	private enum Tab
	{
		Craft = 0,
		Merge = 1
	}

	[SerializeField]
	private ArtifactCraftTabBase[] _artifactTab;

	[SerializeField]
	private TabManager _tabManager;

	[SerializeField]
	private Text _tipText;

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

	public void ReloadSelected()
	{
	}

	public void OpenTab(string tabName)
	{
	}
}
