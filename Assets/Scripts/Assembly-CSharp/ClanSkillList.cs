using UnityEngine;
using UnityEngine.UI;

public class ClanSkillList : MonoBehaviour
{
	[SerializeField]
	[ComponentConnect]
	private ClanProfilePanel _parent;

	[ComponentConnect]
	[SerializeField]
	private Text _level;

	[SerializeField]
	[ComponentConnect]
	private Gauge _expGauge;

	[SerializeField]
	private ClanSkillButton[] _skillButtons;

	public void Set(int clanPoint, int clanTier)
	{
	}
}
