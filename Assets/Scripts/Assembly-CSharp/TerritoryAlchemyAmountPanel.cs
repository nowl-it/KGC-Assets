using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TerritoryAlchemyAmountPanel : MonoBehaviour
{
	[FormerlySerializedAs("_alchemyCurrencyItem")]
	[SerializeField]
	private AlchemyCurrencyItem_Old _alchemyCurrencyItemOld;

	[SerializeField]
	private Text _countText;

	[SerializeField]
	private Slider _usingAmountSlider;

	public TerritoryAlchemyItem_Old target;

	private TerritoryAlchemyPanel_Old.AlchemyCurrencyData _currencyData;

	private int _ownCount;

	private int _prevCount;

	private int _unit;

	private TerritoryAlchemyPanel_Old _parent;

	private int _maxValue => 0;

	public void Set(TerritoryAlchemyPanel_Old parent)
	{
	}

	public void Show(TerritoryAlchemyItem_Old itemOld, int ownCount, int initialValue)
	{
	}

	public void OnClickPlus(bool all)
	{
	}

	public void OnClickMinus(bool all)
	{
	}

	public void OnSliderValueChanged()
	{
	}

	public void Close()
	{
	}

	public void Accept()
	{
	}
}
