using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;

public class RewardListResultPanel : PopupPanel
{
	[SerializeField]
	private Animator _resultPanel;

	[SerializeField]
	private ClickableShopItemIcon _resultItemPrefab;

	[SerializeField]
	private FittingUI _fittingUI;

	private List<ClickableShopItemIcon> _resultItems;

	[SerializeField]
	private RectTransform _resultItemsRoot;

	private Action _onClose;

	[Obsolete]
	public override void Show()
	{
	}

	public void ShowResultPanel(RewardListResponseData rewardListResponse, Action onClose = null)
	{
	}

	public void CloseResultPanel()
	{
	}

	public override bool Close()
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
