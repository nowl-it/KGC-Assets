using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class AccessoryCraftPanel : MonoBehaviour
{
	[SerializeField]
	private AccessoryUpgradePanel _accessoryUpgradePanel;

	[SerializeField]
	private TabManager _tabManager;

	[SerializeField]
	private Text _selectAccessoryButtonText;

	public AccessoryUpgradePanel accessoryUpgradePanel => null;

	public void Show(AccessoryModel accessory = null)
	{
	}

	public void Close()
	{
	}
}
