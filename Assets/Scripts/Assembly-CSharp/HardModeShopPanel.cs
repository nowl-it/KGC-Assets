using UnityEngine;
using UnityEngine.UI;

public class HardModeShopPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public UITableView[] listViews;

	[ComponentConnect]
	public ImageTextPair tokenCountPair;

	[ComponentConnect]
	public LerpText tokenCountText;

	[ComponentConnect]
	public Text descText;

	[ComponentConnect]
	public SelectAmountPanel selectArtifactAmountPanel;

	[ComponentConnect]
	public TabManager tabManager;

	[ComponentConnect]
	public GameObject tabPartition;

	[ComponentConnect]
	public VerticalLayoutGroup contentLayoutGroup;

	[SerializeField]
	private ClickableShopItemIcon _hardModeIcon;

	private int _currentTab;

	private float _contentAreaHeight;

	private bool _inited;

	public void Show()
	{
	}

	public void Reload()
	{
	}

	private void OnClickTab(int idx)
	{
	}

	private void SetTabActive(bool show)
	{
	}

	private void FitContent()
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
