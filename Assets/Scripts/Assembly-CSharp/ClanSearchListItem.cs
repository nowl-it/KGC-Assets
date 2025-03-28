using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanSearchListItem : MonoBehaviour
{
	[ComponentConnect]
	public ClanMark clanMark;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text weeklySupportText;

	[ComponentConnect]
	public Text memberCountText;

	[ComponentConnect]
	public Text joinTypeText;

	[ComponentConnect]
	public GameObject requested;

	[SerializeField]
	private Text _tagText;

	[SerializeField]
	private TextFitter _tagTextFitter;

	[SerializeField]
	private MovingText _tagTextMovingComponent;

	public void Set(ClanModel clan)
	{
	}
}
