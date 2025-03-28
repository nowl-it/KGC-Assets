using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidStartPanel : MonoBehaviour, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CTestResetRemainBattleCount_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CTestSetBossKillCount_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CTestSetGoldBonus_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[ComponentConnect]
	public Image bossImage;

	[ComponentConnect]
	public Text bossNameText;

	[ComponentConnect]
	public Text phaseText;

	[ComponentConnect]
	public Button refreshButton;

	[ComponentConnect]
	public Text refreshTimeText;

	[ComponentConnect]
	public Image bossHpGauge;

	[ComponentConnect]
	public Text bossHpText;

	[ComponentConnect]
	public Text bossStageText;

	[ComponentConnect]
	public ConditionalImage bossFrame;

	[ComponentConnect]
	public Image bossIcon;

	[ComponentConnect]
	public ClanRaidDeckItem retryDeck;

	[ComponentConnect]
	public PlayerProfile currentPlayerProfile;

	[ComponentConnect]
	public Text currentPlayerRoleText;

	[ComponentConnect]
	public Text currentPlayerNameText;

	[ComponentConnect]
	public Text flagRemainTimeText;

	[ComponentConnect]
	public Text clanRaidRemainTimeText;

	private int _currentUnit;

	private bool _awaken;

	private DateTime _lastRefreshTime;

	private const int REFRESH_COOLTIME = 30;

	private ClanRaidSelectDeckPanel _clanRaidSelectDeckPanel;

	private ClanRaidDeckPanel _clanRaidDeckPanel;

	private ClanRaidDeckSettingPanel _clanRaidDeckSettingPanel;

	private ClanRaidBossGuideInfoPanel _clanRaidBossGuideInfoPanel;

	private ClanRaidRankRewardPanel _clanRaidRankRewardPanel;

	private ClanRaidRetryAlertPanel _clanRaidRetryAlertPanel;

	private ClanRaidFieldUnitInfoPanel _clanRaidFieldUnitInfoPanel;

	public ClanRaidSelectDeckPanel clanRaidSelectDeckPanel => null;

	public ClanRaidDeckPanel clanRaidDeckPanel => null;

	public ClanRaidDeckSettingPanel clanRaidDeckSettingPanel => null;

	public ClanRaidBossGuideInfoPanel clanRaidBossGuideInfoPanel => null;

	public ClanRaidRankRewardPanel clanRaidRankRewardPanel => null;

	public ClanRaidRetryAlertPanel clanRaidRetryAlertPanel => null;

	public ClanRaidFieldUnitInfoPanel clanRaidFieldUnitInfoPanel => null;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void Show()
	{
	}

	private void Reload()
	{
	}

	private void ShowBossInfo(int unit)
	{
	}

	public void OnClickDeckSetting()
	{
	}

	public void OnClickStartBattle()
	{
	}

	public void OnClickPracticeBattle()
	{
	}

	public void OnClickProgress()
	{
	}

	public void OnClickRefresh()
	{
	}

	public void OnClickBossGuide()
	{
	}

	public void OnClickRankReward()
	{
	}

	public int GetBossIndexByIdx(int bossID)
	{
		return 0;
	}

	private void UpdateRemainFlag()
	{
	}

	private void UpdateRefresh()
	{
	}

	[AsyncStateMachine(typeof(_003CTestResetRemainBattleCount_003Ed__57))]
	public void TestResetRemainBattleCount()
	{
	}

	[AsyncStateMachine(typeof(_003CTestSetGoldBonus_003Ed__58))]
	public void TestSetGoldBonus(InputField goldBonusTier)
	{
	}

	[AsyncStateMachine(typeof(_003CTestSetBossKillCount_003Ed__59))]
	public void TestSetBossKillCount(InputField killCount)
	{
	}
}
