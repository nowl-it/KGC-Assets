using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryAlchemyCurrencyItem : MonoBehaviour
{
	[SerializeField]
	private GameObject _currencyArea;

	[SerializeField]
	private GameObject _descArea;

	[SerializeField]
	private ConditionalSizeDelta _frameObj;

	[Space(20f)]
	[SerializeField]
	private RectTransform _descTextRoot;

	[SerializeField]
	private GameObject _descTextObj;

	private List<GameObject> _descTexts;

	[SerializeField]
	private ClickableShopItemIcon _currencyItem;

	[SerializeField]
	private Image _unitFrame;

	[SerializeField]
	private Image _unitSprite;

	[SerializeField]
	private Slider _usingAmountSlider;

	[SerializeField]
	private Text _sliderText;

	[SerializeField]
	private Text _expandIcon;

	[SerializeField]
	private List<UIFitter> _uiFitters;

	private int _ownCount;

	private int _unit;

	public TerritoryAlchemyCurrencyPanel.AlchemyCurrencyData currencyData;

	public ResourceAlchemyExchangeRatio _resAlchemyRatio;

	private TerritoryAlchemyCurrencyPanel _parent;

	private ResourceInventoryItem _resInventoryItem;

	private bool _isExpanded;

	public void Set(TerritoryAlchemyCurrencyPanel.AlchemyCurrencyData currencyData, TerritoryAlchemyCurrencyPanel parent, int ownCount, (bool isCurrencyItem, bool isExpanded) expandedInfo)
	{
	}

	private void ReloadCurrencyData()
	{
	}

	private void SetText(int index)
	{
	}

	private void ReloadDesc()
	{
	}

	public void OnSliderValueChanged()
	{
	}

	public float ApplyRatio(float value, bool reverse)
	{
		return 0f;
	}

	private void ReloadSliderText()
	{
	}

	public void OnClickPlus(bool all)
	{
	}

	public void OnClickMinus(bool all)
	{
	}

	public void OnClickExpand()
	{
	}

	private void ReloadExpand()
	{
	}
}
