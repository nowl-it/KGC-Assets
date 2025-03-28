using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TreasureUIItem : MonoBehaviour
{
	[SerializeField]
	private Image _treasureIcon;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Text _coolTimeText;

	[SerializeField]
	private GameObject _unlockLevelObj;

	[SerializeField]
	private Text _unlockLevelText;

	[SerializeField]
	private GameObject _plusIcon;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private ConditionalGroup _lockCond;

	[SerializeField]
	private ConditionalImage _stateCond;

	[SerializeField]
	private ProfileAvatar _unitAvatar;

	[SerializeField]
	private ConditionalGroup _selectedCond;

	[Space(20f)]
	[SerializeField]
	private GameObject _illustObj;

	[SerializeField]
	private Image _illust;

	[SerializeField]
	private Image _illustGradationImg;

	[Space(20f)]
	[SerializeField]
	private GameObject _overcomeIconsObj;

	[SerializeField]
	private Image[] _overcomeIcons;

	[SerializeField]
	private Image[] _overcomeIconsBG;

	[SerializeField]
	private GameObject _usedObj;

	[NonSerialized]
	public TreasureModel treasure;

	[NonSerialized]
	public InventoryItem inventoryItem;

	private ResourceTreasure _resTreasure;

	private Action _onClick;

	private Action _onClickTreasureIcon;

	private float _updateTimer;

	private int _needItemCount;

	public Text levelText => null;

	private void Update()
	{
	}

	private void UpdateCoolTimeText()
	{
	}

	public TreasureUIItem Set(TreasureModel treasure, Action onClick = null, int overcome = -1, bool showIllust = false, int unitId = -1, bool simple = false, bool showMaxLevel = false, bool showStar = true, bool showRole = true, bool showCoolTime = false, bool showLevel = true)
	{
		return null;
	}

	public TreasureUIItem SetDefault(bool locked, bool showPlus = false, int playerLevel = -1, Action onClick = null)
	{
		return null;
	}

	public TreasureUIItem Set(InventoryItem material, int needCount, Action onClick = null, int overcome = -1, bool showIllust = false)
	{
		return null;
	}

	public TreasureUIItem ReloadInventoryCountText()
	{
		return null;
	}

	public void OnClick()
	{
	}

	public void OnClickTreasure()
	{
	}

	public bool GetSelected()
	{
		return false;
	}

	public TreasureUIItem SetSelected(bool selected)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public TreasureUIItem SetUsed(bool used)
	{
		return null;
	}

	public TreasureUIItem OnClickTreasureIcon(Action action)
	{
		return null;
	}
}
