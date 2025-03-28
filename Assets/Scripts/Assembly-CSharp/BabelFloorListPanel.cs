using System;
using System.Collections.Generic;
using Awesomepiece;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class BabelFloorListPanel : PopupPanel
{
	[SerializeField]
	private Text _babelNameText;

	[SerializeField]
	private Text _babelFloorText;

	[SerializeField]
	private Image _babelThemeImage;

	[SerializeField]
	private CanvasGroup _clearedFloorShortcutButton;

	[SerializeField]
	private ConditionalImage _babelPassImage;

	[SerializeField]
	private UIGridView _floorsView;

	private ScrollRect _floorsScrollRect;

	private int _babelId;

	private List<ResourceBabelFloor> _babelFloors;

	private int _focusedFloor;

	public bool scrollEnabled;

	private float _mousePos;

	private const float Y_DIFF_ON_START = 350f;

	private const float Y_DIFF_DEFAULT = 250f;

	private ResourceBabel _resBabel => null;

	private BabelResponseModel.BabelModel _babelData => null;

	[Obsolete]
	public new void Show()
	{
	}

	public void Show(int babelId)
	{
	}

	private void Reload()
	{
	}

	private void Update()
	{
	}

	public void ScrollUpdate()
	{
	}

	public void FocusToFloor(int floor, float time)
	{
	}

	private void SetCurrentFloorShortCutButtonState()
	{
	}

	public void LoadDeckFromPrefs()
	{
	}

	private void SetBabelFloorItem(int idx, GameObject go)
	{
	}

	public void ReloadFloorUnits()
	{
	}

	public void OnClickCurrentFloorShortCutButton()
	{
	}

	public void OnClickBabelPassButton()
	{
	}

	public void OnClickBabelFloorItem(BabelFloorListItem item)
	{
	}

	public void SetFloorViewUp(bool set)
	{
	}

	public void ShowBabelRewardPanel()
	{
	}

	public static IEnumerable<Reward> GetMergedBabelRewards(int babelId, int start, int end, Func<ResourceBabelFloor, List<Reward>> rewardSelector)
	{
		return null;
	}

	public BabelFloorListItem FindFloorItem(Func<BabelFloorListItem, bool> func)
	{
		return null;
	}

	public void ScrollsToTop(float time = 0f)
	{
	}

	public void ScrollsToBottom(float time = 0f)
	{
	}

	public override bool Close()
	{
		return false;
	}
}
