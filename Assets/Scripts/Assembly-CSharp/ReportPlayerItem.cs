using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ReportPlayerItem : MonoBehaviour
{
	[SerializeField]
	private PlayerProfile _playerProfile;

	[SerializeField]
	private Button _reportButton;

	private ColosseumPlayerDataResponseModel.ColosseumPlayerData _playerData;

	private ColosseumReportPopup _parent;

	public void Set(ColosseumPlayerDataResponseModel.ColosseumPlayerData playerData, ColosseumReportPopup parent)
	{
	}

	public void OnClickReportPlayer()
	{
	}
}
