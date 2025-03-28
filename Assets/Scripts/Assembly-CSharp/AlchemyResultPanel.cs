using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class AlchemyResultPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Text _jackpot;

	[SerializeField]
	private ClickableShopItemIcon _clickableShopItem;

	private Action _onClose;

	public void Show(RewardListResponseData reward, int jackpotLevel, Action onClose = null)
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
