using UnityEngine;
using UnityEngine.UI;

public class RogueLikeMissionPopupItem : MonoBehaviour
{
	[SerializeField]
	private Image _missionIcon;

	[SerializeField]
	private Text _missionTitle;

	[SerializeField]
	private Text _missionDesc;

	[SerializeField]
	private Animator _animator;

	public float popupTime;

	private static readonly int _close;

	public void Show(int missionId)
	{
	}

	public void Bie()
	{
	}
}
