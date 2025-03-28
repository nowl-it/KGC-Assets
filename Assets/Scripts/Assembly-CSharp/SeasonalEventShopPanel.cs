using UnityEngine;
using UnityEngine.UI;

public class SeasonalEventShopPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public Text title;

	[ComponentConnect]
	public UITableView itemListView;

	[ComponentConnect]
	public UITableView skinListView;

	[ComponentConnect]
	public UITableView specialSkinListView;

	[ComponentConnect]
	public ImageTextPair tokenCountPair;

	[ComponentConnect]
	public ClickableShopItemIcon priceIcon;

	[ComponentConnect]
	public LerpText tokenCountText;

	[ComponentConnect]
	public Text remainTimeText;

	[ComponentConnect]
	public Text periodText;

	[ComponentConnect]
	public Text shopTitle;

	[ComponentConnect]
	public Text shopDesc;

	[ComponentConnect]
	public GameObject specialSkinTabButton;

	public void Show()
	{
	}

	public void Reload()
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
