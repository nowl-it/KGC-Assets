using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DealMeterPanel : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[ComponentConnect]
	public FlexibleUIElements itemElements;

	[ComponentConnect]
	public Button damagingButton;

	[ComponentConnect]
	public Button damagedButton;

	[ComponentConnect]
	public Button toggleButton;

	[ComponentConnect]
	public Image toggleArrow;

	private bool _run;

	private List<DealMeterItem> _items;

	private bool _opened;

	private bool _isDamage;

	private Tweener _openTweener;

	private Sequence _toggleBtnTweener;

	[SerializeField]
	private GameObject _devDealLogPanel;

	[SerializeField]
	private Text _devDealLogText;

	[SerializeField]
	private RectTransform _devDealLogLayout;

	private BattleManager _curBattleManager;

	private List<(BattleManager battle, DamageShootData.Type type, Text text)> _devDealLogs;

	public static int DevLOGCount;

	private HashSet<DamageShootData.Type> _filters;

	public void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(bool immediately)
	{
	}

	public void ShowDealLogPanel(bool v)
	{
	}

	public void Run()
	{
	}

	public void Stop()
	{
	}

	public void SetBattleManager(BattleManager battleManager)
	{
	}

	public void SetToggleButtonPos(bool bottom)
	{
	}

	public void ClearAndSetDevLogCount(InputField input)
	{
	}

	public void ToggleFilter(int idx)
	{
	}

	public void SetToggleButtonVisible(bool visible)
	{
	}

	public void Hide(bool immediately)
	{
	}

	public void Update()
	{
	}

	public void Refresh()
	{
	}

	public void Toggle()
	{
	}

	public void ToDamaging()
	{
	}

	public void ToDamaged()
	{
	}

	public void LogBattleStart(BattleManager battle)
	{
	}

	public void LogBattleEnd(BattleManager battle)
	{
	}

	public void LogDev(GameUnit from, GameUnit to, DamageShootData damageShootData)
	{
	}

	public void LogDev(GameUnit from, GameUnit to, DamageInfo info, bool killed)
	{
	}

	private void FilterAllLogs()
	{
	}

	private void Filtering((BattleManager battle, DamageShootData.Type type, Text text) obj)
	{
	}
}
