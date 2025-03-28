using UnityEngine;
using UnityEngine.UI;

public class PvPRankingPanel : MonoBehaviour, IClosable
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
