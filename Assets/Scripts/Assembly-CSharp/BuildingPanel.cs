using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BuildingPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckHasRequest_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public BuildingPanel _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickBuyPoint_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BuildingPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.BuildingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickReset_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BuildingPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.BuildingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CSaveBuildingLevels_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public BuildingPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.BuildingResponseModel>.Awaiter _003C_003Eu__1;

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

	public static BuildingPanel Instance;

	[ComponentConnect]
	public Text remainPointText;

	[ComponentConnect]
	public ConditionalGroup buyPointButton;

	[ComponentConnect]
	public GameObject buyObject;

	[SerializeField]
	private ConditionalSetActive levelLockedCond;

	[SerializeField]
	private Text reqLevelText;

	[ComponentConnect]
	public Text buyPointPriceText;

	[ComponentConnect]
	public Text maxBuyText;

	[ComponentConnect]
	public Animator pointFlame;

	[ComponentConnect]
	public BuildingInfoPanel buildingInfoPanel;

	public Canvas canvas;

	public BuildingItem[] buildingItems;

	private BuildingItem _focusedBuilding;

	private int _oldRemainPoint;

	private float _requestTimer;

	private bool _initialized;

	private bool _clanRaidMode;

	private int _clanRaidPreset;

	private Action _onClose;

	public static readonly int LevelInt;

	public static readonly int LevelUp;

	private bool _buyRequestEnded;

	public bool clanRaidMode => false;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ShowImpl()
	{
	}

	public void Show()
	{
	}

	public void ShowFromClanRaid(Action closeCallback, int preset = -1)
	{
	}

	public void Init()
	{
	}

	private void OnEnable()
	{
	}

	public static void ReloadFlameSound(bool set, int remainPoint = 0)
	{
	}

	private void Update()
	{
	}

	public void Reload()
	{
	}

	public void Reload(bool effect)
	{
	}

	private void ReloadForClanRaid(bool effect)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuyPoint_003Ed__36))]
	public void OnClickBuyPoint()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReset_003Ed__37))]
	public void OnClickReset()
	{
	}

	private void ResetForClanRaid()
	{
	}

	public static int FlamePhase(int level)
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003CSaveBuildingLevels_003Ed__40))]
	private UniTask SaveBuildingLevels()
	{
		return default(UniTask);
	}

	public void AddBuildingLevel(int idx, int level)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckHasRequest_003Ed__42))]
	public UniTask CheckHasRequest()
	{
		return default(UniTask);
	}

	public void OnOpenBuildingInfo(int idx)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public int GetRemainPoint()
	{
		return 0;
	}
}
