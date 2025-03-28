using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ClanInfo : MonoBehaviour
{
	[ComponentConnect]
	[SerializeField]
	private ClanMark _clanMark;

	[SerializeField]
	[ComponentConnect]
	private Text _clanName;

	[SerializeField]
	[ComponentConnect]
	[FormerlySerializedAs("_clanBattleRanking")]
	private Text _clanRaidRanking;

	[SerializeField]
	[ComponentConnect]
	private Text _weeklyClanPointRanking;

	[SerializeField]
	[ComponentConnect]
	private Text _clanPointRanking;

	public void Set(ClanModel clan)
	{
	}
}
