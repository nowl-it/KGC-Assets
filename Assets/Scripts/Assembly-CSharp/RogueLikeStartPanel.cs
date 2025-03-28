using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeStartPanel : MonoBehaviour, IClosable
{
	[Serializable]
	public struct AltarStat
	{
		public Image icon;

		public Text level;
	}

	[SerializeField]
	private Button _selectHeroButton;

	[SerializeField]
	private Button _selectBuildingButton;

	[SerializeField]
	private ConditionalGroup _startButton;

	[SerializeField]
	private ConditionalGroup _buildingSettingCond;

	[SerializeField]
	private ConditionalImage _startButtonConditionalImage;

	[SerializeField]
	private Text _startButtonText;

	[SerializeField]
	private GameObject _buttonCost;

	[SerializeField]
	private Text _startButtonCostText;

	[SerializeField]
	private GameObject _challengeButton;

	[SerializeField]
	private ConditionalGroup _rankingButton;

	[SerializeField]
	private GameObject _closeButton;

	[SerializeField]
	[Header("StartPopup_RogueLike")]
	private GameObject _themeBox;

	[SerializeField]
	private GameObject _myDeck;

	[SerializeField]
	private GameObject _altarBox;

	[SerializeField]
	private List<AltarPreviewItem> _altarPreviewItems;

	[SerializeField]
	private GameObject _savedDeck;

	[SerializeField]
	private DraggableUnitCard _selectedUnit;

	[SerializeField]
	private UnitStatBox _selectedUnitStatBox;

	[SerializeField]
	private Text _floorText;

	[SerializeField]
	private List<CardPreviewItem> _cardPreviewItems;

	[SerializeField]
	private AltarPreviewItem _altarPreviewItem;

	[SerializeField]
	private RogueLikeMissionButton _missionButton;

	[SerializeField]
	private GameObject _unitBundlePackageButton;

	[SerializeField]
	private List<AltarStat> _altarStats;

	[SerializeField]
	private List<ArtifactCraftSlot> _artifactCraftSlots;

	[SerializeField]
	private Button _cardPreviewLeft;

	[SerializeField]
	private Button _cardPreviewRight;

	[SerializeField]
	private Image _maximumBossIcon;

	[SerializeField]
	private CanvasGroup _rewardInfo;

	[SerializeField]
	private Text _currentRewardInfo;

	[SerializeField]
	private Text _heartRemainText;

	private RogueLikeSelectFirstHeroPanel _rogueLikeSelectFirstHeroPanel;

	private RogueLikeSelectFirstBuildingPanel _rogueLikeSelectFirstBuildingPanel;

	private RogueLikeBuildingPackagePanel _rogueLikeBuildingPackagePanel;

	private RogueLikeRankingPanel _rogueLikeRankingPanel;

	private RogueLikeChallengePanel _rogueLikeChallengePanel;

	private LongTextPanel _longTextPanel_rogueLike;

	private Sequence _rewardInfoSequence;

	private int _curRogueLikeCardsPreviewIdx;

	public RogueLikeMissionButton missionButton => null;

	public bool isRogueLikeSelectFirstHeroPanelInstantiated => false;

	public RogueLikeSelectFirstHeroPanel rogueLikeSelectFirstHeroPanel => null;

	public RogueLikeSelectFirstBuildingPanel rogueLikeSelectFirstBuildingPanel => null;

	public RogueLikeBuildingPackagePanel rogueLikeBuildingPackagePanel => null;

	public RogueLikeRankingPanel rogueLikeRankingPanel => null;

	public RogueLikeChallengePanel rogueLikeChallengePanel => null;

	public LongTextPanel longTextPanel_rogueLike => null;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public bool Show()
	{
		return false;
	}

	public void Reload()
	{
	}

	public void ReloadStartButton()
	{
	}

	private void ReloadRogueLikeChallengeButton()
	{
	}

	public void OnClickRogueLikeChallengeButton()
	{
	}

	public void ShowRogueLikeRewardInfo()
	{
	}

	public void OnClickRogueLikeRanking()
	{
	}

	public void ShowRogueLikeIntroCutscene()
	{
	}

	public void OnClickRogueLikeInfoButton()
	{
	}

	public void ShowRogueLikeSelectFirstHeroPanel()
	{
	}

	public void ShowRogueLikeSelectFirstBuildingPanel()
	{
	}

	public void ShowRogueLikeBuildingPackagePanel(int dlc)
	{
	}

	public void DeleteRogueLikeSavedGame()
	{
	}

	public void SlideCardPreviewPage(int idx)
	{
	}

	public void OnClickGameStart()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
