using UnityEngine.UI;

public class ManageClanJoinRequestPanel : PopupPanel
{
	[ComponentConnect]
	public UIAdvancedTableView tableView;

	[ComponentConnect]
	public Text countText;

	public override void Show()
	{
	}

	public void Reload()
	{
	}
}
