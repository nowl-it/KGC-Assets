using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidDeckFieldUnit : MonoBehaviour
{
	[SerializeField]
	private Image _levelImage;

	[SerializeField]
	private FlexibleUIElements _itemElements;

	[SerializeField]
	private Transform _unitPrefabRoot;

	private UnitController _unitPrefab;

	private string _prefabName;

	private GameCompleteRequestModel.EndFieldUnit _fieldUnit;

	private ClanRaidCardInfo _cardInfo;

	private float originStarY;

	public void Set(GameCompleteRequestModel.EndFieldUnit fieldUnit, ClanRaidCardInfo cardInfo)
	{
	}

	public void OnClick()
	{
	}
}
