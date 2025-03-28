using System;
using UnityEngine;
using UnityEngine.UI;

public class GachaShopCell : MonoBehaviour
{
	[SerializeField]
	private RectTransform _rectTransform;

	[SerializeField]
	private Text _gachaItemName;

	[SerializeField]
	private ConditionalGroup _stackConditionals;

	[SerializeField]
	private ConditionalGroup _stackValueConditionals;

	[SerializeField]
	private Image[] _stackOffImages;

	[SerializeField]
	private Image[] _stackImages;

	[SerializeField]
	private Image[] _stackEffectImages;

	[SerializeField]
	private Image[] _stackLineImages;

	[SerializeField]
	private Text _ceilingInfoText;

	[SerializeField]
	private Image _itemTagImage;

	[SerializeField]
	private Image _itemImage;

	[SerializeField]
	private GameObject _freeIcon;

	[SerializeField]
	private GameObject _doubleIcon;

	[SerializeField]
	private Price[] _currentCurrencies;

	[SerializeField]
	private ClickableShopItemIcon[] _currentCurrenciesClickableShopItemIcons;

	[SerializeField]
	private Text _freeTimeLeftText;

	[SerializeField]
	private Image[] _blackMasks;

	private Action _onClickStackArea;

	private ResourceShopItem _resShopItem;

	private ResourceGacha _resGacha;

	public ResourceGacha resGacha => null;

	public void Set(ResourceShopItem resShopItem, ResourceGacha resGacha, Action onClickStackArea)
	{
	}

	public void Reload()
	{
	}

	private void ReloadCeilingInfoText()
	{
	}

	private void Update()
	{
	}

	private void UpdateFreeLeftTime()
	{
	}

	public void SetBlackMaskAlpha(float alpha)
	{
	}

	public void OnClickResultTableButton()
	{
	}

	public void OnClickStackArea()
	{
	}
}
