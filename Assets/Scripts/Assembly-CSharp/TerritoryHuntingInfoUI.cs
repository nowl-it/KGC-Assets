using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingInfoUI : MonoBehaviour
{
	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private ConditionalImage _chapterIconConditionalImage;

	[SerializeField]
	private Text _chapterText;

	[SerializeField]
	private Image _regionImage;

	[SerializeField]
	private ThemeThumbnail _themeThumbnail;

	[SerializeField]
	private Text _timeText;

	[SerializeField]
	private Text _ticketCostText;

	[SerializeField]
	private Text _heartCostText;

	private ResourceUnit.Region _bonusRegion;

	private void Awake()
	{
	}

	public void Set(ResourceTerritoryHunting resHunting, ResourceUnit.Region region, int foodBoosterLevel, float heroAssignmentBenefitPer)
	{
	}

	public void ReloadTicketCost()
	{
	}

	public void ReloadHeartCost(int foodBoosterLevel)
	{
	}

	public void OnClickShowBonusUnitTooltip()
	{
	}
}
