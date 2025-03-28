using UnityEngine;
using UnityEngine.UI;

public class TreasureCardGachaItem : MonoBehaviour
{
	[SerializeField]
	private Image _treasureIllust;

	[SerializeField]
	private Image _treasureFrame;

	[SerializeField]
	private Text _treasureName;

	[SerializeField]
	private Text _roleInfo;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private Image _treasureIcon;

	[SerializeField]
	private Text _treasureSubName;

	[SerializeField]
	private Image[] _glows;

	public ResourceTreasure resTreasure;

	public void Set(ResourceTreasure resTreasure)
	{
	}
}
