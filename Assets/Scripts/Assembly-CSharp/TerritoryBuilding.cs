using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryBuilding : ClickableObject
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAssignLevelSync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

		public int unitId;

		public int slotIdx;

		private UniTask<TerritoryLevelSyncResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CAssignUnits_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public List<int> units;

		public TerritoryBuilding _003C_003E4__this;

		public bool applyLevelSyncResponse;

		private UniTask<TerritoryAssignUnitsResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickUpgradeImmediately_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

		private int _003CcashPrice_003E5__2;

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
	private struct _003COnUpgradeFinished_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

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
	private struct _003CRemove_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

		private UniTask<TerritoryCurrencyResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CReplace_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

		public int toPosIndex;

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
	private struct _003CStore_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

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
	private struct _003CUpgrade_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

		private UniTask<TerritoryBuildBuildingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CUpgradeImmediately_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public TerritoryBuilding _003C_003E4__this;

		private UniTask<TerritoryBuildBuildingResponseModel>.Awaiter _003C_003Eu__1;

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
	private SimpleTimeGauge _upgradeTimeGauge;

	[SerializeField]
	private Text _tokenGenTimerText;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private TextFitter _nameTextFitter;

	[SerializeField]
	private Border _nameBorder;

	[SerializeField]
	private TerritoryMarker _marker;

	public ResourceTerritoryBuilding resBuilding;

	[HideInInspector]
	public TerritoryBuildingData data;

	[HideInInspector]
	public TerritoryBuildingController controller;

	[SerializeField]
	private SpriteFlash _spriteFlash;

	private TimeSpan _upgradeTimeLeft;

	public TimeSpan upgradeTimeLeft => default(TimeSpan);

	public bool isUpgrading => false;

	public void Set(TerritoryBuildingData data)
	{
	}

	public void SetPrefab(string prefabKey)
	{
	}

	private void Reload()
	{
	}

	private void Update()
	{
	}

	private void UpdateTokenGenTimeLeft()
	{
	}

	private void UpdateUpgradeTimeLeft()
	{
	}

	private void OnUpgradeStart()
	{
	}

	[AsyncStateMachine(typeof(_003COnUpgradeFinished_003Ed__22))]
	private void OnUpgradeFinished()
	{
	}

	private void OnUpgradeFinishedImpl()
	{
	}

	public void ShowDropEffect()
	{
	}

	private void ShowUpgradeObjects(bool set)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public override void OnClick(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	[AsyncStateMachine(typeof(_003CStore_003Ed__28))]
	public void Store()
	{
	}

	[AsyncStateMachine(typeof(_003CRemove_003Ed__29))]
	public void Remove()
	{
	}

	[AsyncStateMachine(typeof(_003CReplace_003Ed__30))]
	public void Replace(int toPosIndex)
	{
	}

	[AsyncStateMachine(typeof(_003CUpgrade_003Ed__31))]
	public void Upgrade()
	{
	}

	[AsyncStateMachine(typeof(_003CUpgradeImmediately_003Ed__32))]
	public UniTask UpgradeImmediately()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CAssignUnits_003Ed__33))]
	public UniTask AssignUnits(List<int> units, bool applyLevelSyncResponse)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CAssignLevelSync_003Ed__34))]
	public UniTask AssignLevelSync(int unitId, int slotIdx)
	{
		return default(UniTask);
	}

	public TerritoryMarker.Type GetMarkerType()
	{
		return default(TerritoryMarker.Type);
	}

	public void ShowMarker(TerritoryMarker.Type type)
	{
	}

	public void SetMarkerVisible(bool visible)
	{
	}

	public static int GetUpgradeImmediatelyCashPrice(TimeSpan timeLeft)
	{
		return 0;
	}

	public bool CheckAndShowAssignUnitMarker()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003COnClickUpgradeImmediately_003Ed__40))]
	public void OnClickUpgradeImmediately()
	{
	}
}
