using UnityEngine;
using UnityEngine.UI;

public class ArenaShopPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public Text title;

	[ComponentConnect]
	public UITableView listView;

	[ComponentConnect]
	public ImageTextPair tokenCountPair;

	[ComponentConnect]
	public LerpText tokenCountText;

	[ComponentConnect]
	public Text remainTimeText;

	[SerializeField]
	private ClickableShopItemIcon _tokenIcon;

	public void Show()
	{
	}

	public void Reload()
	{
	}

	private void UpdateRemainTimeText()
	{
	}

	private void Update()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
