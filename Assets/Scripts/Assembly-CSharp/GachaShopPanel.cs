using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaShopPanel : MonoBehaviour, IClosable
{
	private class ParentChildrenGachaPair
	{
		public int parentId;

		public List<ResourceGacha> children;
	}

	[SerializeField]
	private GameObject _gachaIconPrefab;

	[SerializeField]
	private RectTransform _gachaIconsRoot;

	[SerializeField]
	private GameObject _gachaShopCellPrefab;

	[SerializeField]
	private RectTransform _gachaShopCellsRoot;

	[SerializeField]
	private RectTransform _imagesRoot;

	[SerializeField]
	private GachaShopPanelBG[] _backgroundPrefabs;

	[SerializeField]
	private Border _gachaTitleBorder;

	[SerializeField]
	private Text _gachaTitle;

	[SerializeField]
	private GameObject _gachaStackInfoButton;

	[SerializeField]
	private Text _gachaDesc;

	[SerializeField]
	private Text _gachaTimeLeft;

	[SerializeField]
	private RectTransform[] _gachaItemPanelArrowButtons;

	[SerializeField]
	private GameObject[] _nextGachaFreeIcons;

	[SerializeField]
	private GameObject _pageIndicatorPrefab;

	[SerializeField]
	private RectTransform _pageIndicatorsRoot;

	[SerializeField]
	private BuyGachaButtonGroup _buttonGroup;

	[SerializeField]
	private GameObject _gachaStackResetAlertText;

	[SerializeField]
	private PopupPanel _stackInfoPopup;

	[SerializeField]
	private GachaResultTable _resultTablePopup;

	[SerializeField]
	private GachaUnitPercentageTable _unitPercentageTablePopup;

	[SerializeField]
	private GameObject _resultTableIconFlashEffectPrefab;

	[SerializeField]
	private InputField _NewUnitAnimTestUnitIdField;

	[SerializeField]
	private InputField _NewUnitAnimTestSkinIdField;

	[SerializeField]
	private GameObject _lowerElements;

	[SerializeField]
	private GameObject _customPickupMessage;

	[SerializeField]
	private ConditionalGroup _treasureWishListButton;

	private readonly List<GachaShopCell> _gachaCells;

	private List<ResourceGacha> _availableGachas;

	private readonly List<ParentChildrenGachaPair> _childGachas;

	private int _gachaCellChildIndex;

	private int _activatedGachaCellCount;

	private int _currentGachaIndex;

	private float _targetCellsAngle;

	private float _currentCellsAngle;

	private float _rotateDir;

	private ResourceGacha _curResGacha;

	private GachaShopPanelBG _curPanelBackground;

	private bool _isFree;

	private bool _isLoading;

	private int _lastSeenGachaId;

	private bool _tutorialAdd;

	private List<ResourceGacha.Pickup> _pickups;

	private List<ResourceGacha> _newUserGachas;

	private (DateTime, bool) _newUserGachaOpenTime;

	private Action<int> _onChangeGachaCellIdx;

	public BuyGachaButtonGroup buttonGroup => null;

	public PopupPanel stackInfoPopup => null;

	public List<ResourceGacha.Pickup> pickups => null;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show()
	{
	}

	public void Reload(bool gachaEnd = false)
	{
	}

	private void HandleGachaEnd()
	{
	}

	public void OnClickGachaIcon(int index)
	{
	}

	public void CustomPickupMessageReSet()
	{
	}

	private void OnChangeGachaCell()
	{
	}

	private void ReloadPrice()
	{
	}

	private void Update()
	{
	}

	private void UpdateCellPosition(bool Immediately)
	{
	}

	private void UpdateGachaLeftTime()
	{
	}

	private void UpdateNewUserGacha()
	{
	}

	private void SetGachaCellIndex(int index, int rotateDir)
	{
	}

	public void FindAndShowGacha(int gachaId)
	{
	}

	public Button FindGachaTab(int gachaId)
	{
		return null;
	}

	public void FindAndSetCommonGachaCell()
	{
	}

	public void OnClickPrevGachaCell()
	{
	}

	public void OnClickNextGachaCell()
	{
	}

	public void OnClickPrevGachaIcon()
	{
	}

	public void OnClickNextGachaIcon()
	{
	}

	public void OnClickResultTableButton()
	{
	}

	public void OnClickStackInfoButton()
	{
	}

	public void ShowUnitPercentageTable()
	{
	}

	public GameObject GetResultTableIconFlashEffectPrefab()
	{
		return null;
	}

	public void ForceShowSelectGachaCeil()
	{
	}

	public void SetLoading(bool set)
	{
	}

	private void SetLoadingInternal(bool set)
	{
	}

	public void OnClickShowGachaNewUnitPanel(bool skin)
	{
	}

	public static int[] GetGachaCounts(ResourceGacha resGacha)
	{
		return null;
	}

	public static void GetKeyCountKeyStack(ResourceGacha resGacha, out int count, out int stack)
	{
		count = default(int);
		stack = default(int);
	}

	public static bool IsGachaFree(ResourceGacha resGacha)
	{
		return false;
	}

	public static bool IsGachaFree(int tier)
	{
		return false;
	}

	public static bool HasNewGacha()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void PrepareTutorial()
	{
	}

	public void FinishTutorial()
	{
	}

	public void ReloadTreasureWishListButton()
	{
	}

	public void OnClickTreasureWishList()
	{
	}

	public void OnClickDevResetPickupButton()
	{
	}
}
