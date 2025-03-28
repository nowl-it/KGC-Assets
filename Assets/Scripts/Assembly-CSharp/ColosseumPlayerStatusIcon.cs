using UnityEngine;
using UnityEngine.UI;

public class ColosseumPlayerStatusIcon : MonoBehaviour
{
	public enum Status
	{
		Ready = 0,
		Win = 1,
		Lose = 2
	}

	[SerializeField]
	private ProfileAvatar _avatar;

	[SerializeField]
	private Text _playerNameText;

	[SerializeField]
	private ConditionalGroup _statusIconConditionals;

	public void SetPlayer(ColosseumData colosseumData)
	{
	}

	public void Show(Status status)
	{
	}

	public void Hide()
	{
	}
}
