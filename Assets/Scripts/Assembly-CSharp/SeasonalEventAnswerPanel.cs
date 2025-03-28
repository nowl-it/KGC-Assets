using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeasonalEventAnswerPanel : MonoBehaviour, IComponentConnector
{
	[ComponentConnect]
	public SeasonalEventScorePanel seasonalEventScorePanel;

	public Button[] buttons;

	private int _selectedBtnIdx;

	public void Show(List<bool> roundResults)
	{
	}

	public void OnClickRedTeamButton()
	{
	}

	public void OnClickBlueTeamButton()
	{
	}

	public void Update()
	{
	}
}
