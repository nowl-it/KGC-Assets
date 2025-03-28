using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ColosseumPlayersPanel : MonoBehaviour
{
	private class UserInfoState
	{
		public ColosseumPlayerInfo playerInfo;

		public ColosseumData colosseumData;

		public bool isFolded;

		public Tween foldTween;
	}

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Transform _userInfosRoot;

	private readonly List<UserInfoState> _userInfos;

	private bool _isUserInfosFolded;

	public void AddPlayer(ColosseumData playerData)
	{
	}

	public void FitUsersLayout()
	{
	}

	public void ReloadPlayerSortingOrder()
	{
	}

	public ColosseumPlayerInfo GetUserInfo(string userId)
	{
		return null;
	}

	public void FoldPlayerInfo(string userId, bool fold)
	{
	}

	public void FoldAllPlayers(bool fold)
	{
	}

	private void FoldPlayerInfoImpl(UserInfoState infoState, bool fold)
	{
	}

	public void ShowCancelReadyAnimationAll()
	{
	}

	public void SetStateIcon(string defenseTarget, string attackTarget)
	{
	}

	public void HandleCurrentBattleManagerChanged(BattleManager battleManager)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void SetInteractable(bool set)
	{
	}
}
