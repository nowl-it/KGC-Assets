using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectFirstHeroPanelPotentialItem : MonoBehaviour
{
	[SerializeField]
	private Text _reqLevelText;

	[SerializeField]
	private Text _potentialText;

	[SerializeField]
	private Text _lockedText;

	[SerializeField]
	private GameObject _lockedObject;

	public void Set(ResourceUnit.Potential potential, bool unlocked)
	{
	}
}
