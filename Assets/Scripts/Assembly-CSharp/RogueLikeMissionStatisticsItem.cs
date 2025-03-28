using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeMissionStatisticsItem : MonoBehaviour
{
	[SerializeField]
	private Text _missionTitle;

	[SerializeField]
	private Text _missionDesc;

	[SerializeField]
	private Gauge _statisticsGauge;

	[SerializeField]
	private Image _missionIcon;

	[SerializeField]
	private ConditionalGroup _completed;

	private (MissionStatisticsData statisticsData, bool complete) _statisticsItem;

	public void Set((MissionStatisticsData, bool) missionStatisticsData)
	{
	}

	public void Reload()
	{
	}
}
