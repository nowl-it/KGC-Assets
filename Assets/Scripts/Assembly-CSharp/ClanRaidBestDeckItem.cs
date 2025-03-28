using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidBestDeckItem : MonoBehaviour
{
	[SerializeField]
	private Text _userNameText;

	[SerializeField]
	private Text _castleNameText;

	[SerializeField]
	private Text _scoreText;

	[SerializeField]
	private PlayerProfile _profile;

	[SerializeField]
	private CardPreviewItem[] _cardItems;

	private ClanRaidBestDeckModel _model;

	public void Set(ClanRaidBestDeckModel model)
	{
	}

	public void OnClick()
	{
	}
}
