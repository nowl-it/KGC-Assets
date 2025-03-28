using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfile : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _castleNameText;

	[SerializeField]
	private Text _kingNameText;

	[SerializeField]
	private Text _rankText;

	[SerializeField]
	private Transform _nameTagRoot;

	[SerializeField]
	private Button _button;

	private NameTag _nameTag;

	private int _accountId;

	public void Set(int iconId, [NotNull] ResourceNameTag resNameTag, string castleName, string kingName)
	{
	}

	private void OnDestroy()
	{
	}

	public void ShowNameTagWings(bool show)
	{
	}

	public void ShowNameTag(bool show)
	{
	}

	public void ShowRankText(bool show)
	{
	}

	public void SetRankText(string text, Font font)
	{
	}

	public void SetAccountId(int accountId)
	{
	}

	public void SetOnClick(Action<int> onClick)
	{
	}
}
