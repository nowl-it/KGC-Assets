using System;
using UnityEngine;
using UnityEngine.UI;

public class ClanSkillButton : MonoBehaviour
{
	[SerializeField]
	[ComponentConnect]
	private Text _tier;

	[SerializeField]
	[ComponentConnect]
	private Image _icon;

	[SerializeField]
	[ComponentConnect]
	private ConditionalImageColor _overTier0;

	private Action _onClickHandler;

	public void Set(int tier, string icon, Action onClickHandler)
	{
	}

	public void OnClick()
	{
	}
}
