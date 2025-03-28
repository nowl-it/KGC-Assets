using UnityEngine;
using UnityEngine.UI;

public class BabelPassItem : MonoBehaviour
{
	[SerializeField]
	private Text _passName;

	[SerializeField]
	private Text _passDesc;

	[SerializeField]
	private Text _efficiencyText;

	[SerializeField]
	private Price _price;

	[SerializeField]
	private GameObject _soldOutObj;

	[SerializeField]
	private Text _buyCountText;

	[SerializeField]
	private GameObject _partition;

	[SerializeField]
	private FlexibleUIElements _rewardLayout;

	private ResourceShopItem _resShopItem;

	public bool canBuy;

	private ResourceShopItem.BabelPassInfo _babelPassInfo => null;

	public void Set(ResourceShopItem resShopItem)
	{
	}

	public void ReloadSoldOutState()
	{
	}

	public void OnClickBuy()
	{
	}

	public void ShowPartition(bool v)
	{
	}
}
