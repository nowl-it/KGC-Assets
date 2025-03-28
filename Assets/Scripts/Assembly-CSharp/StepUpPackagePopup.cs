using System.Collections.Generic;
using Awesomepiece.Model;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class StepUpPackagePopup : MonoBehaviour, IClosable
{
	[Header("Title")]
	[SerializeField]
	private Text _title;

	[SerializeField]
	private Text _subTitle;

	[SerializeField]
	[Header("Rewards")]
	private FlexibleUIElements _totalRewardElements;

	[SerializeField]
	private Button _buyButton;

	[SerializeField]
	private Price _price;

	[SerializeField]
	private ConditionalGroup _selectedIndexConditional;

	[SerializeField]
	[Header("Missions")]
	private RectTransform _missionTableArea;

	[SerializeField]
	private StepUpPackageMissionItem _missionPrefab;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private GameObject _bottomArrow;

	[SerializeField]
	[Header("Other")]
	private Text _cannotRefundText;

	[CanBeNull]
	private ShopItemModel _stepUpPackage;

	private int _index;

	private ResourceShopItem _resShopItem;

	private readonly List<StepUpPackageMissionItem> _inverseOrderMissionItems;

	public void Show()
	{
	}

	public void Reload(int index = -1)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickArrow(int delta)
	{
	}

	public void OnValueChanged()
	{
	}

	public void OnClickBuy()
	{
	}

	private bool CheckMissionInProgress(ResourceShopItem shopItem)
	{
		return false;
	}
}
