using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RogueLikeBasePanel : MonoBehaviour
{
	private static RogueLikeBasePanel _instance;

	[SerializeField]
	private RogueLikeHeroIcon[] _heroes;

	[SerializeField]
	private RogueLikeArtifactIcon[] _artifacts;

	[SerializeField]
	private RogueLikeBasePanelAltar[] _altars;

	[SerializeField]
	private ConditionalBase[] _mainAltarConditionals;

	[SerializeField]
	private GameObject _mainAltarEffectsRoot;

	[SerializeField]
	private Image _altarLightEffectImage;

	[SerializeField]
	private Animator _flame;

	[SerializeField]
	private GameObject _countArea;

	[SerializeField]
	private GameObject _viewMapButton;

	[SerializeField]
	private RogueLikeItemUI _artifactInfoPanel;

	[SerializeField]
	private GameObject[] _heroTier1PotentialNotifyObjects;

	public CanvasGroup gradation;

	public RectTransform goldArea;

	public RectTransform unitCountArea;

	public Text goldText;

	public Text heroCountText;

	[SerializeField]
	private Text _goldEffect;

	private int _heroesPage;

	private readonly List<int> _heroTier1PotentialNotifies;

	private int _goldEffectCount;

	private int _highestAltarIndex;

	public static readonly int FlameIndexKey;

	public static readonly int FlameLevelKey;

	private float _lastCallTime;

	public static RogueLikeBasePanel Instance => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void Init()
	{
	}

	public void ReloadHeroes()
	{
	}

	public void ReloadHero(int id)
	{
	}

	private void CheckTier1PotentialNotify(int index)
	{
	}

	public void OnClickHeroesArrow(int dir)
	{
	}

	public RogueLikeArtifactIcon GetPointerOverPanelArtifact(PointerEventData eventData)
	{
		return null;
	}

	public void ReloadArtifacts()
	{
	}

	public void ReloadAltars()
	{
	}

	public void ShowRogueLikeBuildingPanel()
	{
	}

	public void OnClickShowLevelGeneratorButton()
	{
	}

	public void OnClickArtifactIcon(int index)
	{
	}

	public void ShowTier1PotentialNotify(int unitId, bool show)
	{
	}

	public void ShowPotentialUnlockText(int unitId, int level)
	{
	}

	public void SetArtifactFocus(bool set)
	{
	}

	public RogueLikeArtifactIcon GetArtifactIcon(RogueLikeArtifactModel model)
	{
		return null;
	}

	public void HandleSetGold(int v)
	{
	}

	public void HandleReloadHeroCount()
	{
	}

	public void ShowAddGold(int gold)
	{
	}

	private void ShowAddGoldInner(int gold, Text goldEffectText = null)
	{
	}

	public void HandleSetAreaPositionRatio(float ratio)
	{
	}
}
