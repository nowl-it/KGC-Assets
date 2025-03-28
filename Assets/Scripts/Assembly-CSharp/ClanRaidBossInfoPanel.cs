using UnityEngine;
using UnityEngine.UI;

public class ClanRaidBossInfoPanel : MonoBehaviour
{
	[SerializeField]
	private Image _bossImage;

	[SerializeField]
	private Text _bossNameText;

	[SerializeField]
	private Text _difficultyText;

	[SerializeField]
	private Image _hpBarGauge;

	[SerializeField]
	private Text _hpText;

	[SerializeField]
	private CanvasGroup _bossInfoUI;

	[SerializeField]
	private UIFitter[] _bossInfoUIFitters;

	[SerializeField]
	private GameObject _potentialPartition;

	[SerializeField]
	private FlexibleUIElements _bossPhaseElements;

	[SerializeField]
	private Image _bossSkillImage;

	[SerializeField]
	private TextSet _bossSkillTextSet;

	private Vector2 _hpBarGaugeSize;

	private ResourceUnit _resBoss;

	private void Awake()
	{
	}

	public void Set(int bossId, int difficulty, int currentHp, int killCount = -1, int attemptCount = 0, bool isPracticeBattle = false, bool infoMode = false)
	{
	}

	private void SetBossSkill(ResourceUnit resUnit)
	{
	}

	private void SetBossPotentials(ResourceUnit resUnit, int difficulty)
	{
	}

	public void ShowBossInfo()
	{
	}
}
