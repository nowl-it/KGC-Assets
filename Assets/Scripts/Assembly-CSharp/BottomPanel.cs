using UnityEngine;
using UnityEngine.UI;

public class BottomPanel : MonoBehaviour
{
	public static BottomPanel Instance;

	public ConditionalImage[] shopFreeBadge;

	public Image[] shopFreeBadgeCount;

	public Image[] shopNewBadge;

	public Image[] newHeroBadge;

	public Image newDailyHeroBadge;

	public Image[] heroUpgradableBadge;

	public Image[] heroUpgradableCount;

	public GetMoneyEffect skinTokenEffect;

	public GetMoneyEffect dustEffect;

	public GetMoneyEffect artifactEffect;

	public GetMoneyEffect eventFlagEffect;

	public GetMoneyEffect expBookEffect;

	public GetMoneyEffect unitSoulEffect;

	public GetMoneyEffect seasonalEventFlagEffect;

	public GetMoneyEffect clanTokenEffect;

	public GetMoneyEffect arenaTokenEffect;

	public GetMoneyEffect hardModeTokenEffect;

	public GetMoneyEffect hardModeToken2Effect;

	public GetMoneyEffect voucherEffect;

	public GetMoneyEffect cardLevelUpItemEffect;

	public GetMoneyEffect treasureItemEffect;

	public GetMoneyEffect inventoryItemEffect;

	public GetMoneyEffect shopBoxKeyEffect;

	public GetMoneyEffect territoryItemEffect;

	public GameObject[] mainTabNotifyBadge;

	public ConditionalImage[] gachaFreeBadge;

	public Image[] gachaFreeBadgeCount;

	public Transform[] clanTabIconRoots;

	public GameObject[] clanClearedMissionBalloon;

	public Image[] clanNewChatBadge;

	public Image[] clanNewChatCount;

	public Image[] clanSupportRequestBadge;

	public Image[] clanAttendanceBadge;

	public Image[] clanNewJoinRequestBadge;

	public Image[] clanRaidBadge;

	public Image[] clanCanMandateBadge;

	public GameObject[] colosseumClearedMissionBalloon;

	public GameObject[] colosseumCustomMatchNewBalloon;

	public ImageTextPair pvpTabRedDot;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Reload()
	{
	}

	public void ReloadMainTab()
	{
	}

	public void ReloadClanTab()
	{
	}

	public void ReloadColosseumClearedMissionBalloon()
	{
	}

	public void ReloadPvpTab()
	{
	}
}
