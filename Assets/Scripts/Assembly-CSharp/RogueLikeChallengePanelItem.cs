using UnityEngine;
using UnityEngine.UI;

public class RogueLikeChallengePanelItem : MonoBehaviour
{
	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private GameObject _activatedMask;

	[SerializeField]
	private ConditionalGroup _lockedConditionals;

	public void Set(int level)
	{
	}

	public void SetLocked(bool locked)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void SetActivated(bool activated)
	{
	}
}
