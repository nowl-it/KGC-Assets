using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryTopPanel : TopPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickFirework_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryTopPanel _003C_003E4__this;

		private PlayerTerritoryTycoonResponseModel _003Cdata_003E5__2;

		private UniTask<TerritoryTycoonFireworkResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickItemDev_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryTopPanel _003C_003E4__this;

		public int idx;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CRecoverLabor_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryTopPanel _003C_003E4__this;

		private UniTask<TerritoryRecoverLaborResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CRecoverSeasonalEventToken_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryTopPanel _003C_003E4__this;

		private UniTask<PlayerTerritoryTycoonResponseModel>.Awaiter _003C_003Eu__1;

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

	[SerializeField]
	private Gauge _laborGauge;

	[SerializeField]
	private ConditionalGroup _laborGaugeConditionals;

	[SerializeField]
	private Text _laborTimerText;

	public GetMoneyEffect laborGetEffect;

	[SerializeField]
	private ConditionalImage _passButtonCond;

	[SerializeField]
	private Gauge _tycoonLevelGauge;

	public Text tycoonLevelText;

	public LerpText tycoonPointText;

	public LerpText consumableTokenText;

	public LerpText gachaTokenText;

	public LerpText skinTokenText;

	public GetMoneyEffect seasonalEventTokenGetEffect;

	public GetMoneyEffect consumableTokenGetEffect;

	public GetMoneyEffect gachaTokenGetEffect;

	public GetMoneyEffect skinTokenGetEffect;

	public GetMoneyEffect itemGetEffect;

	public GetMoneyEffect tycoonPointGetEffect;

	public GameObject tycoonInfoPopup;

	public Text territoryTycoonMissionTotalClearedMissionBadgeText;

	[SerializeField]
	private Text _fireworkReqPointText;

	[SerializeField]
	private ConditionalSetActive _fireworkCond;

	private int _lastLabor;

	private bool _processingRecoverSeasonalToken;

	private bool _processingFirework;

	private int _lastBuildingCount;

	private int _lastTycoonLevel;

	private DateTime _recoverLaborCooltime;

	private DateTime _recoverSeasonalEventTokenCooltime;

	public override void Init()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void ReloadAll(bool force = false)
	{
	}

	public void Reload(Scene_Territory.TerritoryType territoryType = Scene_Territory.TerritoryType.Default)
	{
	}

	protected override void OnApplicationPause(bool pauseStatus)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickItemDev_003Ed__32))]
	public override void OnClickItemDev(int idx)
	{
	}

	public void ReloadLabor()
	{
	}

	public void LaborGetEffectCallBack(int labor, int maxLabor)
	{
	}

	public void ReloadLaborTimer()
	{
	}

	[AsyncStateMachine(typeof(_003CRecoverLabor_003Ed__37))]
	public void RecoverLabor()
	{
	}

	public void SkinTokenGetEffectCallBack(int token)
	{
	}

	[AsyncStateMachine(typeof(_003CRecoverSeasonalEventToken_003Ed__40))]
	public void RecoverSeasonalEventToken()
	{
	}

	public void ReloadTerritoryTycoonInfo(bool fireworkReload = false, bool collectSkinTokenReload = false)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickFirework_003Ed__42))]
	public void OnClickFirework()
	{
	}

	public void OnClickTerritoryTycoonPoint()
	{
	}

	public void OnClickTycoonInfo()
	{
	}

	public void OnClickTerritoryTycoonMission()
	{
	}

	public void OnClickSpecialSeasonalEventShop()
	{
	}

	public void ReloadPassButton(bool buyPass)
	{
	}

	public GetMoneyEffect GetSpecialSeasonalTokenMoneyEffect(ResourceShopItem.SpecialSeasonalTokenType type)
	{
		return null;
	}

	public void SetRecoverCoolTime()
	{
	}
}
