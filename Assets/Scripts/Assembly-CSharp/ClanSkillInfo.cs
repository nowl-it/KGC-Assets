using UnityEngine;
using UnityEngine.UI;

public class ClanSkillInfo : MonoBehaviour
{
	[SerializeField]
	[ComponentConnect]
	private Text _title;

	[SerializeField]
	[ComponentConnect]
	private Text _tier;

	[SerializeField]
	[ComponentConnect]
	private Text _desc;

	[SerializeField]
	[ComponentConnect]
	private Text _nextTier;

	[ComponentConnect]
	[SerializeField]
	private Text _nextTierDesc;

	[ComponentConnect]
	[SerializeField]
	private Text _nextTierReqLevel;

	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	[SerializeField]
	private ConditionalGroup _overTier0;

	[SerializeField]
	private ConditionalGroup _hasNextReqLevel;

	public void Show(string title, int tier, string desc, int nextTier, string nextTierDesc, int nextTierReqLevel)
	{
	}
}
