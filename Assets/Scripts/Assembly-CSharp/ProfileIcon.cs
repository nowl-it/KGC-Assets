using System;
using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;

public class ProfileIcon : MonoBehaviour
{
	public Image iconSprite;

	public Image iconBackground;

	public UIEffect iconSpriteEffect;

	public UIEffect iconBackgroundEffect;

	public Image selectBackground;

	public Text equipped;

	private Action<int> _onClickCallback;

	public Text rankingText;

	private int _id;

	private bool _hasCard;

	public void Set(int id, int background, bool hasCard = true, Action<int> onClickCallback = null)
	{
	}

	public bool HasCard()
	{
		return false;
	}

	public int GetId()
	{
		return 0;
	}

	public void ClearCallback()
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool v)
	{
	}

	public void SetEquipped(bool v)
	{
	}

	private void SetRank(int rank, int tier)
	{
	}
}
