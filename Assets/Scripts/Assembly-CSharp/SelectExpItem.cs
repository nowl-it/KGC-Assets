using UnityEngine;
using UnityEngine.UI;

public class SelectExpItem : MonoBehaviour
{
	[ComponentConnect]
	public Image unitSprite;

	[ComponentConnect]
	public Text levelText;

	public ConditionalImage potentialLevelBox;

	[ComponentConnect]
	public Gauge expGauge;

	[ComponentConnect]
	public Image selected;

	public GameObject potentialObj;

	public Image potentialIcon;

	public Image roleIcon;

	public Image regionIcon;

	[SerializeField]
	private TreasureUIItem _treasureItem;

	private SelectExpPanel _panel;

	public int unitID { get; private set; }

	public void Set(SelectExpPanel panel, int unitID, bool useSyncedLevel, bool showRoleIcon = true)
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool v)
	{
	}
}
