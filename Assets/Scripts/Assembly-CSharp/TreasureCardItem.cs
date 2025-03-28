using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TreasureCardItem : MonoBehaviour
{
	[SerializeField]
	private TreasureUIItem _treasureItem;

	[SerializeField]
	private ProfileAvatar _equippedUnitAvatar;

	[SerializeField]
	private Text _equipCooltimeText;

	[SerializeField]
	private Image _cardIllustIcon;

	[SerializeField]
	private Image _cardFrameIcon;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private List<Image> _overcomeIcons;

	[SerializeField]
	private Gauge _expGauge;

	private TreasureModel _treasure;

	private bool _updateEquipCooltimeText;

	public void Set(TreasureModel treasure, bool owned, bool showEquipedUnit, bool updateEquipCoolTimeText = false, bool avatarInteractable = true)
	{
	}

	public void Update()
	{
	}

	private void UpdateEquipCoolTimeText()
	{
	}

	public void OnClickEquippedHero()
	{
	}
}
