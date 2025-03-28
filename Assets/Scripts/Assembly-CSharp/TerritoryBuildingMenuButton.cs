using UnityEngine;
using UnityEngine.UI;

public class TerritoryBuildingMenuButton : MonoBehaviour
{
	[SerializeField]
	private ConditionalGroup _buttonInteractableConditionals;

	[SerializeField]
	private Text _text;

	[SerializeField]
	private GameObject _pricePanel;

	[SerializeField]
	private Image _priceIcon;

	[SerializeField]
	private Text _priceText;

	[SerializeField]
	private TerritoryMarker _marker;

	[HideInInspector]
	public string type;

	public void SetText(string text)
	{
	}

	public void ShowPrice(Sprite icon, int price, bool isEnough)
	{
	}

	public void HidePrice()
	{
	}

	public void SetInteractable(bool interactable)
	{
	}

	public void ShowMarker(TerritoryMarker.Type type)
	{
	}
}
