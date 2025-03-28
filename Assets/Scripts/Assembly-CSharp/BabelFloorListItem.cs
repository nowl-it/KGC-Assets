using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class BabelFloorListItem : MonoBehaviour
{
	[SerializeField]
	private Text _floorText;

	[SerializeField]
	private Image _floorBG;

	[SerializeField]
	private ClickableShopItemIcon _rewardIcon;

	[SerializeField]
	private ClickableShopItemIcon _passRewardIcon;

	[SerializeField]
	private RectTransform _enemyUnitRoot;

	[SerializeField]
	private RectTransform[] _playerUnitsRoot;

	[SerializeField]
	private GameObject _clearedUIGroup;

	[SerializeField]
	private GameObject _lockedObject;

	[SerializeField]
	private GameObject _selectedObject;

	[SerializeField]
	private GameObject _flagParent;

	[SerializeField]
	private Text _combatPower;

	private GameObject _flagObject;

	private UnitController _enemyUnit;

	private UnitController[] _playerUnits;

	public ResourceBabelFloor resBabelFloor;

	private BabelFloorListPanel _parent;

	public ClickableShopItemIcon rewardIcon => null;

	public ClickableShopItemIcon passRewardIcon => null;

	private BabelResponseModel.BabelModel _babelData => null;

	private int _babelId => 0;

	private int _babelFloor => 0;

	public void Set(ResourceBabelFloor resBabelFloor, BabelFloorListPanel parent)
	{
	}

	public void ClearUnits()
	{
	}

	public void ReloadUnits()
	{
	}

	public void OnClick()
	{
	}

	private bool IsPassActive()
	{
		return false;
	}

	public void SetSelected(bool set)
	{
	}
}
