using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour, IClosable, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLeftAccountStep3_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTestRanking_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003COnClickTogglePush_AllianceSupport_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SettingsPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTogglePush_Flag_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SettingsPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTogglePush_Food_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SettingsPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTogglePush_Hunting_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SettingsPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTogglePush_StoredLabor_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SettingsPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003CShowAccountTransferCode_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<Awesomepiece.Model.TransferCodeResponseModel>.Awaiter _003C_003Eu__1;

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

	public VolumeControler volumeControler;

	[ComponentConnect]
	public LocalePanel localePanel;

	[ComponentConnect]
	public Text localeText;

	[ComponentConnect]
	public GameObject credit;

	[ComponentConnect]
	public Text uid;

	[ComponentConnect]
	public GameObject leftConfirmPopup;

	[ComponentConnect]
	public InputField leftInputField;

	[ComponentConnect]
	public GameObject transferButton;

	[ComponentConnect]
	public GameObject linkAccountButton;

	[ComponentConnect]
	public LinkAccountPanel linkAccountPanel;

	[ComponentConnect]
	public CouponPanel couponPanel;

	[ComponentConnect]
	public Button couponButton;

	[ComponentConnect]
	public GameObject touchEffectToggle;

	[ComponentConnect]
	public GameObject slotSaveToggle;

	[ComponentConnect]
	public GameObject territoryUnitDragToggle;

	[ComponentConnect]
	public GameObject useDefaultLoginIllustToggle;

	[ComponentConnect]
	public GameObject pushFoodToggle;

	[ComponentConnect]
	public GameObject pushFlagToggle;

	[ComponentConnect]
	public GameObject pushAllianceSupportToggle;

	[ComponentConnect]
	public GameObject pushStoredLaborToggle;

	[ComponentConnect]
	public GameObject pushHuntingToggle;

	[ComponentConnect]
	public ConditionalRootGroup autoBattleInfoGroup;

	[ComponentConnect]
	public ConditionalRootGroup sellAreaInfoGroup;

	[ComponentConnect]
	public ConditionalRootGroup autoMergeInfoGroup;

	[ComponentConnect]
	public ConditionalRootGroup damageShooterInfoGroup;

	[ComponentConnect]
	public ConditionalRootGroup rankingStageInfoGroup;

	[ComponentConnect]
	public ConditionalRootGroup sellManyInfoGroup;

	public GameObject restoreButton;

	public GameObject accountTransferTable;

	public GameObject accountTransferEnterCodeObj;

	public InputField accountTransferCodeInputField;

	public EarlyAccessEnterPanel earlyAccessEnterPanel;

	public Button earlyAccessButton;

	public Text earlyAccessButtonText;

	private Localizer.Locale _locale;

	private float _lastTap;

	private int _tapCount;

	public void Show()
	{
	}

	private void ReloadOnOffTab()
	{
	}

	private void ReloadEarlyAccessButtonText()
	{
	}

	public void Hide()
	{
	}

	public void OnClickLogout()
	{
	}

	public void OnClickIngameTutorial()
	{
	}

	public void OnClickOutgameTutorial()
	{
	}

	public void OnClickArtifactTutorial()
	{
	}

	public void OnClickArenaTutorial()
	{
	}

	public void OnClickSummonTutorial()
	{
	}

	public void OnClickTerritoryTutorial()
	{
	}

	public void OnClickTreasureTutorial()
	{
	}

	public void OnClickAccessoryTutorial()
	{
	}

	public void OnClickChapter16Tutorial()
	{
	}

	public void OnClickTutorial(InputField inputField)
	{
	}

	public void OnClickLocaleButton()
	{
	}

	public void OnSelectLocale(Localizer.Locale locale)
	{
	}

	public void OnClickCS()
	{
	}

	public void OnClickTouchEffect()
	{
	}

	private void ReloadTouchEffect()
	{
	}

	private void ReloadPushes()
	{
	}

	private bool IsNightPushOff()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003COnClickTogglePush_Food_003Ed__57))]
	public void OnClickTogglePush_Food()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTogglePush_Flag_003Ed__58))]
	public void OnClickTogglePush_Flag()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTogglePush_AllianceSupport_003Ed__59))]
	public void OnClickTogglePush_AllianceSupport()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTogglePush_StoredLabor_003Ed__60))]
	public void OnClickTogglePush_StoredLabor()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTogglePush_Hunting_003Ed__61))]
	public void OnClickTogglePush_Hunting()
	{
	}

	public void OnClickSlotSave()
	{
	}

	private void ReloadSlotSaveText()
	{
	}

	public void OnClickTerritoryUnitDrag()
	{
	}

	private void ReloadTerritoryUnitDragText()
	{
	}

	public void OnClickUseDefaultLoginIllust()
	{
	}

	private void ReloadUseDefaultLoginIllust()
	{
	}

	public void OnClickTerms()
	{
	}

	public void OnClickCredit()
	{
	}

	public void OnClickCreditClose()
	{
	}

	public void OnClickRestore()
	{
	}

	public void OnClickLeftAccount()
	{
	}

	private void LeftAccountStep1()
	{
	}

	private void LeftAccountStep2()
	{
	}

	public void OnClickLeftConfirmInputButton(bool yes)
	{
	}

	[AsyncStateMachine(typeof(_003CLeftAccountStep3_003Ed__76))]
	private void LeftAccountStep3()
	{
	}

	public void OnClickChangeNickname()
	{
	}

	public void OnClickAccountTransfer(bool active)
	{
	}

	public void OnClickAccountTransferMakeCode()
	{
	}

	public void OnClickAccountTransferEnterCode()
	{
	}

	public void OnClickAccountTransferConfirm(bool yes)
	{
	}

	[AsyncStateMachine(typeof(_003CShowAccountTransferCode_003Ed__82))]
	private void ShowAccountTransferCode()
	{
	}

	public void OnClickTestTapjoy()
	{
	}

	public void OnClickTestAdmob()
	{
	}

	public void OnClickTestUnityAds()
	{
	}

	public void OnClickTestMediation()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTestRanking_003Ed__87))]
	public void OnClickTestRanking()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void CopyUidToClipboard()
	{
	}

	public void OnClickSRDebugger()
	{
	}

	public void OnClickLinkAccount()
	{
	}

	[OnClick("CouponButton", true)]
	public void OnClickCoupon()
	{
	}

	public void OnClickEarlyAccessButton()
	{
	}

	public void OnClickPushAlarm()
	{
	}

	public void OnClickMakeAlarm()
	{
	}

	public void OnClickCheckStatsAlarm(InputField inputField)
	{
	}

	public void OnClickRemoveAlarm(InputField inputField)
	{
	}

	public void OnClickInfo(GameObject info)
	{
	}

	public void OnClickInGameSettingButton(ConditionalRootGroup cg, string key, int value)
	{
	}

	public void OnClickToggleAutoBattle(int value)
	{
	}

	public void OnClickChangeSellArea(int value)
	{
	}

	public void OnClickToggleAutoMerge(int value)
	{
	}

	public void OnClickToggleDamageShooter(int value)
	{
	}

	public void OnClickToggleRankingStage(int value)
	{
	}

	public void OnClickToggleSellMany(int value)
	{
	}

	public void ReloadGameSettingButtonsAll()
	{
	}
}
