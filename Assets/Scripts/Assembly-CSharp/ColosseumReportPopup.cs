using Awesomepiece.Model;
using UnityEngine;

public class ColosseumReportPopup : MonoBehaviour, IClosable
{
	[SerializeField]
	private ReportPlayerItem[] _playerItems;

	[SerializeField]
	private GameObject _selectPlayerArea;

	[SerializeField]
	private ReportSubmitPanel _reportSubmitPanel;

	public void Show()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickGoToReportSubmitArea(ColosseumPlayerDataResponseModel.ColosseumPlayerData playerData)
	{
	}

	public void OnClickBackToSelectPlayerArea()
	{
	}

	public void ReloadPlayerItems()
	{
	}
}
