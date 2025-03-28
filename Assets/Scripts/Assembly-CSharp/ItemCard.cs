using UnityEngine;
using UnityEngine.UI;

public class ItemCard : MonoBehaviour
{
	public Text nameText;

	public Text costText;

	public Image unitImage;

	public GameObject soldOut;

	public RectTransform batchObject;

	public GameObject disabled;

	private int _idx;

	private int _cost;

	public void Set(int idx, ResourceUnit resUnit)
	{
	}

	public void OnClick()
	{
	}

	public void SetSoldOut(bool v)
	{
	}

	public void SetBatching(bool v)
	{
	}

	public void CancelBatching()
	{
	}

	public void ReloadCost()
	{
	}
}
