using UnityEngine;
using UnityEngine.UI;

public class ColosseumRankingPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Button _hallOfFameButton;

	public void Show()
	{
	}

	public void OnClickHallOfFameButton()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
