using UnityEngine.UI;

public class ManageClanMemberPanel : PopupPanel
{
	[ComponentConnect]
	public UIAdvancedTableView tableView;

	[ComponentConnect]
	public Text memberCountText;

	[ComponentConnect]
	public Popup masterConfirmPopup;

	[ComponentConnect]
	public InputField confirmInputField;

	public override void Show()
	{
	}

	public void Reload()
	{
	}
}
