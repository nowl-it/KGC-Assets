using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvancedCardInfoPanel : PopupPanel
{
	[SerializeField]
	private TabManager _tabManager;

	[SerializeField]
	[Space(10f)]
	[Space(20f)]
	private SkillInfoPanel _skillInfoPanel;

	[SerializeField]
	private Image _skillFrame;

	[Space(10f)]
	[SerializeField]
	private Image _tilePrefab;

	[SerializeField]
	private RectTransform _tilesRoot;

	private List<Image> _tiles;

	[SerializeField]
	private Color _tileBaseColor;

	[SerializeField]
	private Color _tileUnitColor;

	[SerializeField]
	private Color _tileAtkRangeColor;

	[SerializeField]
	private Color _tileSkillRangeColor;

	private static Vector2Int _tileSize;

	private List<Vector2Int> _allTiles;

	[Space(10f)]
	[SerializeField]
	private GameObject[] _potentialLocked;

	[SerializeField]
	private List<Text> _potentialLevels;

	[SerializeField]
	private List<Text> _potentialOptions;

	[SerializeField]
	private List<PotentialButton> _potentialButtons;

	[SerializeField]
	private Tooltip _potentialTooltip;

	[SerializeField]
	private Button _potentialTooltipSetToAllButton;

	[Space(10f)]
	[SerializeField]
	private RectTransform _skillIconsRoot;

	[SerializeField]
	private UnitSkillDisplayer _skillIconPrefab;

	private List<UnitSkillDisplayer> _skillIcons;

	private ResourceUnit _resUnit;

	private CardData _cardData;

	private bool _ownCard;

	private int _unitLevel;

	private ResourceSkill _resSkill;

	private bool _inited;

	private Vector2Int _tileCenterPos => default(Vector2Int);

	public List<Vector2Int> allTiles => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(ResourceUnit resUnit, CardData cardData = null, bool ownCard = true)
	{
	}

	private void Reload(int idx)
	{
	}

	private void ReloadSkillInfoTab(int skillLevel = 1)
	{
	}

	private int GetTileIdx(Vector2Int pos)
	{
		return 0;
	}

	private void ReloadRangeUI()
	{
	}

	private void ClearTiles(bool force = false, Vector2Int? basePos = null)
	{
	}

	private void ShowUnitRange()
	{
	}

	private void ShowAtkRange()
	{
	}

	private void ShowSkillRange()
	{
	}

	private void CancelInvokeRepetition()
	{
	}

	private void ReloadPotential()
	{
	}

	public void ShowPotentialTooltip(int idx)
	{
	}

	public void OnClickPotentialSetToAll()
	{
	}

	public override bool Close()
	{
		return false;
	}
}
