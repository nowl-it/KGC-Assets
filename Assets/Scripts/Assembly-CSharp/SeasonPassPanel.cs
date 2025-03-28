using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SeasonPassPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public bool processed;

		internal void _003CReceiveAllRewards_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public bool processed;

		internal void _003CReceiveBonusReward_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyLevel_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SeasonPassPanel _003C_003E4__this;

		private UniTask<SeasonPassBuyLevelResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickDecAddPassMission_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SeasonPassPanel _003C_003E4__this;

		private UniTask<DevAddPassMissionResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickDevDeleteAllPassMissions_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SeasonPassPanel _003C_003E4__this;

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
	private struct _003CReceiveAllRewards_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SeasonPassPanel _003C_003E4__this;

		public Transform target;

		private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

		private bool _003CbuyPass_003E5__2;

		private UniTask<SeasonPassReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CReceiveBonusReward_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SeasonPassPanel _003C_003E4__this;

		public Transform target;

		public int bonusId;

		private _003C_003Ec__DisplayClass49_0 _003C_003E8__1;

		private UniTask<SeasonPassReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

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

	public static SeasonPassPanel Instance;

	[ComponentConnect]
	public Text seasonNameText;

	[ComponentConnect]
	public Text remainTimeText;

	[ComponentConnect]
	public UITableView tableView;

	[SerializeField]
	public UIGridView _passLevelItemsView;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	public Text expText;

	[ComponentConnect]
	public Gauge expGauge;

	[ComponentConnect]
	public Image skinImage;

	[ComponentConnect]
	public BuySeasonPassPanel buySeasonPassPanel;

	[ComponentConnect]
	public GameObject passOnlyObject;

	[ComponentConnect]
	public GetMoneyEffect getPointEffect;

	[ComponentConnect]
	public Image passIcon;

	[ComponentConnect]
	public Image premiumIcon;

	[ComponentConnect]
	public CanvasGroup passOnlyEffect;

	[ComponentConnect]
	public CanvasGroup premiumOnlyEffect;

	public GameObject skinPrefab;

	[Header("Test")]
	[SerializeField]
	private InputField _devAddMissionIdInputField;

	public PassBenefitMessageObj passBenefitMessageObj;

	private Sequence _passOnlyEffectTween;

	private Sequence _premiumOnlyEffectTween;

	private bool _init;

	private ResourceSeasonPass _resSeasonPass;

	private bool _receiveRequested;

	private DateTime _seasonUntilAt;

	private string _cachedSkinPrefab;

	private List<ResourceMission> _missions;

	private bool _canGetMissionReward;

	private Action _onBuyComplete;

	public static float receivableEffectAlpha;

	private bool _receiveCalled;

	private RectTransform _content => null;

	public bool receiveRequested => false;

	public void Awake()
	{
	}

	public void Show()
	{
	}

	public void UpdateRemainTime()
	{
	}

	public void Init()
	{
	}

	private void InitPassLevelItems()
	{
	}

	private void SetPassLevelItem(int idx, GameObject go)
	{
	}

	private void Sorting(List<ResourceMission> lst)
	{
	}

	public void Reload(bool showGaugeTween = false)
	{
	}

	private bool CheckShowCondition(ResourceMission resMission)
	{
		return false;
	}

	public int GetMissionCount()
	{
		return 0;
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyLevel_003Ed__46))]
	public void BuyLevel()
	{
	}

	[AsyncStateMachine(typeof(_003CReceiveAllRewards_003Ed__48))]
	public void ReceiveAllRewards(Transform target)
	{
	}

	[AsyncStateMachine(typeof(_003CReceiveBonusReward_003Ed__49))]
	public void ReceiveBonusReward(int bonusId, Transform target)
	{
	}

	private void PrepareRequest(Transform target)
	{
	}

	private void HandleRewardResult(SeasonPassReceiveRewardResponseModel ret)
	{
	}

	public void OnClickBuy()
	{
	}

	public void HandleBuyComplete(ResourceShopItem shopItem)
	{
	}

	public void Update()
	{
	}

	public void ShowOnlyPassEffect()
	{
	}

	public void ShowOnlyPremiumEffect()
	{
	}

	public void ShowSkinPrefab(string prefabName)
	{
	}

	public void OnMissionReroll(int beforeId, int afterId)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDevDeleteAllPassMissions_003Ed__59))]
	public void OnClickDevDeleteAllPassMissions()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDecAddPassMission_003Ed__60))]
	public void OnClickDecAddPassMission()
	{
	}

	public void SubscribeOnBuyComplete(Action action)
	{
	}

	private void OnDestroy()
	{
	}
}
