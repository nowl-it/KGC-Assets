using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumMainUI : MonoBehaviour
{
	private static ColosseumMainUI _instance;

	private TerritoryBonusUnitTooltip _territoryBonusUnitTooltip;

	[SerializeField]
	private ColosseumStagePanel _stagePanel;

	[SerializeField]
	private ColosseumEnemyBerserkIcon _enemyBerserkIcon;

	[SerializeField]
	private ColosseumAbilityPanel _abilityPanel;

	[SerializeField]
	private ColosseumPlayersPanel _playersPanel;

	[SerializeField]
	private ColosseumTarotButton _tarotButton;

	[SerializeField]
	private EmoticonPanel _emoticonPanel;

	[SerializeField]
	private Transform _playerStatusIconRoot;

	[SerializeField]
	private Image _uiFoldButtonShowIcon;

	[SerializeField]
	private Image _uiFoldButtonHideIcon;

	public RectTransform cameraPositionRatioRoot;

	[SerializeField]
	private Text _serverAddress;

	private readonly Dictionary<string, ColosseumPlayerStatusIcon> _playerStatusIconDict;

	private bool _isUIFolded;

	public const float TRANSPARENCY_ALPHA = 0.5f;

	public static ColosseumMainUI Instance => null;

	public TerritoryBonusUnitTooltip territoryBonusUnitTooltip => null;

	public ColosseumEnemyBerserkIcon enemyBerserkIcon => null;

	public float phaseLeftTime => 0f;

	public void Init()
	{
	}

	private void Update()
	{
	}

	public void SetStagePanelActive(bool active)
	{
	}

	public void SetPhase(int stage, Scene_Game.ColosseumGamePhase phase, float phaseLengthSecond, Action onTimeOver)
	{
	}

	public void PausePhaseTimer()
	{
	}

	public void ShowOverTime(bool v, float healPer, float overTimeLength, int phase)
	{
	}

	public void ReloadStageBuffs(List<int> eventTriggers)
	{
	}

	public void ReloadPlayerLife(string userId)
	{
	}

	public void ReloadAbilityPanel(BattleManager battleManager)
	{
	}

	public void ReloadAbilityExp(BattleManager battleManager)
	{
	}

	public void ReloadTarotButton()
	{
	}

	public void HandlePlayerReady(string userId, bool isReadied)
	{
	}

	public void HandlePlayerBattleEnd(string userId, bool isWin)
	{
	}

	public void HandlePlayerGameLose(string userId, int rank)
	{
	}

	public void ReloadPlayerWinStreak(string userId)
	{
	}

	public void HandlePlayerAbilityLevelUp(BattleManager battleManager, string userId)
	{
	}

	public void HandleEnemyBerserkValueChanged()
	{
	}

	public void HandleUnitReachAlertLevel(string userId, int unitId, int skinId, int level)
	{
	}

	public void SetInvaderAndInvadeTargetPlayer(string defenseTarget, string attackTarget)
	{
	}

	public void HandleStartStage()
	{
	}

	public void HandleCurrentBattleManagerChanged(BattleManager battleManager)
	{
	}

	public void HideAllPlayerStatusIcons()
	{
	}

	public void FoldUIs(bool fold, bool withAbility = true)
	{
	}

	public void FoldPlayersPanel(bool fold)
	{
	}

	public void ShowEmoticon(string userId, ResourceEmoticon resEmoticon)
	{
	}

	public void OnClickUIFoldButton()
	{
	}

	public void OnClickEmoticonButton()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnClickAbilityInfo(ResourceColosseumAbility resAbility, Vector3 position)
	{
	}

	public void ShowGainAbilityExp(int exp, bool fromWorldTrigger)
	{
	}

	public void ShowTarotAnnouncePanel()
	{
	}

	public void CloseTarotAnnouncePanel()
	{
	}
}
