using UnityEngine;
using UnityEngine.UI;

public class CraftPanel : PopupPanel
{
	[SerializeField]
	private ArtifactCraftPanel _artifactCraftPanel;

	[SerializeField]
	private AccessoryCraftPanel _accessoryCraftPanel;

	[SerializeField]
	private TabManager _mainTabManager;

	[SerializeField]
	private Button _closeButton;

	private bool _accessoryLocked;

	public ArtifactCraftPanel artifactCraftPanel => null;

	public AccessoryCraftPanel accessoryCraftPanel => null;

	public Button closeButton => null;

	public new void Show()
	{
	}

	private void Reload(int idx)
	{
	}

	public override bool Close()
	{
		return false;
	}
}
