using UnityEngine;
using UnityEngine.UI;

public class ClanPanel : BaseLobbyPanel
{
	public static ClanPanel Instance;

	[ComponentConnect]
	public SearchClanPanel searchClanPanel;

	private ClanProfilePanelOld _clanProfilePanelOld;

	private ClanMemberListPopup _clanMemberListPopup;

	private ClanProfilePopup _clanProfilePopup;

	private CreateClanPanel _createClanPanel;

	private ClanMarkPanel _clanMarkPanel;

	[ComponentConnect]
	public ClanChatPanel clanChatPanel;

	[ComponentConnect]
	public ClanProfilePanel clanProfilePanel;

	private ClanMenuPanel _clanMenuPanel;

	private ClanSupportCompletePanel _clanSupportCompletePanel;

	[ComponentConnect]
	public TabManager clanTopBar;

	public ClanRaidStartPanel clanRaidStartPanel;

	private ClanRaidSeasonEndPanel _clanRaidSeasonEndPanel;

	private bool _clanRaidEnabled;

	private ClanRankingPanel _clanRankingPanel;

	private ClanShopPanel _clanShopPanel;

	private ClanRaidProgressPanel _clanRaidProgressPanel;

	[ComponentConnect]
	public ClanGoldBonus clanGoldBonus;

	[SerializeField]
	private Text _clanProfileText;

	[SerializeField]
	private Button _clanChatButton;

	[SerializeField]
	private GameObject _unitBundlePackage;

	private bool _lastHasClan;

	public ClanProfilePanelOld clanProfilePanelOld => null;

	public bool isClanMemberListPopupInstantiated => false;

	public ClanMemberListPopup clanMemberListPopup => null;

	public ClanProfilePopup clanProfilePopup => null;

	public CreateClanPanel createClanPanel => null;

	public ClanMarkPanel clanMarkPanel => null;

	public ClanMenuPanel clanMenuPanel => null;

	public bool showingSettingPanel => false;

	public ClanSupportCompletePanel clanSupportCompletePanel => null;

	public ClanRaidSeasonEndPanel clanRaidSeasonEndPanel => null;

	public ClanRankingPanel clanRankingPanel => null;

	public ClanShopPanel clanShopPanel => null;

	public ClanRaidProgressPanel clanRaidProgressPanel => null;

	public void PreInit()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClickClanTab(int tabIdx)
	{
	}

	public void Reload()
	{
	}

	public override void OnPanelEnabled()
	{
	}

	public override void OnPanelDisabled()
	{
	}

	public override void Init()
	{
	}

	public void OnClickClanRaid()
	{
	}

	public void OnClickClanRanking()
	{
	}

	public void OnClickClanShop()
	{
	}
}
