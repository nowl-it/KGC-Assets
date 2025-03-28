using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeOptionsPanel : RogueLikeEventPanel
{
	private static RogueLikeOptionsPanel _instance;

	[SerializeField]
	private GameObject _optionsPanel;

	[SerializeField]
	private Text _goldText;

	[SerializeField]
	private Text[] _titleTexts;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Image _descIcon;

	[SerializeField]
	private RogueLikeOptionsPanelResultItem[] _results;

	[SerializeField]
	private RogueLikeItemUI _itemUI;

	[SerializeField]
	private Transform _optionsRoot;

	[SerializeField]
	private ConditionalGroup _confirmButtonConditionals;

	[SerializeField]
	private Transform _selectEventTargetsRoot;

	[SerializeField]
	private Image _selectEventTargetsBG;

	[SerializeField]
	private GameObject _finalResultPanel;

	[SerializeField]
	private Text _finalResultNarrativeText;

	[SerializeField]
	private RogueLikeOptionsPanelResultItem _finalResult;

	[SerializeField]
	private Animator _finalResultAnimator;

	[SerializeField]
	private GameObject _rewardPrefab;

	[SerializeField]
	private Transform _rewardsRoot;

	[SerializeField]
	private Text _resultCloseButtonText;

	private readonly List<RogueLikeOptionPanelOption> _options;

	private int _optionCount;

	private static readonly int _finalResultAnimatorSuccessTriggerKey;

	private static readonly int _finalResultAnimatorFailTriggerKey;

	private int _rewardCount;

	private bool _setBG;

	public static RogueLikeOptionsPanel Instance => null;

	private void Awake()
	{
	}

	private void SetBG()
	{
	}

	public override void BeforeOpen(bool isRepeat)
	{
	}

	public override void Show(ResourceRogueLikeEvent resEvent, List<ResourceRogueLikeEvent.Option> options)
	{
	}

	public void AddOption(ResourceRogueLikeEvent.Option option)
	{
	}

	public override void SetDesc(string desc)
	{
	}

	public override void OnClickOption(GameObject go, ResourceRogueLikeEvent.Option option)
	{
	}

	public void OnClickConfirm()
	{
	}

	public override void ShowResult(ResourceRogueLikeEvent.Result result, bool isSuccess)
	{
	}

	public void SetResultIcon(int index, Constants.RogueLikeItemType type, int id)
	{
	}

	public override void SetItem(int index, Constants.RogueLikeItemType type, int tier, int id, int amount, string icon, string customText)
	{
	}

	public override void SetItemOwnedItem(int index, Item item, GameUnit equippedBy)
	{
	}

	public void ShowItemUI(Constants.RogueLikeItemType type, int id)
	{
	}

	public override void SetButtonText(string text)
	{
	}

	public void OnClickClose()
	{
	}

	public void ShowGradation(bool show)
	{
	}
}
