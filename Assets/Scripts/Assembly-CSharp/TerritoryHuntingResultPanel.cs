using System.Collections.Generic;
using Awesomepiece;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingResultPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Text _resultRankText;

	[SerializeField]
	private FlexibleUIElements _rewardItemElements;

	private List<Reward> _rewards;

	private bool _clickedCloseButton;

	private readonly List<ulong> _rewardItemShowWorkTimerKeys;

	private static readonly Dictionary<int, ulong> _huntingResultRewardItemHashDict;

	public void Show(List<Reward> rewards, ResourceTerritoryHunting.TerritoryHuntingRank rank)
	{
	}

	private static ulong GetHuntingResultRewardItemHash(int index)
	{
		return 0uL;
	}

	private void SetRewardItem(int index, GameObject go, TerritoryHuntingRewardItem item)
	{
	}

	public void OnClickSkip()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void ForceClose()
	{
	}
}
